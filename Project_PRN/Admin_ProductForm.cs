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
    public partial class Admin_ProductForm : Form {
        public Admin_ProductForm() {
            InitializeComponent();
        }

        private void Admin_ProductForm_Load(object sender, EventArgs e) {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = BackColor;

            Console.WriteLine("Okkkkk");

            ClearGroup();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        public void ClearGroup() {
            groupCategoryManager.Hide();
            groupColorManager.Hide();
            groupSizeManager.Hide();
            groupQuantity.Hide();
        }

        private void labelQuantity_Click(object sender, EventArgs e) {
            ClearGroup();
            groupQuantity.Show();
        }

        private void btnCategoryManager_Click(object sender, EventArgs e) {
            ClearGroup();
            groupCategoryManager.Show();
        }

        private void btnColorManager_Click(object sender, EventArgs e) {
            ClearGroup();
            groupColorManager.Show();
        }

        private void btnSizeManager_Click(object sender, EventArgs e) {
            ClearGroup();
            groupSizeManager.Show();
        }

        private void dataGridViewQuantity_CellClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnExitColorManager_Click(object sender, EventArgs e) {
            ClearGroup();
            groupQuantity.Show();
        }

        private void btnExitSizeName_Click(object sender, EventArgs e) {
            ClearGroup();
            groupQuantity.Show();
        }

        private void btnExitCategoryManager_Click(object sender, EventArgs e) {
            ClearGroup();
        }

        private void label13_Click(object sender, EventArgs e) {

        }
    }
}
