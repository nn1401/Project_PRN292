
namespace Project_PRN {
    partial class CategoryAndQuantityForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupCateQuantity = new System.Windows.Forms.GroupBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.btnCategoryManager = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupCateQuantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCateQuantity
            // 
            this.groupCateQuantity.BackColor = System.Drawing.Color.Transparent;
            this.groupCateQuantity.Controls.Add(this.labelQuantity);
            this.groupCateQuantity.Controls.Add(this.btnCategoryManager);
            this.groupCateQuantity.Controls.Add(this.cbCategory);
            this.groupCateQuantity.Controls.Add(this.label7);
            this.groupCateQuantity.Controls.Add(this.label3);
            this.groupCateQuantity.ForeColor = System.Drawing.Color.White;
            this.groupCateQuantity.Location = new System.Drawing.Point(107, 73);
            this.groupCateQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.groupCateQuantity.Name = "groupCateQuantity";
            this.groupCateQuantity.Padding = new System.Windows.Forms.Padding(4);
            this.groupCateQuantity.Size = new System.Drawing.Size(587, 304);
            this.groupCateQuantity.TabIndex = 9;
            this.groupCateQuantity.TabStop = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuantity.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.White;
            this.labelQuantity.Location = new System.Drawing.Point(196, 170);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(113, 66);
            this.labelQuantity.TabIndex = 11;
            this.labelQuantity.Text = "100";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCategoryManager
            // 
            this.btnCategoryManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryManager.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryManager.ForeColor = System.Drawing.Color.White;
            this.btnCategoryManager.Location = new System.Drawing.Point(228, 101);
            this.btnCategoryManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategoryManager.Name = "btnCategoryManager";
            this.btnCategoryManager.Size = new System.Drawing.Size(263, 44);
            this.btnCategoryManager.TabIndex = 5;
            this.btnCategoryManager.Text = "Category Manager";
            this.btnCategoryManager.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(196, 55);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(317, 32);
            this.cbCategory.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(21, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 49);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quantity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 49);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategoryAndQuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupCateQuantity);
            this.Name = "CategoryAndQuantityForm";
            this.Text = "CategoryAndQuantityForm";
            this.groupCateQuantity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCateQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button btnCategoryManager;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}