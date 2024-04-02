namespace BusRoutesManager.UI
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnDelModel = new Button();
            btnEditModel = new Button();
            btnDelBus = new Button();
            btnAddModel = new Button();
            btnEditBus = new Button();
            btnAddBus = new Button();
            tbModelTitle = new TextBox();
            lbModels = new ListBox();
            lbBuses = new ListBox();
            nudBusCapacity = new NumericUpDown();
            tbBusPlateNum = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label1 = new Label();
            cbBusModel = new ComboBox();
            tabPage2 = new TabPage();
            btnDelUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            btnDelDriver = new Button();
            btnEditDriver = new Button();
            btnAddDriver = new Button();
            lbDrivers = new ListBox();
            lbUsers = new ListBox();
            cbUserIsAdmin = new CheckBox();
            dtpUserDob = new DateTimePicker();
            label14 = new Label();
            label15 = new Label();
            label13 = new Label();
            label10 = new Label();
            label12 = new Label();
            label9 = new Label();
            label11 = new Label();
            tbUserPassword = new TextBox();
            label8 = new Label();
            tbUserEmail = new TextBox();
            label7 = new Label();
            tbDriverMobilePhone = new TextBox();
            tbUserFullName = new TextBox();
            nudDriverAge = new NumericUpDown();
            tbDriverFullName = new TextBox();
            tabPage3 = new TabPage();
            dtpBusStationShiftEnd = new DateTimePicker();
            dtpBusStationShiftStart = new DateTimePicker();
            cbBusStationCity = new ComboBox();
            btnDelBusStation = new Button();
            btnEditBusStation = new Button();
            btnAddBusStation = new Button();
            tbBusStationAddress = new TextBox();
            tbBusStationTitle = new TextBox();
            lbBusStations = new ListBox();
            label18 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            btnDelCity = new Button();
            btnEditCity = new Button();
            btnAddCity = new Button();
            tbCityTitle = new TextBox();
            lbCities = new ListBox();
            label16 = new Label();
            label17 = new Label();
            tabPage4 = new TabPage();
            nudTicketPrice = new NumericUpDown();
            dtpTicketRouteDate = new DateTimePicker();
            dtpRouteNodeArrivalTime = new DateTimePicker();
            cbRouteNodeRoute = new ComboBox();
            cbRouteNodeStation = new ComboBox();
            btnDelRouteNode = new Button();
            btnEditRouteNode = new Button();
            btnAddRouteNode = new Button();
            lbRouteNodes = new ListBox();
            label25 = new Label();
            label30 = new Label();
            label32 = new Label();
            label31 = new Label();
            label34 = new Label();
            cbTicketRoute = new ComboBox();
            cbTicketDepartureStation = new ComboBox();
            cbTicketArrivalStation = new ComboBox();
            cbTicketUser = new ComboBox();
            btnDelTicket = new Button();
            btnEditTicket = new Button();
            btnAddTicket = new Button();
            lbTickets = new ListBox();
            label40 = new Label();
            label24 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            tabPage5 = new TabPage();
            nudRouteDayOfWeek = new NumericUpDown();
            dtpRouteDepartureDate = new DateTimePicker();
            dtpRouteArrivalTime = new DateTimePicker();
            label36 = new Label();
            label33 = new Label();
            cbRouteDriver = new ComboBox();
            cbRouteBus = new ComboBox();
            btnDelRoute = new Button();
            btnEditRoute = new Button();
            btnAddRoute = new Button();
            lbRoutes = new ListBox();
            label35 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBusCapacity).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDriverAge).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTicketPrice).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRouteDayOfWeek).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(727, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDelModel);
            tabPage1.Controls.Add(btnEditModel);
            tabPage1.Controls.Add(btnDelBus);
            tabPage1.Controls.Add(btnAddModel);
            tabPage1.Controls.Add(btnEditBus);
            tabPage1.Controls.Add(btnAddBus);
            tabPage1.Controls.Add(tbModelTitle);
            tabPage1.Controls.Add(lbModels);
            tabPage1.Controls.Add(lbBuses);
            tabPage1.Controls.Add(nudBusCapacity);
            tabPage1.Controls.Add(tbBusPlateNum);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cbBusModel);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(719, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bus | Model";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelModel
            // 
            btnDelModel.Location = new Point(595, 366);
            btnDelModel.Name = "btnDelModel";
            btnDelModel.Size = new Size(94, 29);
            btnDelModel.TabIndex = 6;
            btnDelModel.Tag = "del";
            btnDelModel.Text = "Delete";
            btnDelModel.UseVisualStyleBackColor = true;
            btnDelModel.Click += btnModel;
            // 
            // btnEditModel
            // 
            btnEditModel.Location = new Point(495, 366);
            btnEditModel.Name = "btnEditModel";
            btnEditModel.Size = new Size(94, 29);
            btnEditModel.TabIndex = 6;
            btnEditModel.Tag = "edit";
            btnEditModel.Text = "Edit";
            btnEditModel.UseVisualStyleBackColor = true;
            btnEditModel.Click += btnModel;
            // 
            // btnDelBus
            // 
            btnDelBus.Location = new Point(237, 366);
            btnDelBus.Name = "btnDelBus";
            btnDelBus.Size = new Size(94, 29);
            btnDelBus.TabIndex = 6;
            btnDelBus.Tag = "del";
            btnDelBus.Text = "Delete";
            btnDelBus.UseVisualStyleBackColor = true;
            btnDelBus.Click += btnBus;
            // 
            // btnAddModel
            // 
            btnAddModel.Location = new Point(393, 366);
            btnAddModel.Name = "btnAddModel";
            btnAddModel.Size = new Size(94, 29);
            btnAddModel.TabIndex = 6;
            btnAddModel.Tag = "add";
            btnAddModel.Text = "Add";
            btnAddModel.UseVisualStyleBackColor = true;
            btnAddModel.Click += btnModel;
            // 
            // btnEditBus
            // 
            btnEditBus.Location = new Point(137, 366);
            btnEditBus.Name = "btnEditBus";
            btnEditBus.Size = new Size(94, 29);
            btnEditBus.TabIndex = 6;
            btnEditBus.Tag = "edit";
            btnEditBus.Text = "Edit";
            btnEditBus.UseVisualStyleBackColor = true;
            btnEditBus.Click += btnBus;
            // 
            // btnAddBus
            // 
            btnAddBus.Location = new Point(35, 366);
            btnAddBus.Name = "btnAddBus";
            btnAddBus.Size = new Size(94, 29);
            btnAddBus.TabIndex = 6;
            btnAddBus.Tag = "add";
            btnAddBus.Text = "Add";
            btnAddBus.UseVisualStyleBackColor = true;
            btnAddBus.Click += btnBus;
            // 
            // tbModelTitle
            // 
            tbModelTitle.Location = new Point(564, 104);
            tbModelTitle.Name = "tbModelTitle";
            tbModelTitle.Size = new Size(125, 27);
            tbModelTitle.TabIndex = 5;
            // 
            // lbModels
            // 
            lbModels.FormattingEnabled = true;
            lbModels.Location = new Point(392, 58);
            lbModels.Name = "lbModels";
            lbModels.Size = new Size(150, 284);
            lbModels.TabIndex = 4;
            lbModels.SelectedIndexChanged += lbModels_SelectedIndexChanged;
            // 
            // lbBuses
            // 
            lbBuses.FormattingEnabled = true;
            lbBuses.Location = new Point(8, 58);
            lbBuses.Name = "lbBuses";
            lbBuses.Size = new Size(150, 284);
            lbBuses.TabIndex = 4;
            lbBuses.Tag = "bus";
            lbBuses.SelectedIndexChanged += lbBuses_SelectedIndexChanged;
            // 
            // nudBusCapacity
            // 
            nudBusCapacity.Location = new Point(181, 199);
            nudBusCapacity.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            nudBusCapacity.Name = "nudBusCapacity";
            nudBusCapacity.Size = new Size(150, 27);
            nudBusCapacity.TabIndex = 3;
            nudBusCapacity.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // tbBusPlateNum
            // 
            tbBusPlateNum.Location = new Point(185, 275);
            tbBusPlateNum.Name = "tbBusPlateNum";
            tbBusPlateNum.Size = new Size(151, 27);
            tbBusPlateNum.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 252);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Plate number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 176);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 1;
            label3.Text = "Capacity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(564, 12);
            label5.Name = "label5";
            label5.Size = new Size(83, 31);
            label5.TabIndex = 1;
            label5.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(143, 12);
            label4.Name = "label4";
            label4.Size = new Size(75, 31);
            label4.TabIndex = 1;
            label4.Text = "Buses";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(609, 68);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 1;
            label6.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 87);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Model";
            // 
            // cbBusModel
            // 
            cbBusModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusModel.FormattingEnabled = true;
            cbBusModel.Location = new Point(180, 123);
            cbBusModel.Name = "cbBusModel";
            cbBusModel.Size = new Size(151, 28);
            cbBusModel.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDelUser);
            tabPage2.Controls.Add(btnEditUser);
            tabPage2.Controls.Add(btnAddUser);
            tabPage2.Controls.Add(btnDelDriver);
            tabPage2.Controls.Add(btnEditDriver);
            tabPage2.Controls.Add(btnAddDriver);
            tabPage2.Controls.Add(lbDrivers);
            tabPage2.Controls.Add(lbUsers);
            tabPage2.Controls.Add(cbUserIsAdmin);
            tabPage2.Controls.Add(dtpUserDob);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(tbUserPassword);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(tbUserEmail);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(tbDriverMobilePhone);
            tabPage2.Controls.Add(tbUserFullName);
            tabPage2.Controls.Add(nudDriverAge);
            tabPage2.Controls.Add(tbDriverFullName);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(719, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Driver | User";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelUser
            // 
            btnDelUser.Location = new Point(577, 360);
            btnDelUser.Name = "btnDelUser";
            btnDelUser.Size = new Size(94, 29);
            btnDelUser.TabIndex = 11;
            btnDelUser.Tag = "del";
            btnDelUser.Text = "Delete";
            btnDelUser.UseVisualStyleBackColor = true;
            btnDelUser.Click += btnUser;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(477, 360);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(94, 29);
            btnEditUser.TabIndex = 12;
            btnEditUser.Tag = "edit";
            btnEditUser.Text = "Edit";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnUser;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(375, 360);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(94, 29);
            btnAddUser.TabIndex = 13;
            btnAddUser.Tag = "add";
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnUser;
            // 
            // btnDelDriver
            // 
            btnDelDriver.Location = new Point(188, 360);
            btnDelDriver.Name = "btnDelDriver";
            btnDelDriver.Size = new Size(62, 29);
            btnDelDriver.TabIndex = 8;
            btnDelDriver.Tag = "del";
            btnDelDriver.Text = "Delete";
            btnDelDriver.UseVisualStyleBackColor = true;
            btnDelDriver.Click += btnDriver;
            // 
            // btnEditDriver
            // 
            btnEditDriver.Location = new Point(102, 360);
            btnEditDriver.Name = "btnEditDriver";
            btnEditDriver.Size = new Size(75, 29);
            btnEditDriver.TabIndex = 9;
            btnEditDriver.Tag = "edit";
            btnEditDriver.Text = "Edit";
            btnEditDriver.UseVisualStyleBackColor = true;
            btnEditDriver.Click += btnDriver;
            // 
            // btnAddDriver
            // 
            btnAddDriver.Location = new Point(25, 360);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(70, 29);
            btnAddDriver.TabIndex = 10;
            btnAddDriver.Tag = "add";
            btnAddDriver.Text = "Add";
            btnAddDriver.UseVisualStyleBackColor = true;
            btnAddDriver.Click += btnDriver;
            // 
            // lbDrivers
            // 
            lbDrivers.FormattingEnabled = true;
            lbDrivers.Location = new Point(8, 82);
            lbDrivers.Name = "lbDrivers";
            lbDrivers.Size = new Size(150, 244);
            lbDrivers.TabIndex = 7;
            lbDrivers.SelectedIndexChanged += lbDrivers_SelectedIndexChanged;
            // 
            // lbUsers
            // 
            lbUsers.FormattingEnabled = true;
            lbUsers.Location = new Point(312, 87);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(196, 244);
            lbUsers.TabIndex = 7;
            lbUsers.SelectedIndexChanged += lbUsers_SelectedIndexChanged;
            // 
            // cbUserIsAdmin
            // 
            cbUserIsAdmin.AutoSize = true;
            cbUserIsAdmin.Location = new Point(564, 320);
            cbUserIsAdmin.Name = "cbUserIsAdmin";
            cbUserIsAdmin.Size = new Size(96, 24);
            cbUserIsAdmin.TabIndex = 6;
            cbUserIsAdmin.Text = "Is Admin?";
            cbUserIsAdmin.UseVisualStyleBackColor = true;
            // 
            // dtpUserDob
            // 
            dtpUserDob.Location = new Point(519, 166);
            dtpUserDob.Name = "dtpUserDob";
            dtpUserDob.Size = new Size(183, 27);
            dtpUserDob.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(451, 17);
            label14.Name = "label14";
            label14.Size = new Size(72, 31);
            label14.TabIndex = 4;
            label14.Text = "Users";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(579, 260);
            label15.Name = "label15";
            label15.Size = new Size(70, 20);
            label15.TabIndex = 3;
            label15.Text = "Password";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(592, 198);
            label13.Name = "label13";
            label13.Size = new Size(46, 20);
            label13.TabIndex = 3;
            label13.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(100, 17);
            label10.Name = "label10";
            label10.Size = new Size(90, 31);
            label10.TabIndex = 4;
            label10.Text = "Drivers";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(571, 143);
            label12.Name = "label12";
            label12.Size = new Size(94, 20);
            label12.TabIndex = 3;
            label12.Text = "Date of Birth";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(178, 205);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 3;
            label9.Text = "Mobile Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(579, 82);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 3;
            label11.Text = "Full Name";
            // 
            // tbUserPassword
            // 
            tbUserPassword.Location = new Point(519, 283);
            tbUserPassword.Name = "tbUserPassword";
            tbUserPassword.Size = new Size(183, 27);
            tbUserPassword.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(208, 141);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 3;
            label8.Text = "Age";
            // 
            // tbUserEmail
            // 
            tbUserEmail.Location = new Point(519, 221);
            tbUserEmail.Name = "tbUserEmail";
            tbUserEmail.Size = new Size(183, 27);
            tbUserEmail.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 82);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 3;
            label7.Text = "Full Name";
            // 
            // tbDriverMobilePhone
            // 
            tbDriverMobilePhone.Location = new Point(164, 228);
            tbDriverMobilePhone.Name = "tbDriverMobilePhone";
            tbDriverMobilePhone.Size = new Size(125, 27);
            tbDriverMobilePhone.TabIndex = 2;
            // 
            // tbUserFullName
            // 
            tbUserFullName.Location = new Point(514, 105);
            tbUserFullName.Name = "tbUserFullName";
            tbUserFullName.Size = new Size(188, 27);
            tbUserFullName.TabIndex = 0;
            // 
            // nudDriverAge
            // 
            nudDriverAge.Location = new Point(164, 164);
            nudDriverAge.Maximum = new decimal(new int[] { 65, 0, 0, 0 });
            nudDriverAge.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            nudDriverAge.Name = "nudDriverAge";
            nudDriverAge.Size = new Size(125, 27);
            nudDriverAge.TabIndex = 1;
            nudDriverAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // tbDriverFullName
            // 
            tbDriverFullName.Location = new Point(164, 103);
            tbDriverFullName.Name = "tbDriverFullName";
            tbDriverFullName.Size = new Size(125, 27);
            tbDriverFullName.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dtpBusStationShiftEnd);
            tabPage3.Controls.Add(dtpBusStationShiftStart);
            tabPage3.Controls.Add(cbBusStationCity);
            tabPage3.Controls.Add(btnDelBusStation);
            tabPage3.Controls.Add(btnEditBusStation);
            tabPage3.Controls.Add(btnAddBusStation);
            tabPage3.Controls.Add(tbBusStationAddress);
            tabPage3.Controls.Add(tbBusStationTitle);
            tabPage3.Controls.Add(lbBusStations);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(label23);
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(btnDelCity);
            tabPage3.Controls.Add(btnEditCity);
            tabPage3.Controls.Add(btnAddCity);
            tabPage3.Controls.Add(tbCityTitle);
            tabPage3.Controls.Add(lbCities);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label17);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(719, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "City | Station";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtpBusStationShiftEnd
            // 
            dtpBusStationShiftEnd.Format = DateTimePickerFormat.Custom;
            dtpBusStationShiftEnd.Location = new Point(541, 314);
            dtpBusStationShiftEnd.Name = "dtpBusStationShiftEnd";
            dtpBusStationShiftEnd.Size = new Size(170, 27);
            dtpBusStationShiftEnd.TabIndex = 22;
            // 
            // dtpBusStationShiftStart
            // 
            dtpBusStationShiftStart.Format = DateTimePickerFormat.Custom;
            dtpBusStationShiftStart.Location = new Point(541, 255);
            dtpBusStationShiftStart.Name = "dtpBusStationShiftStart";
            dtpBusStationShiftStart.Size = new Size(170, 27);
            dtpBusStationShiftStart.TabIndex = 22;
            // 
            // cbBusStationCity
            // 
            cbBusStationCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusStationCity.FormattingEnabled = true;
            cbBusStationCity.Location = new Point(559, 138);
            cbBusStationCity.Name = "cbBusStationCity";
            cbBusStationCity.Size = new Size(139, 28);
            cbBusStationCity.TabIndex = 21;
            // 
            // btnDelBusStation
            // 
            btnDelBusStation.Location = new Point(608, 377);
            btnDelBusStation.Name = "btnDelBusStation";
            btnDelBusStation.Size = new Size(94, 29);
            btnDelBusStation.TabIndex = 18;
            btnDelBusStation.Tag = "del";
            btnDelBusStation.Text = "Delete";
            btnDelBusStation.UseVisualStyleBackColor = true;
            btnDelBusStation.Click += btnBusStation;
            // 
            // btnEditBusStation
            // 
            btnEditBusStation.Location = new Point(508, 377);
            btnEditBusStation.Name = "btnEditBusStation";
            btnEditBusStation.Size = new Size(94, 29);
            btnEditBusStation.TabIndex = 19;
            btnEditBusStation.Tag = "edit";
            btnEditBusStation.Text = "Edit";
            btnEditBusStation.UseVisualStyleBackColor = true;
            btnEditBusStation.Click += btnBusStation;
            // 
            // btnAddBusStation
            // 
            btnAddBusStation.Location = new Point(406, 377);
            btnAddBusStation.Name = "btnAddBusStation";
            btnAddBusStation.Size = new Size(94, 29);
            btnAddBusStation.TabIndex = 20;
            btnAddBusStation.Tag = "add";
            btnAddBusStation.Text = "Add";
            btnAddBusStation.UseVisualStyleBackColor = true;
            btnAddBusStation.Click += btnBusStation;
            // 
            // tbBusStationAddress
            // 
            tbBusStationAddress.Location = new Point(559, 199);
            tbBusStationAddress.Name = "tbBusStationAddress";
            tbBusStationAddress.Size = new Size(139, 27);
            tbBusStationAddress.TabIndex = 17;
            // 
            // tbBusStationTitle
            // 
            tbBusStationTitle.Location = new Point(563, 77);
            tbBusStationTitle.Name = "tbBusStationTitle";
            tbBusStationTitle.Size = new Size(125, 27);
            tbBusStationTitle.TabIndex = 17;
            // 
            // lbBusStations
            // 
            lbBusStations.FormattingEnabled = true;
            lbBusStations.Location = new Point(332, 69);
            lbBusStations.Name = "lbBusStations";
            lbBusStations.Size = new Size(203, 284);
            lbBusStations.TabIndex = 16;
            lbBusStations.SelectedIndexChanged += lbBusStations_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label18.Location = new Point(494, 23);
            label18.Name = "label18";
            label18.Size = new Size(136, 31);
            label18.TabIndex = 14;
            label18.Text = "Bus Station";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(595, 291);
            label23.Name = "label23";
            label23.Size = new Size(64, 20);
            label23.TabIndex = 15;
            label23.Text = "ShiftEnd";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(595, 232);
            label22.Name = "label22";
            label22.Size = new Size(70, 20);
            label22.TabIndex = 15;
            label22.Text = "ShiftStart";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(595, 176);
            label21.Name = "label21";
            label21.Size = new Size(62, 20);
            label21.TabIndex = 15;
            label21.Text = "Address";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(608, 115);
            label20.Name = "label20";
            label20.Size = new Size(34, 20);
            label20.TabIndex = 15;
            label20.Text = "City";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(608, 54);
            label19.Name = "label19";
            label19.Size = new Size(38, 20);
            label19.TabIndex = 15;
            label19.Text = "Title";
            // 
            // btnDelCity
            // 
            btnDelCity.Location = new Point(222, 377);
            btnDelCity.Name = "btnDelCity";
            btnDelCity.Size = new Size(94, 29);
            btnDelCity.TabIndex = 11;
            btnDelCity.Tag = "del";
            btnDelCity.Text = "Delete";
            btnDelCity.UseVisualStyleBackColor = true;
            btnDelCity.Click += btnCity;
            // 
            // btnEditCity
            // 
            btnEditCity.Location = new Point(122, 377);
            btnEditCity.Name = "btnEditCity";
            btnEditCity.Size = new Size(94, 29);
            btnEditCity.TabIndex = 12;
            btnEditCity.Tag = "edit";
            btnEditCity.Text = "Edit";
            btnEditCity.UseVisualStyleBackColor = true;
            btnEditCity.Click += btnCity;
            // 
            // btnAddCity
            // 
            btnAddCity.Location = new Point(20, 377);
            btnAddCity.Name = "btnAddCity";
            btnAddCity.Size = new Size(94, 29);
            btnAddCity.TabIndex = 13;
            btnAddCity.Tag = "add";
            btnAddCity.Text = "Add";
            btnAddCity.UseVisualStyleBackColor = true;
            btnAddCity.Click += btnCity;
            // 
            // tbCityTitle
            // 
            tbCityTitle.Location = new Point(191, 115);
            tbCityTitle.Name = "tbCityTitle";
            tbCityTitle.Size = new Size(125, 27);
            tbCityTitle.TabIndex = 10;
            // 
            // lbCities
            // 
            lbCities.FormattingEnabled = true;
            lbCities.Location = new Point(19, 69);
            lbCities.Name = "lbCities";
            lbCities.Size = new Size(150, 284);
            lbCities.TabIndex = 9;
            lbCities.SelectedIndexChanged += lbCities_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label16.Location = new Point(147, 23);
            label16.Name = "label16";
            label16.Size = new Size(56, 31);
            label16.TabIndex = 7;
            label16.Text = "City";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(236, 79);
            label17.Name = "label17";
            label17.Size = new Size(38, 20);
            label17.TabIndex = 8;
            label17.Text = "Title";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(nudTicketPrice);
            tabPage4.Controls.Add(dtpTicketRouteDate);
            tabPage4.Controls.Add(dtpRouteNodeArrivalTime);
            tabPage4.Controls.Add(cbRouteNodeRoute);
            tabPage4.Controls.Add(cbRouteNodeStation);
            tabPage4.Controls.Add(btnDelRouteNode);
            tabPage4.Controls.Add(btnEditRouteNode);
            tabPage4.Controls.Add(btnAddRouteNode);
            tabPage4.Controls.Add(lbRouteNodes);
            tabPage4.Controls.Add(label25);
            tabPage4.Controls.Add(label30);
            tabPage4.Controls.Add(label32);
            tabPage4.Controls.Add(label31);
            tabPage4.Controls.Add(label34);
            tabPage4.Controls.Add(cbTicketRoute);
            tabPage4.Controls.Add(cbTicketDepartureStation);
            tabPage4.Controls.Add(cbTicketArrivalStation);
            tabPage4.Controls.Add(cbTicketUser);
            tabPage4.Controls.Add(btnDelTicket);
            tabPage4.Controls.Add(btnEditTicket);
            tabPage4.Controls.Add(btnAddTicket);
            tabPage4.Controls.Add(lbTickets);
            tabPage4.Controls.Add(label40);
            tabPage4.Controls.Add(label24);
            tabPage4.Controls.Add(label26);
            tabPage4.Controls.Add(label27);
            tabPage4.Controls.Add(label28);
            tabPage4.Controls.Add(label29);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(719, 417);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Ticket | Route Node";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // nudTicketPrice
            // 
            nudTicketPrice.Location = new Point(244, 117);
            nudTicketPrice.Name = "nudTicketPrice";
            nudTicketPrice.Size = new Size(117, 27);
            nudTicketPrice.TabIndex = 53;
            // 
            // dtpTicketRouteDate
            // 
            dtpTicketRouteDate.Format = DateTimePickerFormat.Custom;
            dtpTicketRouteDate.Location = new Point(235, 288);
            dtpTicketRouteDate.Name = "dtpTicketRouteDate";
            dtpTicketRouteDate.Size = new Size(136, 27);
            dtpTicketRouteDate.TabIndex = 51;
            // 
            // dtpRouteNodeArrivalTime
            // 
            dtpRouteNodeArrivalTime.Format = DateTimePickerFormat.Custom;
            dtpRouteNodeArrivalTime.Location = new Point(557, 223);
            dtpRouteNodeArrivalTime.Name = "dtpRouteNodeArrivalTime";
            dtpRouteNodeArrivalTime.Size = new Size(150, 27);
            dtpRouteNodeArrivalTime.TabIndex = 52;
            // 
            // cbRouteNodeRoute
            // 
            cbRouteNodeRoute.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRouteNodeRoute.FormattingEnabled = true;
            cbRouteNodeRoute.Location = new Point(557, 150);
            cbRouteNodeRoute.Name = "cbRouteNodeRoute";
            cbRouteNodeRoute.Size = new Size(150, 28);
            cbRouteNodeRoute.TabIndex = 50;
            // 
            // cbRouteNodeStation
            // 
            cbRouteNodeStation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRouteNodeStation.FormattingEnabled = true;
            cbRouteNodeStation.Location = new Point(557, 82);
            cbRouteNodeStation.Name = "cbRouteNodeStation";
            cbRouteNodeStation.Size = new Size(150, 28);
            cbRouteNodeStation.TabIndex = 50;
            // 
            // btnDelRouteNode
            // 
            btnDelRouteNode.Location = new Point(613, 371);
            btnDelRouteNode.Name = "btnDelRouteNode";
            btnDelRouteNode.Size = new Size(94, 29);
            btnDelRouteNode.TabIndex = 47;
            btnDelRouteNode.Tag = "del";
            btnDelRouteNode.Text = "Delete";
            btnDelRouteNode.UseVisualStyleBackColor = true;
            btnDelRouteNode.Click += btnRouteNode;
            // 
            // btnEditRouteNode
            // 
            btnEditRouteNode.Location = new Point(513, 371);
            btnEditRouteNode.Name = "btnEditRouteNode";
            btnEditRouteNode.Size = new Size(94, 29);
            btnEditRouteNode.TabIndex = 48;
            btnEditRouteNode.Tag = "edit";
            btnEditRouteNode.Text = "Edit";
            btnEditRouteNode.UseVisualStyleBackColor = true;
            btnEditRouteNode.Click += btnRouteNode;
            // 
            // btnAddRouteNode
            // 
            btnAddRouteNode.Location = new Point(411, 371);
            btnAddRouteNode.Name = "btnAddRouteNode";
            btnAddRouteNode.Size = new Size(94, 29);
            btnAddRouteNode.TabIndex = 49;
            btnAddRouteNode.Tag = "add";
            btnAddRouteNode.Text = "Add";
            btnAddRouteNode.UseVisualStyleBackColor = true;
            btnAddRouteNode.Click += btnRouteNode;
            // 
            // lbRouteNodes
            // 
            lbRouteNodes.FormattingEnabled = true;
            lbRouteNodes.Location = new Point(389, 64);
            lbRouteNodes.Name = "lbRouteNodes";
            lbRouteNodes.Size = new Size(151, 284);
            lbRouteNodes.TabIndex = 44;
            lbRouteNodes.SelectedIndexChanged += lbRouteNodes_SelectedIndexChanged;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(258, 265);
            label25.Name = "label25";
            label25.Size = new Size(84, 20);
            label25.TabIndex = 39;
            label25.Text = "Route Date";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label30.Location = new Point(499, 6);
            label30.Name = "label30";
            label30.Size = new Size(141, 31);
            label30.TabIndex = 38;
            label30.Text = "Route Node";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(591, 200);
            label32.Name = "label32";
            label32.Size = new Size(89, 20);
            label32.TabIndex = 40;
            label32.Text = "Arrival Time";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(605, 127);
            label31.Name = "label31";
            label31.Size = new Size(48, 20);
            label31.TabIndex = 42;
            label31.Text = "Route";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(605, 59);
            label34.Name = "label34";
            label34.Size = new Size(56, 20);
            label34.TabIndex = 42;
            label34.Text = "Station";
            // 
            // cbTicketRoute
            // 
            cbTicketRoute.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTicketRoute.FormattingEnabled = true;
            cbTicketRoute.Location = new Point(235, 337);
            cbTicketRoute.Name = "cbTicketRoute";
            cbTicketRoute.Size = new Size(139, 28);
            cbTicketRoute.TabIndex = 35;
            // 
            // cbTicketDepartureStation
            // 
            cbTicketDepartureStation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTicketDepartureStation.FormattingEnabled = true;
            cbTicketDepartureStation.Location = new Point(232, 229);
            cbTicketDepartureStation.Name = "cbTicketDepartureStation";
            cbTicketDepartureStation.Size = new Size(139, 28);
            cbTicketDepartureStation.TabIndex = 35;
            // 
            // cbTicketArrivalStation
            // 
            cbTicketArrivalStation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTicketArrivalStation.FormattingEnabled = true;
            cbTicketArrivalStation.Location = new Point(232, 175);
            cbTicketArrivalStation.Name = "cbTicketArrivalStation";
            cbTicketArrivalStation.Size = new Size(139, 28);
            cbTicketArrivalStation.TabIndex = 35;
            // 
            // cbTicketUser
            // 
            cbTicketUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTicketUser.FormattingEnabled = true;
            cbTicketUser.Location = new Point(230, 59);
            cbTicketUser.Name = "cbTicketUser";
            cbTicketUser.Size = new Size(139, 28);
            cbTicketUser.TabIndex = 35;
            // 
            // btnDelTicket
            // 
            btnDelTicket.Location = new Point(244, 371);
            btnDelTicket.Name = "btnDelTicket";
            btnDelTicket.Size = new Size(94, 29);
            btnDelTicket.TabIndex = 32;
            btnDelTicket.Tag = "del";
            btnDelTicket.Text = "Delete";
            btnDelTicket.UseVisualStyleBackColor = true;
            btnDelTicket.Click += btnTicket;
            // 
            // btnEditTicket
            // 
            btnEditTicket.Location = new Point(144, 371);
            btnEditTicket.Name = "btnEditTicket";
            btnEditTicket.Size = new Size(94, 29);
            btnEditTicket.TabIndex = 33;
            btnEditTicket.Tag = "edit";
            btnEditTicket.Text = "Edit";
            btnEditTicket.UseVisualStyleBackColor = true;
            btnEditTicket.Click += btnTicket;
            // 
            // btnAddTicket
            // 
            btnAddTicket.Location = new Point(42, 371);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.Size = new Size(94, 29);
            btnAddTicket.TabIndex = 34;
            btnAddTicket.Tag = "add";
            btnAddTicket.Text = "Add";
            btnAddTicket.UseVisualStyleBackColor = true;
            btnAddTicket.Click += btnTicket;
            // 
            // lbTickets
            // 
            lbTickets.FormattingEnabled = true;
            lbTickets.Location = new Point(17, 64);
            lbTickets.Name = "lbTickets";
            lbTickets.Size = new Size(203, 284);
            lbTickets.TabIndex = 29;
            lbTickets.SelectedIndexChanged += lbTickets_SelectedIndexChanged;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(272, 318);
            label40.Name = "label40";
            label40.Size = new Size(48, 20);
            label40.TabIndex = 25;
            label40.Text = "Route";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label24.Location = new Point(179, 18);
            label24.Name = "label24";
            label24.Size = new Size(79, 31);
            label24.TabIndex = 23;
            label24.Text = "Ticket";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(236, 206);
            label26.Name = "label26";
            label26.Size = new Size(127, 20);
            label26.TabIndex = 25;
            label26.Text = "Departure Station";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(258, 150);
            label27.Name = "label27";
            label27.Size = new Size(103, 20);
            label27.TabIndex = 26;
            label27.Text = "Arrival Station";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(279, 90);
            label28.Name = "label28";
            label28.Size = new Size(41, 20);
            label28.TabIndex = 27;
            label28.Text = "Price";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(282, 36);
            label29.Name = "label29";
            label29.Size = new Size(38, 20);
            label29.TabIndex = 28;
            label29.Text = "User";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(nudRouteDayOfWeek);
            tabPage5.Controls.Add(dtpRouteDepartureDate);
            tabPage5.Controls.Add(dtpRouteArrivalTime);
            tabPage5.Controls.Add(label36);
            tabPage5.Controls.Add(label33);
            tabPage5.Controls.Add(cbRouteDriver);
            tabPage5.Controls.Add(cbRouteBus);
            tabPage5.Controls.Add(btnDelRoute);
            tabPage5.Controls.Add(btnEditRoute);
            tabPage5.Controls.Add(btnAddRoute);
            tabPage5.Controls.Add(lbRoutes);
            tabPage5.Controls.Add(label35);
            tabPage5.Controls.Add(label37);
            tabPage5.Controls.Add(label38);
            tabPage5.Controls.Add(label39);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(719, 417);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Route";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // nudRouteDayOfWeek
            // 
            nudRouteDayOfWeek.Location = new Point(410, 199);
            nudRouteDayOfWeek.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            nudRouteDayOfWeek.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRouteDayOfWeek.Name = "nudRouteDayOfWeek";
            nudRouteDayOfWeek.Size = new Size(117, 27);
            nudRouteDayOfWeek.TabIndex = 68;
            nudRouteDayOfWeek.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpRouteDepartureDate
            // 
            dtpRouteDepartureDate.Format = DateTimePickerFormat.Custom;
            dtpRouteDepartureDate.Location = new Point(399, 261);
            dtpRouteDepartureDate.Name = "dtpRouteDepartureDate";
            dtpRouteDepartureDate.Size = new Size(136, 27);
            dtpRouteDepartureDate.TabIndex = 67;
            // 
            // dtpRouteArrivalTime
            // 
            dtpRouteArrivalTime.Format = DateTimePickerFormat.Custom;
            dtpRouteArrivalTime.Location = new Point(399, 311);
            dtpRouteArrivalTime.Name = "dtpRouteArrivalTime";
            dtpRouteArrivalTime.Size = new Size(136, 27);
            dtpRouteArrivalTime.TabIndex = 67;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(422, 238);
            label36.Name = "label36";
            label36.Size = new Size(112, 20);
            label36.TabIndex = 66;
            label36.Text = "Departure Date";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(422, 288);
            label33.Name = "label33";
            label33.Size = new Size(89, 20);
            label33.TabIndex = 66;
            label33.Text = "Arrival Time";
            // 
            // cbRouteDriver
            // 
            cbRouteDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRouteDriver.FormattingEnabled = true;
            cbRouteDriver.Location = new Point(396, 145);
            cbRouteDriver.Name = "cbRouteDriver";
            cbRouteDriver.Size = new Size(139, 28);
            cbRouteDriver.TabIndex = 64;
            // 
            // cbRouteBus
            // 
            cbRouteBus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRouteBus.FormattingEnabled = true;
            cbRouteBus.Location = new Point(396, 81);
            cbRouteBus.Name = "cbRouteBus";
            cbRouteBus.Size = new Size(139, 28);
            cbRouteBus.TabIndex = 65;
            // 
            // btnDelRoute
            // 
            btnDelRoute.Location = new Point(410, 370);
            btnDelRoute.Name = "btnDelRoute";
            btnDelRoute.Size = new Size(94, 29);
            btnDelRoute.TabIndex = 60;
            btnDelRoute.Tag = "del";
            btnDelRoute.Text = "Delete";
            btnDelRoute.UseVisualStyleBackColor = true;
            btnDelRoute.Click += btnRoute;
            // 
            // btnEditRoute
            // 
            btnEditRoute.Location = new Point(310, 370);
            btnEditRoute.Name = "btnEditRoute";
            btnEditRoute.Size = new Size(94, 29);
            btnEditRoute.TabIndex = 61;
            btnEditRoute.Tag = "edit";
            btnEditRoute.Text = "Edit";
            btnEditRoute.UseVisualStyleBackColor = true;
            btnEditRoute.Click += btnRoute;
            // 
            // btnAddRoute
            // 
            btnAddRoute.Location = new Point(208, 370);
            btnAddRoute.Name = "btnAddRoute";
            btnAddRoute.Size = new Size(94, 29);
            btnAddRoute.TabIndex = 62;
            btnAddRoute.Tag = "add";
            btnAddRoute.Text = "Add";
            btnAddRoute.UseVisualStyleBackColor = true;
            btnAddRoute.Click += btnRoute;
            // 
            // lbRoutes
            // 
            lbRoutes.FormattingEnabled = true;
            lbRoutes.Location = new Point(183, 63);
            lbRoutes.Name = "lbRoutes";
            lbRoutes.Size = new Size(203, 284);
            lbRoutes.TabIndex = 59;
            lbRoutes.SelectedIndexChanged += lbRoutes_SelectedIndexChanged;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label35.Location = new Point(345, 17);
            label35.Name = "label35";
            label35.Size = new Size(77, 31);
            label35.TabIndex = 54;
            label35.Text = "Route";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(437, 122);
            label37.Name = "label37";
            label37.Size = new Size(49, 20);
            label37.TabIndex = 56;
            label37.Text = "Driver";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(422, 176);
            label38.Name = "label38";
            label38.Size = new Size(95, 20);
            label38.TabIndex = 57;
            label38.Text = "Day Of Week";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(445, 51);
            label39.Name = "label39";
            label39.Size = new Size(32, 20);
            label39.TabIndex = 58;
            label39.Text = "Bus";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 450);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "AdminForm";
            FormClosing += AdminForm_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBusCapacity).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDriverAge).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTicketPrice).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRouteDayOfWeek).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private ComboBox cbBusModel;
        private NumericUpDown nudBusCapacity;
        private TextBox tbBusPlateNum;
        private Label label2;
        private Label label3;
        private ListBox lbBuses;
        private TextBox tbModelTitle;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button btnDelModel;
        private Button btnEditModel;
        private Button btnDelBus;
        private Button btnAddModel;
        private Button btnEditBus;
        private Button btnAddBus;
        private ListBox lbModels;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox tbDriverMobilePhone;
        private NumericUpDown nudDriverAge;
        private TextBox tbDriverFullName;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox tbUserEmail;
        private TextBox tbUserFullName;
        private DateTimePicker dtpUserDob;
        private CheckBox cbUserIsAdmin;
        private Label label15;
        private TextBox tbUserPassword;
        private ListBox lbDrivers;
        private ListBox lbUsers;
        private Button btnDelUser;
        private Button btnEditUser;
        private Button btnAddUser;
        private Button btnDelDriver;
        private Button btnEditDriver;
        private Button btnAddDriver;
        private Button btnDelBusStation;
        private Button btnEditBusStation;
        private Button btnAddBusStation;
        private TextBox tbBusStationTitle;
        private ListBox lbBusStations;
        private Label label18;
        private Label label19;
        private Button btnDelCity;
        private Button btnEditCity;
        private Button btnAddCity;
        private TextBox tbCityTitle;
        private ListBox lbCities;
        private Label label16;
        private Label label17;
        private ComboBox cbBusStationCity;
        private Label label20;
        private TextBox tbBusStationAddress;
        private Label label21;
        private DateTimePicker dtpBusStationShiftEnd;
        private DateTimePicker dtpBusStationShiftStart;
        private Label label23;
        private Label label22;
        private TabPage tabPage5;
        private TabPage tabPage4;
        private NumericUpDown nudTicketPrice;
        private DateTimePicker dtpTicketRouteDate;
        private DateTimePicker dtpRouteNodeArrivalTime;
        private ComboBox cbRouteNodeRoute;
        private ComboBox cbRouteNodeStation;
        private Button btnDelRouteNode;
        private Button btnEditRouteNode;
        private Button btnAddRouteNode;
        private ListBox lbRouteNodes;
        private Label label25;
        private Label label30;
        private Label label32;
        private Label label31;
        private Label label34;
        private ComboBox cbTicketDepartureStation;
        private ComboBox cbTicketArrivalStation;
        private ComboBox cbTicketUser;
        private Button btnDelTicket;
        private Button btnEditTicket;
        private Button btnAddTicket;
        private ListBox lbTickets;
        private Label label24;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private NumericUpDown nudRouteDayOfWeek;
        private DateTimePicker dtpRouteDepartureDate;
        private DateTimePicker dtpRouteArrivalTime;
        private Label label36;
        private Label label33;
        private ComboBox cbRouteDriver;
        private ComboBox cbRouteBus;
        private Button btnDelRoute;
        private Button btnEditRoute;
        private Button btnAddRoute;
        private ListBox lbRoutes;
        private Label label35;
        private Label label37;
        private Label label38;
        private Label label39;
        private ComboBox cbTicketRoute;
        private Label label40;
    }
}