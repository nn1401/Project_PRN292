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
        int option; //Biến option xác định: 1 là add sản phẩm, 2 là update sản phẩm, 3 là delete sản phẩm
        public Admin_ProductForm() {
            InitializeComponent();
        }

        private void Admin_ProductForm_Load(object sender, EventArgs e) {
            DesignForm();
            ClearAllItemsInGroupMain();
            CategoryAndQuantity();
            HideBtnOkAndCancel();
        }

        public void DesignForm() {

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = BackColor;

            //
            dataGridViewProduct.BorderStyle = BorderStyle.None;
            dataGridViewProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewProduct.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewProduct.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridViewProduct.EnableHeadersVisualStyles = false;
            dataGridViewProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //

            //
            dataGridViewQuantity.BorderStyle = BorderStyle.None;
            dataGridViewQuantity.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewQuantity.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewQuantity.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewQuantity.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridViewQuantity.EnableHeadersVisualStyles = false;
            dataGridViewQuantity.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewQuantity.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewQuantity.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //

            //
            dataGridViewCate.BorderStyle = BorderStyle.None;
            dataGridViewCate.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCate.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCate.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewCate.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridViewCate.EnableHeadersVisualStyles = false;
            dataGridViewCate.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCate.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewCate.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //

            //
            dataGridViewColor.BorderStyle = BorderStyle.None;
            dataGridViewColor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewColor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewColor.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewColor.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridViewColor.EnableHeadersVisualStyles = false;
            dataGridViewColor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewColor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewColor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //

            //
            dataGridViewSize.BorderStyle = BorderStyle.None;
            dataGridViewSize.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewSize.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewSize.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewSize.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridViewSize.EnableHeadersVisualStyles = false;
            dataGridViewSize.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewSize.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewSize.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //
        }


        private void btnColorManager_Click(object sender, EventArgs e) {
            ClearAllItemsInGroupMain();
            ColorManager();
        }

        private void btnSizeManager_Click(object sender, EventArgs e) {
            ClearAllItemsInGroupMain();
            SizeManager();
        }

        private void btnExitColorManager_Click(object sender, EventArgs e) {
            ClearAllItemsInGroupMain();
            QuantityDetails();
        }

        private void btnExitSizeName_Click(object sender, EventArgs e) {
            ClearAllItemsInGroupMain();
            QuantityDetails();
        }

        private void btnExitCategoryManager_Click(object sender, EventArgs e) {
            ClearAllItemsInGroupMain();
            CategoryAndQuantity();
        }

        private void btnCategoryManager_Click(object sender, EventArgs e) {
            ClearAllItemsInGroupMain();
            CategoryManager();
        }
        private void labelTotalQuantity_Click(object sender, EventArgs e) {
            ClearAllItemsInGroupMain();
            QuantityDetails();
        }

        private void btnExitQuantityDetails_Click(object sender, EventArgs e) {
            ClearAllItemsInGroupMain();
            CategoryAndQuantity();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            HideOptions();
            ShowBtnOkAndCancel();
            option = 1; //Chọn add sản phẩm
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            HideOptions();
            ShowBtnOkAndCancel();
            option = 2; //Chọn update sản phẩm
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            HideOptions();
            ShowBtnOkAndCancel();
            option = 3; //Chọn delete sản phẩm
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            ShowOptions();
            HideBtnOkAndCancel();
            option = 0; //Reset lại option
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if(option != 0)
            {
                switch (option)
                {
                    case 1:
                        //Add sản phẩm
                        break;
                    case 2:
                        //Update sản phẩm
                        break;
                    case 3:
                        //Delete sản phẩm
                        break;
                }
            }
            HideBtnOkAndCancel();
            ShowOptions();
        }
        public void CategoryAndQuantity() {
            labelCategory.Show();
            labelQuantity.Show();
            cbCategory.Show();
            btnCategoryManager.Show();
            labelTotalQuantity.Show();
        }
        public void CategoryManager() {
            //CategoryManager:
            dataGridViewCate.Show();
            labelCategoryName.Show();
            txtCategoryName.Show();
            btnAddCategory.Show();
            btnUpdateCategory.Show();
            btnExitCategoryManager.Show();
        }
        public void QuantityDetails() {
            //Quantity details
            dataGridViewQuantity.Show();
            labelSize.Show();
            labelColor.Show();
            labelEachQuantity.Show();
            cbSize.Show();
            cbColor.Show();
            txtQuantity.Show();
            btnColorManager.Show();
            btnSizeManager.Show();
            btnAddQuantity.Show();
            btnExitQuantityDetails.Show();
        }
        public void SizeManager() {
            //SizeManager
            dataGridViewSize.Show();
            labelSizeName.Show();
            btnAddSize.Show();
            btnExitSizeManager.Show();
            txtSizeName.Show();
        }
        public void ColorManager() {
            //ColorManager
            dataGridViewColor.Show();
            labelColorName.Show();
            btnAddColor.Show();
            btnExitColorManager.Show();
            txtColorName.Show();
        }
        public void ClearAllItemsInGroupMain() {
            //GroupMain
            labelCategory.Hide();
            labelQuantity.Hide();
            cbCategory.Hide();
            btnCategoryManager.Hide();
            labelTotalQuantity.Hide();

            //CategoryManager:
            dataGridViewCate.Hide();
            labelCategoryName.Hide();
            txtCategoryName.Hide();
            btnAddCategory.Hide();
            btnUpdateCategory.Hide();
            btnExitCategoryManager.Hide();

            //Quantity details
            dataGridViewQuantity.Hide();
            labelSize.Hide();
            labelColor.Hide();
            labelEachQuantity.Hide();
            cbSize.Hide();
            cbColor.Hide();
            txtQuantity.Hide();
            btnColorManager.Hide();
            btnSizeManager.Hide();
            btnAddQuantity.Hide();
            btnExitQuantityDetails.Hide();
            //SizeManager
            dataGridViewSize.Hide();
            labelSizeName.Hide();
            btnAddSize.Hide();
            btnExitSizeManager.Hide();
            txtSizeName.Hide();

            //ColorManager
            dataGridViewColor.Hide();
            labelColorName.Hide();
            btnAddColor.Hide();
            btnExitColorManager.Hide();
            txtColorName.Hide();
        }
        public void HideBtnOkAndCancel() {
            btnOK.Hide();
            btnCancel.Hide();
        }
        public void ShowBtnOkAndCancel() {
            btnOK.Show();
            btnCancel.Show();
        }
        public void ShowOptions() {
            btnAdd.Show();
            btnUpdate.Show();
            btnDelete.Show();
        }
        public void HideOptions() {
            btnAdd.Hide();
            btnUpdate.Hide();
            btnDelete.Hide();
        }
    }
}
