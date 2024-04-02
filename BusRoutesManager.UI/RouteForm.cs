using BusRoutesManager.Domain.Context;
using BusRoutesManager.Domain.Entities;
using BusRoutesManager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusRoutesManager.UI
{
    public partial class RouteForm : Form
    {
        private UserForm _baseForm;
        private Route _curRoute;
        private RouteNode _fromNode;
        private RouteNode _toNode;
        private BusManagerContext _context;
        private int _userId;
        private DateTime _routeDate;
        private Repository<User> _userRepository;
        private Repository<Ticket> _ticketsRepository;
        public RouteForm(UserForm baseForm, Route curRoute, BusStation fromStation, BusStation toStation, BusManagerContext context, int userId, DateTime routeDate)
        {
            _baseForm = baseForm;
            _curRoute = curRoute;
            _fromNode = curRoute.RouteNodes.First(n => n.Station == fromStation);
            _toNode = curRoute.RouteNodes.First(n => n.Station == toStation);
            _context = context;
            _userId = userId;
            _routeDate = routeDate;
            InitializeComponent();
            SetUI();
            _userRepository = new Repository<User>(_context);
            _ticketsRepository = new Repository<Ticket>(_context);
        }
        public void SetUI()
        {
            labelBusModel.Text = _curRoute.Bus.Model.Title;
            labelBusPlate.Text = _curRoute.Bus.PlateNumber;
            labelDriverName.Text = _curRoute.Driver.FullName;
            labelDriverPhone.Text = _curRoute.Driver.MobilePhone;
            List<RouteNode> orderedNodes = _curRoute.RouteNodes.OrderBy(n => n.ArrivalTime.TimeOfDay).ToList();

            var a = orderedNodes.IndexOf(_curRoute.Tickets.ToList()[0].ArrivalRouteNode);
            var b = orderedNodes.IndexOf(_curRoute.Tickets.ToList()[0].DepartureRouteNode);

            var d = orderedNodes.IndexOf(_toNode);
            var c = orderedNodes.IndexOf(_fromNode);
            
            var intersectionTickets = _curRoute.Tickets.Where(t => t.RouteDate == _routeDate)
                .Where(t => !(orderedNodes.IndexOf(t.ArrivalRouteNode) < orderedNodes.IndexOf(_fromNode)) &&
                            !(orderedNodes.IndexOf(t.DepartureRouteNode) > orderedNodes.IndexOf(_fromNode)))
                .ToList();
            labelSeatsLeft.Text = (_curRoute.Bus.Capacity - intersectionTickets.Count()).ToString();
            labelTicketDate.Text = _routeDate.ToShortDateString();
            labelFrom.Text = $"{_fromNode.Station.Title}(City {_fromNode.Station.City.Title}) - {_fromNode.ArrivalTime.TimeOfDay}";
            labelTo.Text = $"{_toNode.Station.Title}(City {_toNode.Station.City.Title}) - {_toNode.ArrivalTime.TimeOfDay}";

            int nodesThrough = orderedNodes.IndexOf(_toNode) - orderedNodes.IndexOf(_fromNode);
            labelPrice.Text = (50 * nodesThrough).ToString();
        }

        private void RouteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _baseForm.Enabled = true;
            _baseForm.Show();
        }

        private void RouteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(labelSeatsLeft.Text) == 0)
            {
                MessageBox.Show("No tickets left, sorry");
                return;
            }
            List<RouteNode> orderedNodes = _curRoute.RouteNodes.OrderBy(n => n.ArrivalTime.TimeOfDay).ToList();
            int nodesThrough = orderedNodes.IndexOf(_toNode) - orderedNodes.IndexOf(_fromNode);
            Ticket currentTicket = new Ticket()
            {
                User = _userRepository.GetById(_userId),
                Price = 50 * nodesThrough,
                DepartureRouteNodeId = _fromNode.Id,
                DepartureRouteNode = _fromNode,
                ArrivalRouteNodeId = _toNode.Id,
                ArrivalRouteNode = _toNode,
                Route = _curRoute,
                RouteDate = _routeDate
            };
            _ticketsRepository.Insert(currentTicket);
            _ticketsRepository.SaveChanges();
            MessageBox.Show("You were issued a ticket with id: " + currentTicket.Id);
            this.Update();
        }
    }
}
