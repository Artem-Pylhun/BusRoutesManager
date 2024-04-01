namespace BusRoutesManager.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            tBoxUserEmail = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            tBoxUserPass = new TextBox();
            tabPage2 = new TabPage();
            dateTimePickerRegisterDOB = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRegister = new Button();
            tBoxRegisterPass = new TextBox();
            tBoxRegisterFName = new TextBox();
            tBoxRegisterEmail = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(6, 234);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(312, 45);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tBoxUserEmail
            // 
            tBoxUserEmail.Location = new Point(6, 53);
            tBoxUserEmail.Name = "tBoxUserEmail";
            tBoxUserEmail.Size = new Size(312, 27);
            tBoxUserEmail.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(334, 324);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnLogin);
            tabPage1.Controls.Add(tBoxUserPass);
            tabPage1.Controls.Add(tBoxUserEmail);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(326, 291);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(111, 126);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(132, 12);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // tBoxUserPass
            // 
            tBoxUserPass.BackColor = Color.White;
            tBoxUserPass.Location = new Point(8, 168);
            tBoxUserPass.Name = "tBoxUserPass";
            tBoxUserPass.Size = new Size(312, 27);
            tBoxUserPass.TabIndex = 2;
            tBoxUserPass.UseSystemPasswordChar = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dateTimePickerRegisterDOB);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(btnRegister);
            tabPage2.Controls.Add(tBoxRegisterPass);
            tabPage2.Controls.Add(tBoxRegisterEmail);
            tabPage2.Controls.Add(tBoxRegisterFName);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(326, 291);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Register";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerRegisterDOB
            // 
            dateTimePickerRegisterDOB.Location = new Point(7, 83);
            dateTimePickerRegisterDOB.MaxDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePickerRegisterDOB.Name = "dateTimePickerRegisterDOB";
            dateTimePickerRegisterDOB.Size = new Size(312, 27);
            dateTimePickerRegisterDOB.TabIndex = 12;
            dateTimePickerRegisterDOB.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(110, 162);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 11;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(98, 56);
            label5.Name = "label5";
            label5.Size = new Size(127, 28);
            label5.TabIndex = 6;
            label5.Text = "Date of birth:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(111, 1);
            label6.Name = "label6";
            label6.Size = new Size(100, 28);
            label6.TabIndex = 7;
            label6.Text = "Full name:";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnRegister.Location = new Point(7, 237);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(312, 45);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tBoxRegisterPass
            // 
            tBoxRegisterPass.BackColor = Color.White;
            tBoxRegisterPass.Location = new Point(7, 195);
            tBoxRegisterPass.Name = "tBoxRegisterPass";
            tBoxRegisterPass.Size = new Size(312, 27);
            tBoxRegisterPass.TabIndex = 9;
            tBoxRegisterPass.UseSystemPasswordChar = true;
            // 
            // tBoxRegisterFName
            // 
            tBoxRegisterFName.Location = new Point(6, 29);
            tBoxRegisterFName.Name = "tBoxRegisterFName";
            tBoxRegisterFName.Size = new Size(312, 27);
            tBoxRegisterFName.TabIndex = 10;
            // 
            // tBoxRegisterEmail
            // 
            tBoxRegisterEmail.Location = new Point(8, 135);
            tBoxRegisterEmail.Name = "tBoxRegisterEmail";
            tBoxRegisterEmail.Size = new Size(312, 27);
            tBoxRegisterEmail.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(124, 107);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 324);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Login/Register";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLogin;
        private TextBox tBoxUserEmail;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label1;
        private TextBox tBoxUserPass;
        private DateTimePicker dateTimePickerRegisterDOB;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRegister;
        private TextBox tBoxRegisterPass;
        private TextBox tBoxRegisterFName;
        private Label label3;
        private TextBox tBoxRegisterEmail;
    }
}
