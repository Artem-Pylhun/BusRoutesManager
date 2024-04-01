using BusRoutesManager.Domain.Context;
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
        public UserForm(Form1 form, BusManagerContext ctx, int userId)
        {
            InitializeComponent();
            baseform = form;
            _ctx = ctx;
            this.userId = userId;
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            baseform.Enabled = true;
            baseform.Show();
        }
    }
}
