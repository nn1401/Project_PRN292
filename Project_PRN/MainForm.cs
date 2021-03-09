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
    public partial class MainForm : Form {
        Form form;
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            GetOptionByRole(labelRole.Text);
        }
        public void GetOptionByRole(string role) {
            switch (role)
            {
                case "Admin":
                    //Ẩn Shopping và My order
                    pictureShopping.Hide();
                    pictureMyOrder.Hide();
                    btnShopping.Hide();
                    btnMyOrder.Hide();
                    //
                    break;
                case "User":
                    //Ẩn Home, Product, Account và Order
                    pictureHome.Hide();
                    pictureOrder.Hide();
                    pictureAccount.Hide();
                    pictureProduct.Hide();
                    btnHome.Hide();
                    btnProduct.Hide();
                    btnAccount.Hide();
                    btnOrder.Hide();
                    //
                    break;
            }
        }
        public void ClearButtton() {
            panelWork.Controls.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            labelDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            labelTime.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            ClearButtton();
            btnLogOut.BackColor = Color.LightSalmon;

            form.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e) {
            ClearButtton();
            btnHome.BackColor = Color.LightSalmon;

            Admin_HomeForm admin_HomeForm = new Admin_HomeForm();
            admin_HomeForm.TopLevel = false;
            panelWork.Controls.Add(admin_HomeForm);
            admin_HomeForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            admin_HomeForm.Dock = DockStyle.Fill;
            admin_HomeForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e) {
            ClearButtton();
            btnAccount.BackColor = Color.LightSalmon;

            Admin_AcountForm admin_AcountForm = new Admin_AcountForm();
            admin_AcountForm.TopLevel = false;
            panelWork.Controls.Add(admin_AcountForm);
            admin_AcountForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            admin_AcountForm.Dock = DockStyle.Fill;
            admin_AcountForm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e) {
            ClearButtton();
            btnProduct.BackColor = Color.LightSalmon;

            Admin_ProductForm admin_ProductForm = new Admin_ProductForm();
            admin_ProductForm.TopLevel = false;
            panelWork.Controls.Add(admin_ProductForm);
            admin_ProductForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            admin_ProductForm.Dock = DockStyle.Fill;
            admin_ProductForm.Show();
        }

        private void btnBill_Click(object sender, EventArgs e) {
            ClearButtton();
            btnOrder.BackColor = Color.LightSalmon;

            Admin_OrderForm admin_OrderForm = new Admin_OrderForm();
            admin_OrderForm.TopLevel = false;
            panelWork.Controls.Add(admin_OrderForm);
            admin_OrderForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            admin_OrderForm.Dock = DockStyle.Fill;
            admin_OrderForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e) {
            ClearButtton();
            btnOrder.BackColor = Color.LightSalmon;

            ProfileForm profileForm = new ProfileForm();
            profileForm.TopLevel = false;
            panelWork.Controls.Add(profileForm);
            profileForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            profileForm.Dock = DockStyle.Fill;
            profileForm.Show();
        }

        private void btnMyOrder_Click(object sender, EventArgs e) {
            ClearButtton();
            btnOrder.BackColor = Color.LightSalmon;

            User_MyOrderForm user_MyOrderForm = new User_MyOrderForm();
            user_MyOrderForm.TopLevel = false;
            panelWork.Controls.Add(user_MyOrderForm);
            user_MyOrderForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            user_MyOrderForm.Dock = DockStyle.Fill;
            user_MyOrderForm.Show();
        }
    }
}
