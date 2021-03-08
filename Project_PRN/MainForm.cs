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
        public MainForm(Form form) {
            this.form = form;
            InitializeComponent();
        }
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        public void ClearButtton() {
            panelWork.Controls.Clear();

            btnHome.BackColor = Color.Transparent;
            btnBill.BackColor = Color.Transparent;
            btnAccount.BackColor = Color.Transparent;
            btnLogOut.BackColor = Color.Transparent;
            btnProduct.BackColor = Color.Transparent;
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
            btnBill.BackColor = Color.LightSalmon;
        }
    }
}
