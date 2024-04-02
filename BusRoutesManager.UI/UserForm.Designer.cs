namespace BusRoutesManager.UI
{
    partial class UserForm
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
            label1 = new Label();
            comboBoxFromCity = new ComboBox();
            comboBoxToCity = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnFindRoutes = new Button();
            panelRoutes = new Panel();
            label4 = new Label();
            dateTimePicker = new DateTimePicker();
            comboBoxFromStation = new ComboBox();
            comboBoxToStation = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 28);
            label1.TabIndex = 0;
            label1.Text = "Select route properties";
            // 
            // comboBoxFromCity
            // 
            comboBoxFromCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFromCity.FormattingEnabled = true;
            comboBoxFromCity.Location = new Point(123, 54);
            comboBoxFromCity.Name = "comboBoxFromCity";
            comboBoxFromCity.Size = new Size(151, 28);
            comboBoxFromCity.TabIndex = 1;
            comboBoxFromCity.SelectedIndexChanged += comboBoxFromCity_SelectedIndexChanged;
            // 
            // comboBoxToCity
            // 
            comboBoxToCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxToCity.FormattingEnabled = true;
            comboBoxToCity.Location = new Point(123, 95);
            comboBoxToCity.Name = "comboBoxToCity";
            comboBoxToCity.Size = new Size(151, 28);
            comboBoxToCity.TabIndex = 1;
            comboBoxToCity.SelectedIndexChanged += comboBoxToCity_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 0;
            label2.Text = "From city:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(26, 95);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 0;
            label3.Text = "To city:";
            // 
            // btnFindRoutes
            // 
            btnFindRoutes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnFindRoutes.Location = new Point(593, 50);
            btnFindRoutes.Name = "btnFindRoutes";
            btnFindRoutes.Size = new Size(100, 73);
            btnFindRoutes.TabIndex = 2;
            btnFindRoutes.Text = "Find routes";
            btnFindRoutes.UseVisualStyleBackColor = true;
            btnFindRoutes.Click += btnFindRoutes_Click;
            // 
            // panelRoutes
            // 
            panelRoutes.AutoScroll = true;
            panelRoutes.Dock = DockStyle.Bottom;
            panelRoutes.Location = new Point(0, 180);
            panelRoutes.Name = "panelRoutes";
            panelRoutes.Size = new Size(721, 345);
            panelRoutes.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(247, 135);
            label4.Name = "label4";
            label4.Size = new Size(62, 28);
            label4.TabIndex = 0;
            label4.Text = "Date:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(315, 137);
            dateTimePicker.MinDate = new DateTime(2024, 4, 1, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(150, 27);
            dateTimePicker.TabIndex = 4;
            dateTimePicker.Value = new DateTime(2024, 4, 1, 21, 39, 3, 0);
            // 
            // comboBoxFromStation
            // 
            comboBoxFromStation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFromStation.FormattingEnabled = true;
            comboBoxFromStation.Location = new Point(424, 54);
            comboBoxFromStation.Name = "comboBoxFromStation";
            comboBoxFromStation.Size = new Size(151, 28);
            comboBoxFromStation.TabIndex = 1;
            // 
            // comboBoxToStation
            // 
            comboBoxToStation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxToStation.FormattingEnabled = true;
            comboBoxToStation.Location = new Point(424, 95);
            comboBoxToStation.Name = "comboBoxToStation";
            comboBoxToStation.Size = new Size(151, 28);
            comboBoxToStation.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(288, 54);
            label5.Name = "label5";
            label5.Size = new Size(137, 28);
            label5.TabIndex = 0;
            label5.Text = "From station:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(307, 91);
            label6.Name = "label6";
            label6.Size = new Size(111, 28);
            label6.TabIndex = 0;
            label6.Text = "To station:";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 525);
            Controls.Add(dateTimePicker);
            Controls.Add(panelRoutes);
            Controls.Add(btnFindRoutes);
            Controls.Add(comboBoxToStation);
            Controls.Add(comboBoxToCity);
            Controls.Add(comboBoxFromStation);
            Controls.Add(comboBoxFromCity);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserForm";
            Text = "UserForm";
            FormClosing += UserForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxFromCity;
        private ComboBox comboBoxToCity;
        private Label label2;
        private Label label3;
        private Button btnFindRoutes;
        private Panel panelRoutes;
        private Label label4;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxFromStation;
        private ComboBox comboBoxToStation;
        private Label label5;
        private Label label6;
    }
}