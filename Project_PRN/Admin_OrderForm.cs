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
    public partial class Admin_OrderForm : Form {
        public Admin_OrderForm() {
            InitializeComponent();
        }

        private void Admin_OrderForm_Load(object sender, EventArgs e) {
            DesignForm();
        }
        public void DesignForm() {

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = BackColor;

            //
            dataGridViewOrder.BorderStyle = BorderStyle.None;
            dataGridViewOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewOrder.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewOrder.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridViewOrder.EnableHeadersVisualStyles = false;
            dataGridViewOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //

            dataGridViewProductOrder.BorderStyle = BorderStyle.None;
            dataGridViewProductOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewProductOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewProductOrder.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewProductOrder.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridViewProductOrder.EnableHeadersVisualStyles = false;
            dataGridViewProductOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewProductOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewProductOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //
        }
    }
}
