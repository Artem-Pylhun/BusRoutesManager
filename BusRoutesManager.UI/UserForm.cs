using BusRoutesManager.Domain.Context;
using BusRoutesManager.Domain.Entities;
using BusRoutesManager.Repositories;
using Microsoft.EntityFrameworkCore;
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
    public partial class UserForm : Form
    {
        private readonly BusManagerContext _ctx;
        private readonly Form1 baseform;
        private readonly int userId;
        private readonly Repository<Route> _routsRepository;
        private readonly Repository<BusStation> _stationsRepository;
        private readonly Repository<City> _cityRepository;
        public UserForm(Form1 form, BusManagerContext ctx, int userId)
        {
            InitializeComponent();
            baseform = form;
            _ctx = ctx;
            this.userId = userId;
            _routsRepository = new Repository<Route>(_ctx);
            _stationsRepository = new Repository<BusStation>(_ctx);
            _cityRepository = new Repository<City>(_ctx);
            
            UpdateCities();
            UpdateStations();
        }
        private void UpdateCities()
        {
            var cities = _cityRepository.GetAll().Select(c => $"{c.Id}){c.Title}");
            comboBoxFromCity.Items.Clear();
            comboBoxFromCity.Items.AddRange(cities.ToArray());

            comboBoxToCity.Items.Clear();
            comboBoxToCity.Items.AddRange(cities.ToArray());
        }
        private void UpdateStations()
        {
            if (comboBoxToCity.SelectedIndex != -1)
            {
                comboBoxToStation.Items.Clear();
                City toCity = _cityRepository.GetById(int.Parse(comboBoxToCity.SelectedItem.ToString().Split(')')[0]));
                comboBoxToStation.Items.AddRange(toCity.BusStations.Select(s => $"{s.Id}){s.Title}").ToArray());
            }
            if (comboBoxFromCity.SelectedIndex != -1)
            {
                comboBoxFromStation.Items.Clear();
                City fromCity = _cityRepository.GetById(int.Parse(comboBoxFromCity.SelectedItem.ToString().Split(')')[0]));
                comboBoxFromStation.Items.AddRange(fromCity.BusStations.Select(s => $"{s.Id}){s.Title}").ToArray());
            }
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            baseform.Enabled = true;
            baseform.Show();
        }
        private void comboBoxFromCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStations();
        }

        private void comboBoxToCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStations();
        }
        private void btnFindRoutes_Click(object sender, EventArgs e)
        {
            if (comboBoxFromCity.SelectedIndex == -1 ||
                comboBoxToCity.SelectedIndex == -1 ||
                comboBoxFromStation.SelectedIndex == -1 ||
                comboBoxToStation.SelectedIndex == -1)
            {
                MessageBox.Show("Select cities and stations first!");
                return;
            }
            var dayOfWeek = (int)dateTimePicker.Value.DayOfWeek;
            BusStation fromStation = _stationsRepository.GetById(int.Parse(comboBoxFromStation.SelectedItem.ToString().Split(')')[0]));
            BusStation toStation = _stationsRepository.GetById(int.Parse(comboBoxToStation.SelectedItem.ToString().Split(')')[0]));
            var routes = _routsRepository.GetAll()
                .Where(r => r.DayOfWeek == dayOfWeek)
                .Where(r => r.RouteNodes.FirstOrDefault(n => n.Station == fromStation) != null &&
                    r.RouteNodes.FirstOrDefault(n => n.Station == toStation) != null)
                .Where(r => r.RouteNodes.First(n => n.Station == fromStation).ArrivalTime.TimeOfDay <
                    r.RouteNodes.First(n => n.Station == toStation).ArrivalTime.TimeOfDay)
                .OrderBy(r => r.ArrivalTime.TimeOfDay).ToList();

            // Clear the panel if it already contains any controls
            panelRoutes.Controls.Clear();

            // Define the starting position for displaying route information
            int x = 10;
            int y = 10;

            // Iterate over the list of routes
            Font baseFont = new Font(FontFamily.GenericSansSerif, 12);
            foreach (Route route in routes)
            {
                // Create a panel for the route
                Panel routePanel = new Panel();
                routePanel.Tag = route.Id;
                routePanel.BorderStyle = BorderStyle.FixedSingle;
                routePanel.Size = new Size(this.Width - 50, 100); // Adjust size as needed
                routePanel.Location = new Point(x, y);
                routePanel.Tag = route.Id;
                routePanel.DoubleClick += PanelRoute_DoubleClick;

                // Create a label to display route information
                Label routeLabel = new Label();
                routeLabel.Text = $"Bus plate: {route.Bus.PlateNumber}, Driver: {route.Driver.FullName.ToString()}\n\nDeparture: {route.DepartureTime.ToShortTimeString()}, Arrival: {route.ArrivalTime.ToShortTimeString()}";
                routeLabel.AutoSize = true;
                routeLabel.Location = new Point(10, 10);
                routePanel.Controls.Add(routeLabel);

                // Add the route panel to the main panel
                panelRoutes.Controls.Add(routePanel);
                
                // Increment y coordinate for the next route
                y += 120; // Adjust this value as needed
            }
        }
        private void PanelRoute_DoubleClick(object sender, EventArgs e)
        {
            BusStation fromStation = _stationsRepository.GetById(int.Parse(comboBoxFromStation.SelectedItem.ToString().Split(')')[0]));
            BusStation toStation = _stationsRepository.GetById(int.Parse(comboBoxToStation.SelectedItem.ToString().Split(')')[0]));
            this.Enabled = false;
            RouteForm child = new RouteForm(this, _routsRepository.GetById(int.Parse((sender as Panel).Tag.ToString())), fromStation, toStation, _ctx, userId, dateTimePicker.Value);
            child.Show();
        }
    }
}
