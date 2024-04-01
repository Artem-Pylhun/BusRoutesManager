using BusRoutesManager.Domain.Context;
using BusRoutesManager.Domain.Entities;
using BusRoutesManager.Repositories;

namespace BusRoutesManager.UI
{
    public partial class Form1 : Form
    {
        private readonly BusManagerContext _ctx = new BusManagerContext();
        private readonly Repository<User> _userRepository;
        public Form1()
        {
            _userRepository = new Repository<User>(_ctx);
            InitializeComponent();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxRegisterFName.Text) || string.IsNullOrEmpty(tBoxRegisterPass.Text) || string.IsNullOrEmpty(tBoxRegisterEmail.Text))
            {
                MessageBox.Show("Enter all fields!");
                return;
            }
            User currentUser = new User()
            {
                FullName = tBoxRegisterFName.Text,
                Password = tBoxRegisterPass.Text,
                Email = tBoxRegisterEmail.Text,
                DateOfBirth = dateTimePickerRegisterDOB.Value,
                IsAdmin = false
            };
            if (_userRepository.GetAll().FirstOrDefault(u => u.Email == currentUser.Email) != null)
            {
                MessageBox.Show("User already registered!");
                return;
            }
            _userRepository.Insert(currentUser);
            _userRepository.SaveChanges();
            MessageBox.Show("User Registered!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxUserEmail.Text) || string.IsNullOrEmpty(tBoxUserPass.Text))
            {
                MessageBox.Show("Enter all fields!");
                return;
            }
            User currentUser = _userRepository.GetAll().FirstOrDefault(u => u.Email == tBoxUserEmail.Text && u.Password == tBoxUserPass.Text);
            if (currentUser == null)
            {
                MessageBox.Show("Wrong fields!");
                return;
            }

            if (currentUser.IsAdmin)
            {
                //Create admin form
                /*
                FormAdmin child = new FormAdmin(this, _ctx);
                child.Show();
                this.Enabled = false;
                this.Hide();
                */
            }
            else
            {
                //Create user form
                /*
                FormUser child = new FormUser(this, _ctx, currentUser.Id);
                child.Show();
                this.Enabled = false;
                this.Hide();
                */
            }

        }
    }
}
