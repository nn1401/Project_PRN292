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
    public partial class User_MyOrderForm : Form {
        public User_MyOrderForm() {
            InitializeComponent();
        }

        private void User_MyOrderForm_Load(object sender, EventArgs e) {
            DesignForm();
        }
        public void DesignForm() {

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = BackColor;

            //
            dataGridViewMyOrder.BorderStyle = BorderStyle.None;
            dataGridViewMyOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewMyOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewMyOrder.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewMyOrder.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridViewMyOrder.EnableHeadersVisualStyles = false;
            dataGridViewMyOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMyOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewMyOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //
            dataGridViewProductMyOrder.BorderStyle = BorderStyle.None;
            dataGridViewProductMyOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewProductMyOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewProductMyOrder.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewProductMyOrder.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridViewProductMyOrder.EnableHeadersVisualStyles = false;
            dataGridViewProductMyOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewProductMyOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewProductMyOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //

        }
    }
}
