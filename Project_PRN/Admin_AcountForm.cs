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
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = BackColor;
            GetAllAccountToListView();
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

            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=MiniMart;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select username,fullname,[password],[User].role_id,role_name from [User],[Role] where [User].role_id = [Role].role_id", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                i = dataGridViewAccount.Rows.Add();
                dataGridViewAccount.Rows[i].Cells[0].Value = i;
                dataGridViewAccount.Rows[i].Cells[1].Value = row["username"].ToString();
                dataGridViewAccount.Rows[i].Cells[2].Value = row["fullname"].ToString();
                dataGridViewAccount.Rows[i].Cells[4].Value = row["role_name"].ToString();
                i++;
            }
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
