
namespace Project_PRN {
    partial class MainForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelWork = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.pictureMyOrder = new System.Windows.Forms.PictureBox();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.btnMyOrder = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pictureShopping = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnShopping = new System.Windows.Forms.Button();
            this.pictureOrder = new System.Windows.Forms.PictureBox();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.pictureAccount = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();

            this.panel1 = new System.Windows.Forms.Panel();
            this.panelWork = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            this.panel1.SuspendLayout();

            this.panel3.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMyOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project_PRN.Properties.Resources.original1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelWork);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1645, 833);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelWork
            // 
            this.panelWork.BackColor = System.Drawing.Color.Transparent;
            this.panelWork.Location = new System.Drawing.Point(346, 11);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(1288, 786);
            this.panelWork.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Project_PRN.Properties.Resources.aaaaa;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.labelRole);
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Controls.Add(this.labelDate);
            this.panel3.Controls.Add(this.panelButton);

            this.panel3.Location = new System.Drawing.Point(36, 166);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 645);

            this.panel3.Location = new System.Drawing.Point(21, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 829);

            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // labelRole
            // 
            this.labelRole.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(-1, 42);
            this.labelRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(212, 27);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "User";
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(2, 10);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(212, 45);
            this.labelName.TabIndex = 7;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Yellow;

            this.labelTime.Location = new System.Drawing.Point(16, 447);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);

            this.labelTime.Location = new System.Drawing.Point(22, 575);

            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(190, 31);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Yellow;

            this.labelDate.Location = new System.Drawing.Point(16, 416);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);

            this.labelDate.Location = new System.Drawing.Point(22, 537);

            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(190, 31);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButton
            // 
            this.panelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Indicator;
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelButton.Controls.Add(this.pictureMyOrder);
            this.panelButton.Controls.Add(this.pictureProfile);
            this.panelButton.Controls.Add(this.btnMyOrder);
            this.panelButton.Controls.Add(this.btnProfile);
            this.panelButton.Controls.Add(this.pictureShopping);
            this.panelButton.Controls.Add(this.pictureBox5);
            this.panelButton.Controls.Add(this.btnShopping);
            this.panelButton.Controls.Add(this.pictureOrder);
            this.panelButton.Controls.Add(this.pictureProduct);
            this.panelButton.Controls.Add(this.pictureAccount);
            this.panelButton.Controls.Add(this.btnLogOut);
            this.panelButton.Controls.Add(this.pictureHome);
            this.panelButton.Controls.Add(this.btnOrder);
            this.panelButton.Controls.Add(this.btnProduct);
            this.panelButton.Controls.Add(this.btnAccount);
            this.panelButton.Controls.Add(this.btnHome);
            this.panelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelButton.Location = new System.Drawing.Point(20, 115);
            this.panelButton.Margin = new System.Windows.Forms.Padding(2);
            this.panelButton.Name = "panelButton";

            this.panelButton.Size = new System.Drawing.Size(175, 266);

            this.panelButton.Size = new System.Drawing.Size(233, 393);

            this.panelButton.TabIndex = 2;
            // 
            // pictureMyOrder
            // 
            this.pictureMyOrder.BackgroundImage = global::Project_PRN.Properties.Resources.shopping;
            this.pictureMyOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureMyOrder.Location = new System.Drawing.Point(0, 65);
            this.pictureMyOrder.Name = "pictureMyOrder";
            this.pictureMyOrder.Size = new System.Drawing.Size(60, 49);
            this.pictureMyOrder.TabIndex = 13;
            this.pictureMyOrder.TabStop = false;
            // 
            // pictureProfile
            // 
            this.pictureProfile.BackgroundImage = global::Project_PRN.Properties.Resources.profile;
            this.pictureProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureProfile.Location = new System.Drawing.Point(0, 272);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(60, 49);
            this.pictureProfile.TabIndex = 11;
            this.pictureProfile.TabStop = false;
            // 
            // btnMyOrder
            // 
            this.btnMyOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnMyOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMyOrder.FlatAppearance.BorderSize = 0;
            this.btnMyOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyOrder.ForeColor = System.Drawing.Color.White;
            this.btnMyOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyOrder.Location = new System.Drawing.Point(3, 65);
            this.btnMyOrder.Name = "btnMyOrder";
            this.btnMyOrder.Size = new System.Drawing.Size(230, 49);
            this.btnMyOrder.TabIndex = 12;
            this.btnMyOrder.Text = "My Order";
            this.btnMyOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMyOrder.UseVisualStyleBackColor = false;
            this.btnMyOrder.Click += new System.EventHandler(this.btnMyOrder_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 272);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(233, 49);
            this.btnProfile.TabIndex = 10;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pictureShopping
            // 
            this.pictureShopping.BackgroundImage = global::Project_PRN.Properties.Resources.shopping_cart;
            this.pictureShopping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureShopping.Location = new System.Drawing.Point(-3, 0);
            this.pictureShopping.Name = "pictureShopping";
            this.pictureShopping.Size = new System.Drawing.Size(60, 49);
            this.pictureShopping.TabIndex = 11;
            this.pictureShopping.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Project_PRN.Properties.Resources.sign_out;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

            this.pictureBox5.Location = new System.Drawing.Point(-2, 219);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);

            this.pictureBox5.Location = new System.Drawing.Point(-3, 332);

            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 40);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 

            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Project_PRN.Properties.Resources.receipt;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(-2, 165);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 40);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Project_PRN.Properties.Resources.package;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 108);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 40);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Project_PRN.Properties.Resources.account;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 53);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 40);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;

            // btnShopping
            // 
            this.btnShopping.BackColor = System.Drawing.Color.Transparent;
            this.btnShopping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShopping.FlatAppearance.BorderSize = 0;
            this.btnShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShopping.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopping.ForeColor = System.Drawing.Color.White;
            this.btnShopping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShopping.Location = new System.Drawing.Point(0, 0);
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(233, 49);
            this.btnShopping.TabIndex = 10;
            this.btnShopping.Text = "Shopping";
            this.btnShopping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShopping.UseVisualStyleBackColor = false;
            // 
            // pictureOrder
            // 
            this.pictureOrder.BackgroundImage = global::Project_PRN.Properties.Resources.receipt;
            this.pictureOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureOrder.Location = new System.Drawing.Point(-3, 203);
            this.pictureOrder.Name = "pictureOrder";
            this.pictureOrder.Size = new System.Drawing.Size(60, 49);
            this.pictureOrder.TabIndex = 8;
            this.pictureOrder.TabStop = false;
            // 
            // pictureProduct
            // 
            this.pictureProduct.BackgroundImage = global::Project_PRN.Properties.Resources.package;
            this.pictureProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureProduct.Location = new System.Drawing.Point(-3, 133);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(60, 49);
            this.pictureProduct.TabIndex = 7;
            this.pictureProduct.TabStop = false;
            // 
            // pictureAccount
            // 
            this.pictureAccount.BackgroundImage = global::Project_PRN.Properties.Resources.account;
            this.pictureAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureAccount.Location = new System.Drawing.Point(-3, 65);
            this.pictureAccount.Name = "pictureAccount";
            this.pictureAccount.Size = new System.Drawing.Size(60, 49);
            this.pictureAccount.TabIndex = 6;
            this.pictureAccount.TabStop = false;

            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnLogOut.Location = new System.Drawing.Point(0, 219);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);

            this.btnLogOut.Location = new System.Drawing.Point(0, 332);

            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(175, 40);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 

            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_PRN.Properties.Resources.home__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.Transparent;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(0, 165);
            this.btnBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(175, 40);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Bill";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);

            // pictureHome
            // 
            this.pictureHome.BackgroundImage = global::Project_PRN.Properties.Resources.home__1_;
            this.pictureHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureHome.Location = new System.Drawing.Point(-3, 0);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(60, 49);
            this.pictureHome.TabIndex = 4;
            this.pictureHome.TabStop = false;
            this.pictureHome.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Transparent;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 203);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(233, 49);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnBill_Click);

            // 
            // btnProduct
            // 
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 108);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(175, 40);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.Transparent;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 53);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(175, 40);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(175, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 

            // panel1
            // 
            this.panel1.BackgroundImage = global::Project_PRN.Properties.Resources.original1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelWork);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 677);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelWork
            // 
            this.panelWork.BackColor = System.Drawing.Color.Transparent;
            this.panelWork.Location = new System.Drawing.Point(289, 9);
            this.panelWork.Margin = new System.Windows.Forms.Padding(2);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(937, 662);
            this.panelWork.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 

            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1203, 682);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Shopping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMyOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureOrder;
        private System.Windows.Forms.PictureBox pictureProduct;
        private System.Windows.Forms.PictureBox pictureAccount;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelWork;
        private System.Windows.Forms.Button btnShopping;
        private System.Windows.Forms.PictureBox pictureShopping;
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.PictureBox pictureMyOrder;
        private System.Windows.Forms.Button btnMyOrder;
    }
}