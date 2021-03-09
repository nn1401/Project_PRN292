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
    public partial class ProfileForm : Form {
        public ProfileForm() {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e) {
            DesignForm();
        }
        public void DesignForm() {

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = BackColor;
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void labelPhoneNumber_Click(object sender, EventArgs e) {

        }

        private void labelFullname_Click(object sender, EventArgs e) {

        }

        private void labelUsername_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void label9_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label6_Click_1(object sender, EventArgs e) {

        }
    }
}
