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
    public partial class RegisterForm : Form {
        Form form;
        public RegisterForm(Form form) {
            this.form = form;
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtFullname_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void pictureBox5_Click(object sender, EventArgs e) {
            this.Close();
            form.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            List<Users> list = new List<Users>();
            list = UserDAO.getAllUser();


            Users user = new Users();
            try
            {
                if(txtUsername.Text == "" || txtPassword.Text == "" || txtFullname.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" || txt.Text == "")
                {
                    MessageBox.Show("All fields cannot be empty");
                }
                else
                {

                    if (txtUsername.Text.Length < 5)
                    {
                        MessageBox.Show("Please enter an username greater than 5 characters!!!");
                    }                    
                    else if (txtPhone.Text.Length > 15 || txtPhone.Text.Length < 9)
                    {
                        MessageBox.Show("Please enter a phone number valid!!!");
                    }
                    else if (txtPassword.Text.Length < 5)
                    {
                        MessageBox.Show("Please enter an password greater than 5 characters!!!");
                    }
                    else if (txtPassword.Text != txt.Text)
                    {
                        MessageBox.Show("Those passwords didn’t match. Try again.");
                    }
                    else
                    {
                        bool flag = false;
                        foreach (Users us in list)
                        {
                            if(txtUsername.Text == us.UserID)
                            {
                                MessageBox.Show("Account already exists!!!");
                                flag = true;
                            }
                        }
                        if(flag == false)
                        {
                            user = new Users(txtUsername.Text, txtPassword.Text, txtFullname.Text, txtAddress.Text, txtPhone.Text, new Roles(2));
                            UserDAO.register(user);
                            MessageBox.Show("Sign Up Success!!!");
                        }
                    }
                }  
            }
            catch (Exception)
            {
            }
        }
    }
}
