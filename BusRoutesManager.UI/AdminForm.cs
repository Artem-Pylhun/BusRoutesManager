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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BusRoutesManager.UI
{
    public partial class AdminForm : Form
    {
        private readonly BusManagerContext _ctx;
        private readonly Form1 baseform;
        private readonly Repository<Bus> busRepository;
        private readonly Repository<BusStation> busStationRepository;
        private readonly Repository<City> cityRepository;
        private readonly Repository<Driver> driverRepository;
        private readonly Repository<Model> modelRepository;
        private readonly Repository<Route> routeRepository;
        private readonly Repository<RouteNode> routeNodeRepository;
        private readonly Repository<Ticket> ticketRepository;
        private readonly Repository<User> userRepository;
        private readonly Regex regex = new Regex("^[A-Z]{1,3}-[A-Z]{1,2}-[0-9]{1,4}$");
        public AdminForm(Form1 form, BusManagerContext ctx)
        {
            InitializeComponent();
            baseform = form;
            _ctx = ctx;
            busRepository = new Repository<Bus>(_ctx);
            busStationRepository = new Repository<BusStation>(_ctx);
            cityRepository = new Repository<City>(_ctx);
            driverRepository = new Repository<Driver>(_ctx);
            modelRepository = new Repository<Model>(_ctx);
            routeRepository = new Repository<Route>(_ctx);
            routeNodeRepository = new Repository<RouteNode>(_ctx);
            ticketRepository = new Repository<Ticket>(_ctx);
            userRepository = new Repository<User>(_ctx);
            //list boxes
            lbBuses.Items.AddRange(busRepository.GetAll().Select(b => $"{b.Id} Seats: {b.Capacity} {b.Model.Title} {b.PlateNumber}").ToArray());
            lbModels.Items.AddRange(modelRepository.GetAll().Select(m => m.Title).ToArray());
            lbDrivers.Items.AddRange(driverRepository.GetAll().Select(d => $"{d.FullName}, {d.Age}, {d.MobilePhone}").ToArray());
            lbUsers.Items.AddRange(userRepository.GetAll().Select(u => $"{u.FullName}, {u.DateOfBirth.ToShortDateString()}, {u.Email}, Admin: {u.IsAdmin}").ToArray());
            lbCities.Items.AddRange(cityRepository.GetAll().Select(c => c.Title).ToArray());
            lbBusStations.Items.AddRange(busStationRepository.GetAll().Select(b => $"{b.Title}, {b.City.Title}, {b.Address}, {b.ShiftStart}-{b.ShiftEnd}").ToArray());
            //combo boxes
            cbBusModel.Items.AddRange(modelRepository.GetAll().Select(x => x.Title).ToArray());
            cbBusStationCity.Items.AddRange(cityRepository.GetAll().Select(x => x.Title).ToArray());
            //buttons
            btnEditBus.Enabled = false;
            btnDelBus.Enabled = false;

            btnEditModel.Enabled = false;
            btnDelModel.Enabled = false;

            btnEditDriver.Enabled = false;
            btnDelDriver.Enabled = false;

            btnEditUser.Enabled = false;
            btnDelUser.Enabled = false;

            btnEditCity.Enabled = false;
            btnDelCity.Enabled = false;

            btnEditBusStation.Enabled = false;
            btnDelBusStation.Enabled = false;
            //other components
            dtpBusStationShiftEnd.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dtpBusStationShiftStart.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            baseform.Enabled = true;
            baseform.Show();
        }

        private void btnBus(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Tag.ToString())
            {
                case "add":
                    if (cbBusModel.SelectedIndex != -1 && regex.IsMatch(tbBusPlateNum.Text))
                    {
                        busRepository.Insert(new Bus()
                        {
                            Model = modelRepository.GetAll().FirstOrDefault(x => x.Title == cbBusModel.SelectedItem.ToString()),
                            Capacity = (int)nudBusCapacity.Value,
                            PlateNumber = tbBusPlateNum.Text
                        });
                        busRepository.SaveChanges();
                        UpdateBusListBox();
                    }
                    else
                    {
                        MessageBox.Show("Bus can't be added. Fill in all the text boxes.", "Adding Bus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "edit":
                    if (cbBusModel.SelectedIndex != -1 && regex.IsMatch(tbBusPlateNum.Text))
                    {
                        var current_model = modelRepository.GetAll().FirstOrDefault(x => x.Title == cbBusModel.SelectedItem.ToString());
                        var currentBus = busRepository.GetAll().FirstOrDefault(x => x.Id == int.Parse(lbBuses.SelectedItem.ToString().Split(" ")[0]));
                        currentBus.Model = current_model;
                        currentBus.Capacity = (int)nudBusCapacity.Value;
                        currentBus.PlateNumber = tbBusPlateNum.Text;
                        busRepository.SaveChanges();
                        UpdateBusListBox();
                    }
                    break;
                case "del":
                    if (lbBuses.SelectedIndex != -1)
                    {
                        string selectedBusStr = lbBuses.SelectedItem.ToString();
                        int selectedBusId = int.Parse(selectedBusStr.Split(" ")[0]);

                        if (selectedBusId <= 0)
                        {
                            MessageBox.Show("Bus doesn't exist.", "Deleting Bus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        busRepository.Delete(selectedBusId);
                        busRepository.SaveChanges();
                        UpdateBusListBox();
                        MessageBox.Show("Bus was deleted successfully", "Deleting Bus", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Bus can't be deleted. Did you pick it in listbox?", "Deleting Bus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void UpdateBusListBox()
        {
            lbBuses.Items.Clear();
            lbBuses.Items.AddRange(busRepository.GetAll().Select(b => $"{b.Id} Seats: {b.Capacity} {b.Model.Title} {b.PlateNumber}").ToArray());
            tbBusPlateNum.Text = string.Empty;
            nudBusCapacity.Value = nudBusCapacity.Minimum;
            cbBusModel.SelectedIndex = -1;
        }

        private void btnModel(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Tag.ToString())
            {
                case "add":
                    if (tbModelTitle.Text != string.Empty
                        && modelRepository.GetAll().FirstOrDefault(m => m.Title == tbModelTitle.Text) != null)
                    {
                        modelRepository.Insert(new Model()
                        {
                            Title = tbModelTitle.Text
                        });
                        modelRepository.SaveChanges();
                        UpdateModelsListBox();
                    }
                    else
                    {
                        MessageBox.Show("Model can't be added. Fill in all the text boxes.", "Adding Model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "edit":
                    if (tbModelTitle.Text != string.Empty)
                    {
                        string model = lbModels.SelectedItem.ToString();
                        var selectedModel = modelRepository.GetAll().FirstOrDefault(x => x.Title == model);

                        selectedModel.Title = tbModelTitle.Text;

                        modelRepository.Update(selectedModel);
                        modelRepository.SaveChanges();
                        UpdateModelsListBox();
                        UpdateBusListBox();
                        MessageBox.Show("Model was updated successfully", "Updating model", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Model can't be updated. Are there models in listbox?", "Updating model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "del":
                    if (lbModels.SelectedIndex != -1)
                    {
                        string selectedModelStr = lbModels.SelectedItem.ToString();
                        var selectedModel = modelRepository.GetAll().FirstOrDefault(m => m.Title == selectedModelStr);

                        if (selectedModel == null)
                        {
                            MessageBox.Show("Model doesn't exist.", "Deleting Model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        modelRepository.Delete(selectedModel);
                        modelRepository.SaveChanges();
                        UpdateModelsListBox();
                        MessageBox.Show("Model was deleted successfully", "Deleting Model", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Model can't be deleted. Did you pick it in listbox?", "Deleting Driver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void UpdateModelsListBox()
        {
            lbModels.Items.Clear();
            lbModels.Items.AddRange(modelRepository.GetAll().Select(x => x.Title).ToArray());
            cbBusModel.Items.Clear();
            cbBusModel.Items.AddRange(modelRepository.GetAll().Select(x => x.Title).ToArray());
            cbBusModel.SelectedIndex = -1;
            tbModelTitle.Text = string.Empty;
        }

        private void btnDriver(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Tag.ToString())
            {
                case "add":
                    if (tbDriverFullName.Text != string.Empty)
                    {
                        driverRepository.Insert(new Driver()
                        {
                            FullName = tbDriverFullName.Text,
                            Age = (int)nudDriverAge.Value,
                            MobilePhone = tbDriverMobilePhone.Text
                        });
                        driverRepository.SaveChanges();
                        UpdateDriversListBox();
                    }
                    else
                    {
                        MessageBox.Show("Driver can't be added. Fill in all the text boxes.", "Adding Driver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "edit":
                    if (tbDriverFullName.Text != string.Empty)
                    {
                        string driver = lbDrivers.SelectedItem.ToString();
                        string[] s = driver.Split(',');
                        var selectedDriver = driverRepository.GetAll().FirstOrDefault(x => x.FullName == s[0].Trim() && x.MobilePhone == s[2].Trim());

                        selectedDriver.FullName = tbDriverFullName.Text;
                        selectedDriver.Age = (int)nudDriverAge.Value;
                        selectedDriver.MobilePhone = tbDriverMobilePhone.Text;

                        driverRepository.Update(selectedDriver);
                        driverRepository.SaveChanges();
                        UpdateDriversListBox();
                        MessageBox.Show("Driver was updated successfully", "Updating driver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Driver can't be updated. Are there drivers in listbox?", "Updating driver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "del":
                    if (lbDrivers.SelectedIndex != -1)
                    {
                        string driver = lbDrivers.SelectedItem.ToString();
                        string[] s = driver.Split(',');
                        var selectedDriver = driverRepository.GetAll().FirstOrDefault(x => x.FullName == s[0].Trim() && x.MobilePhone == s[2].Trim());
                        if (selectedDriver == null)
                        {
                            MessageBox.Show("Driver doesn't exist.", "Deleting Driver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        driverRepository.Delete(selectedDriver);
                        driverRepository.SaveChanges();
                        UpdateDriversListBox();
                        MessageBox.Show("Driver was deleted successfully", "Deleting Driver", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Driver can't be deleted. Did you pick it in listbox?", "Deleting Driver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
        private void UpdateDriversListBox()
        {
            lbDrivers.Items.Clear();
            lbDrivers.Items.AddRange(driverRepository.GetAll().Select(d => $"{d.FullName}, {d.Age}, {d.MobilePhone}").ToArray());
        }
        private void btnUser(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Tag.ToString())
            {
                case "add":
                    if (tbUserFullName.Text != string.Empty
                        && tbUserEmail.Text != string.Empty
                        && tbUserPassword.Text != string.Empty
                        && userRepository.GetAll().FirstOrDefault(u => u.Email == tbUserEmail.Text) == null)
                    {
                        userRepository.Insert(new User()
                        {
                            FullName = tbDriverFullName.Text,


                        });
                        userRepository.SaveChanges();
                        UpdateUsersListBox();
                    }
                    else
                    {
                        MessageBox.Show("User can't be added. Fill in all the text boxes.", "Adding User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "edit":
                    if (tbUserFullName.Text != string.Empty
                        && tbUserEmail.Text != string.Empty
                        && tbUserPassword.Text != string.Empty)
                    {
                        string user = lbUsers.SelectedItem.ToString();
                        string[] s = user.Split(',');
                        var selectedUser = userRepository.GetAll().FirstOrDefault(x => x.Email == s[2].Trim());

                        selectedUser.FullName = tbUserFullName.Text;
                        selectedUser.DateOfBirth = dtpUserDob.Value;
                        selectedUser.Email = tbUserEmail.Text;
                        selectedUser.Password = tbUserPassword.Text;
                        selectedUser.IsAdmin = cbUserIsAdmin.Checked;


                        userRepository.Update(selectedUser);
                        userRepository.SaveChanges();
                        UpdateUsersListBox();
                        MessageBox.Show("User was updated successfully", "Updating user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User can't be updated. Are there users in listbox?", "Updating user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "del":
                    if (lbUsers.SelectedIndex != -1)
                    {
                        string user = lbUsers.SelectedItem.ToString();
                        string[] s = user.Split(',');
                        var selectedUser = userRepository.GetAll().FirstOrDefault(x => x.Email == s[2].Trim());
                        if (selectedUser == null)
                        {
                            MessageBox.Show("User doesn't exist.", "Deleting User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        userRepository.Delete(selectedUser);
                        userRepository.SaveChanges();
                        UpdateUsersListBox();
                        MessageBox.Show("User was deleted successfully", "Deleting User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("User can't be deleted. Did you pick it in listbox?", "Deleting User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
        private void UpdateUsersListBox()
        {
            lbUsers.Items.Clear();
            lbUsers.Items.AddRange(userRepository.GetAll().Select(u => $"{u.FullName}, {u.DateOfBirth.ToShortDateString()}, {u.Email}, Admin: {u.IsAdmin}").ToArray());
        }
        private void btnCity(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Tag.ToString())
            {
                case "add":
                    if (tbCityTitle.Text != string.Empty
                        && cityRepository.GetAll().FirstOrDefault(m => m.Title == tbCityTitle.Text) == null)
                    {
                        cityRepository.Insert(new City()
                        {
                            Title = tbCityTitle.Text
                        });
                        cityRepository.SaveChanges();
                        UpdateCitiesListBox();
                    }
                    else
                    {
                        MessageBox.Show("City can't be added. Fill in all the text boxes.", "Adding City", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "edit":
                    if (tbCityTitle.Text != string.Empty)
                    {
                        string city = lbCities.SelectedItem.ToString();
                        var selectedCity = cityRepository.GetAll().FirstOrDefault(x => x.Title == city);

                        selectedCity.Title = tbCityTitle.Text;

                        cityRepository.Update(selectedCity);
                        cityRepository.SaveChanges();
                        UpdateCitiesListBox();
                        UpdateBusStationsListBox();
                        MessageBox.Show("City was updated successfully", "Updating City", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("City can't be updated. Are there cities in listbox?", "Updating City", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "del":
                    if (lbCities.SelectedIndex != -1)
                    {
                        string selectedCityStr = lbCities.SelectedItem.ToString();
                        var selectedCity = cityRepository.GetAll().FirstOrDefault(m => m.Title == selectedCityStr);

                        if (selectedCity == null)
                        {
                            MessageBox.Show("City doesn't exist.", "Deleting City", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cityRepository.Delete(selectedCity);
                        cityRepository.SaveChanges();
                        UpdateCitiesListBox();
                        MessageBox.Show("City was deleted successfully", "Deleting City", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("City can't be deleted. Did you pick it in listbox?", "Deleting City", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
        private void UpdateCitiesListBox()
        {
            lbCities.Items.Clear();
            lbCities.Items.AddRange(cityRepository.GetAll().Select(x => x.Title).ToArray());
            cbBusStationCity.Items.Clear();
            cbBusStationCity.Items.AddRange(cityRepository.GetAll().Select(x => x.Title).ToArray());
            cbBusStationCity.SelectedIndex = -1;
            tbCityTitle.Text = string.Empty;
        }

        private void lbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCities.SelectedIndex != -1)
            {
                btnEditCity.Enabled = true;
                btnDelCity.Enabled = true;

                City selectedCity = cityRepository.GetAll().FirstOrDefault(c => c.Title == lbCities.SelectedItem.ToString());
                tbCityTitle.Text = selectedCity.Title;
            }
        }

        private void btnBusStation(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Tag.ToString())
            {
                case "add":
                    if (cbBusStationCity.SelectedIndex != -1
                        && tbBusStationTitle.Text != string.Empty
                        && tbBusStationAddress.Text != string.Empty
                        && dtpBusStationShiftStart.Value.TimeOfDay < dtpBusStationShiftEnd.Value.TimeOfDay)
                    {
                        busStationRepository.Insert(new BusStation()
                        {
                            Title = tbBusStationTitle.Text,
                            City = cityRepository.GetAll().FirstOrDefault(x => x.Title == cbBusStationCity.SelectedItem.ToString()),
                            Address = tbBusStationAddress.Text,
                            ShiftStart = dtpBusStationShiftStart.Value,
                            ShiftEnd = dtpBusStationShiftStart.Value
                        });
                        busStationRepository.SaveChanges();
                        UpdateBusStationsListBox();
                    }
                    else
                    {
                        MessageBox.Show("Bus station can't be added. Fill in all the text boxes.", "Adding Bus Station", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "edit":
                    if (cbBusStationCity.SelectedIndex != -1
                        && tbBusStationTitle.Text != string.Empty
                        && tbBusStationAddress.Text != string.Empty
                        && dtpBusStationShiftStart.Value.TimeOfDay < dtpBusStationShiftEnd.Value.TimeOfDay)
                    {
                        var current_city = cityRepository.GetAll().FirstOrDefault(x => x.Title == cbBusStationCity.SelectedItem.ToString());
                        var currentBusStation = busStationRepository.GetAll().FirstOrDefault(x => x.Title == lbBusStations.SelectedItem.ToString().Split(" ")[0].Trim() && x.City == current_city);
                        currentBusStation.Title = tbBusStationTitle.Text;
                        currentBusStation.City = current_city;
                        currentBusStation.Address = tbBusStationAddress.Text;
                        currentBusStation.ShiftStart = dtpBusStationShiftStart.Value;
                        currentBusStation.ShiftEnd = dtpBusStationShiftEnd.Value;
                        busStationRepository.Update(currentBusStation);
                        busStationRepository.SaveChanges();
                        UpdateBusListBox();
                    }
                    break;
                case "del":
                    if (lbBusStations.SelectedIndex != -1)
                    {
                        var current_city = cityRepository.GetAll().FirstOrDefault(x => x.Title == cbBusStationCity.SelectedItem.ToString());
                        var currentBusStation = busStationRepository.GetAll().FirstOrDefault(x => x.Title == lbBusStations.SelectedItem.ToString().Split(" ")[0].Trim() && x.City == current_city);
                        if (currentBusStation == null)
                        {
                            MessageBox.Show("Bus station doesn't exist.", "Deleting Bus Station", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        busStationRepository.Delete(currentBusStation);
                        busStationRepository.SaveChanges();
                        UpdateBusStationsListBox();
                        MessageBox.Show("Bus station was deleted successfully", "Deleting Bus Station", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Bus station can't be deleted. Did you pick it in listbox?", "Deleting Bus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
        private void UpdateBusStationsListBox()
        {
            lbBusStations.Items.Clear();
            lbBusStations.Items.AddRange(busStationRepository.GetAll().Select(b => $"{b.Title}, {b.City.Title}, {b.Address}, {b.ShiftStart}-{b.ShiftEnd}").ToArray());
            tbBusStationTitle.Text = string.Empty;
            tbBusStationAddress.Text = string.Empty;
            dtpBusStationShiftStart.Value = DateTime.Now.Date.AddHours(0);
            dtpBusStationShiftEnd.Value = DateTime.Now.Date.AddHours(12);
            cbBusStationCity.SelectedIndex = -1;
        }
        private void lbBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBuses.SelectedIndex != -1)
            {
                btnEditBus.Enabled = true;
                btnDelBus.Enabled = true;
                Bus selectedBus = busRepository.GetAll().FirstOrDefault(m => m.Id == int.Parse(lbBuses.SelectedItem.ToString().Split(" ")[0]));
                cbBusModel.SelectedItem = selectedBus.Model.Title;
                nudBusCapacity.Value = selectedBus.Capacity;
                tbBusPlateNum.Text = selectedBus.PlateNumber;
            }
        }

        private void lbModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbModels.SelectedIndex != -1)
            {
                btnEditModel.Enabled = true;
                btnDelModel.Enabled = true;

                Model selectedModel = modelRepository.GetAll().FirstOrDefault(m => m.Title == lbModels.SelectedItem.ToString());
                tbModelTitle.Text = selectedModel.Title;
            }
        }

        private void lbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedIndex != -1)
            {
                btnEditDriver.Enabled = true;
                btnDelDriver.Enabled = true;

                string driver = lbDrivers.SelectedItem.ToString();
                string[] s = driver.Split(',');
                var selectedDriver = driverRepository.GetAll().FirstOrDefault(x => x.FullName == s[0].Trim() && x.MobilePhone == s[2].Trim());
                tbDriverFullName.Text = selectedDriver.FullName;
                nudDriverAge.Value = selectedDriver.Age;
                tbDriverMobilePhone.Text = selectedDriver.MobilePhone;
            }
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditUser.Enabled = true;
            btnDelUser.Enabled = true;

            string user = lbUsers.SelectedItem.ToString();
            string[] s = user.Split(',');
            var selectedUser = userRepository.GetAll().FirstOrDefault(x => x.FullName == s[0].Trim() && x.Email == s[2].Trim());

            tbUserFullName.Text = selectedUser.FullName;
            dtpUserDob.Value = selectedUser.DateOfBirth;
            tbUserEmail.Text = selectedUser.Email;
            tbUserPassword.Text = selectedUser.Password;
            cbUserIsAdmin.Checked = selectedUser.IsAdmin;

        }

        private void lbBusStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBusStations.SelectedIndex != -1)
            {
                btnEditBusStation.Enabled = true;
                btnDelBusStation.Enabled = true;
                BusStation selectedBusStation = busStationRepository.GetAll().FirstOrDefault(x => x.Title == lbBusStations.SelectedItem.ToString().Split()[0].Trim() && x.City.Title == lbBusStations.SelectedItem.ToString().Split()[1].Trim());
                tbBusStationTitle.Text = selectedBusStation.Title;
                cbBusStationCity.SelectedItem = selectedBusStation.City.Title;
                tbBusStationAddress.Text = selectedBusStation.Address;
                dtpBusStationShiftStart.Value = selectedBusStation.ShiftStart;
                dtpBusStationShiftEnd.Value = selectedBusStation.ShiftEnd;
            }
        }
    }


}
