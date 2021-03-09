using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRN {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            RegisterForm registerForm = new RegisterForm(this);
            this.Hide();
            registerForm.Show();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

       


        private void btnLogin_Click(object sender, EventArgs e) {
            Users user = new Users();
            try
            {
                user = UserDAO.getUserByIdAndPassword(txtUsername.Text, txtPassword.Text);
               
                if(txtUsername.Text == "")
                {
                    MessageBox.Show("please enter your uesrname!!!");
                }
                else if(txtUsername.Text != "" && txtPassword.Text == "")
                {
                    MessageBox.Show("please enter your pasword!!!");
                }
                else
                {
                    if (user.Role == null)
                    {
                        MessageBox.Show("username or password incorrect!!!");
                    }
                    else if (user.Role.RoleId == 1)
                    {
                        MainForm mainForm = new MainForm(this);
                        this.Hide();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("login with user role");
                    }
                }
                
            }                           
            catch (Exception)
            {
            }
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
