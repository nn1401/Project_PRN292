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
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_PRN {
    public partial class Admin_HomeForm : Form {
        public Admin_HomeForm() {
            InitializeComponent();
        }

        private void Admin_HomeForm_Load(object sender, EventArgs e) {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = BackColor;

            ClearChart();
        }

        private void panelProduct_Paint(object sender, PaintEventArgs e) {

        }

        private void panelProduct_MouseClick(object sender, MouseEventArgs e) {

        }

        public void ClearChart() {
            chartProduct.Hide();
            chartAccount.Hide();
            chartBill.Hide();
        }

        private void chartProduct_Click(object sender, EventArgs e) {
            ClearChart();
            chartAccount.Show();
        }

        private void panelAccount_MouseClick(object sender, MouseEventArgs e) {
            ClearChart();
            chartAccount.Show();

/*            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=MiniMart;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select [Role name] = role_name, [Number of account] = COUNT(username) from [User],[Role] where [User].role_id = [Role].role_id group by role_name", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);


            chartAccount.DataSource = ds;
            chartAccount.Series["Account"].XValueMember = "Role name";
            chartAccount.Series["Account"].YValueMembers = "Number of account";
            chartAccount.Series[0].ChartType = SeriesChartType.Pie;
            conn.Close();*/
        }

        private void labelProduct_MouseClick(object sender, MouseEventArgs e) {
            ClearChart();
            chartProduct.Show();
        }

        private void chartBill_MouseClick(object sender, MouseEventArgs e) {
            ClearChart();
            chartBill.Show();
        }
    }
}
