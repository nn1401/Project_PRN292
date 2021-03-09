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

        public void load()
        {
            int i = 0;
            int j = 1;
            foreach (Users u in UserDAO.getAllUser())
            {
                i = dataGridViewAccount.Rows.Add();
                dataGridViewAccount.Rows[i].Cells[0].Value = j;
                dataGridViewAccount.Rows[i].Cells[1].Value = u.UserID;
                dataGridViewAccount.Rows[i].Cells[2].Value = u.Fullname;
                dataGridViewAccount.Rows[i].Cells[3].Value = u.Phone;
                dataGridViewAccount.Rows[i].Cells[4].Value = u.Role.RoleName;
                i++;
                j++;
            }
        }

        private void Admin_AcountForm_Load(object sender, EventArgs e) {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = BackColor;
            GetAllAccountToListView();
            load();
        }

        public void GetAllAccountToListView() {

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



        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dataGridViewAccount.Rows.Clear();
                load();
            }
            else
            {
                dataGridViewAccount.Rows.Clear();
                int i = 0;
                int j = 1;
                foreach (Users u in UserDAO.getAllUserById(txtSearch.Text))
                {
                    i = dataGridViewAccount.Rows.Add();
                    dataGridViewAccount.Rows[i].Cells[0].Value = j;
                    dataGridViewAccount.Rows[i].Cells[1].Value = u.UserID;
                    dataGridViewAccount.Rows[i].Cells[2].Value = u.Fullname;
                    dataGridViewAccount.Rows[i].Cells[3].Value = u.Phone;
                    dataGridViewAccount.Rows[i].Cells[4].Value = u.Role.RoleName;
                    i++;
                    j++;
                }
            }

            

        }
    }
}
