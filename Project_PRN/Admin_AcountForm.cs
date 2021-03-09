using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRN {
    public partial class Admin_AcountForm : Form {
        public Admin_AcountForm() {
            InitializeComponent();
        }

        private void Admin_AcountForm_Load(object sender, EventArgs e) {
            DesignForm();
        }

        public void DesignForm() {

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = BackColor;

            dataGridViewAccount.BorderStyle = BorderStyle.None;
            dataGridViewAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewAccount.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewAccount.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewAccount.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridViewAccount.EnableHeadersVisualStyles = false;
            dataGridViewAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewAccount.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewAccount.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
