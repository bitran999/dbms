
namespace QuanLySieuThiTienLoi
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbIdCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.labelEmailCustomer = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelNameCustomer = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPhoneNb = new System.Windows.Forms.TextBox();
            this.labelIDCustomer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnDeleteFoods = new System.Windows.Forms.Button();
            this.btnAddGoods = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCountFood = new System.Windows.Forms.TextBox();
            this.nmFoodsCount = new System.Windows.Forms.NumericUpDown();
            this.cmbListFoods = new System.Windows.Forms.ComboBox();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.labelTittle = new System.Windows.Forms.Label();
            this.dtNow = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodsCount)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btnSearchCustomer);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 159);
            this.panel2.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbCustomer);
            this.panel8.Controls.Add(this.labelCustomer);
            this.panel8.Location = new System.Drawing.Point(9, 46);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(389, 42);
            this.panel8.TabIndex = 11;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(159, 10);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(215, 26);
            this.tbCustomer.TabIndex = 1;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(3, 16);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(148, 17);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "Tìm Kiếm Khách Hàng";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbIdCustomer);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(416, 19);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(467, 36);
            this.panel7.TabIndex = 10;
            // 
            // tbIdCustomer
            // 
            this.tbIdCustomer.Enabled = false;
            this.tbIdCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCustomer.Location = new System.Drawing.Point(213, 3);
            this.tbIdCustomer.Name = "tbIdCustomer";
            this.tbIdCustomer.Size = new System.Drawing.Size(228, 26);
            this.tbIdCustomer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Location = new System.Drawing.Point(33, 109);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(65, 30);
            this.btnSearchCustomer.TabIndex = 5;
            this.btnSearchCustomer.Text = "Tìm";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbEmail);
            this.panel6.Controls.Add(this.labelEmailCustomer);
            this.panel6.Location = new System.Drawing.Point(416, 125);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(467, 31);
            this.panel6.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(213, 3);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(228, 23);
            this.tbEmail.TabIndex = 1;
            // 
            // labelEmailCustomer
            // 
            this.labelEmailCustomer.AutoSize = true;
            this.labelEmailCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailCustomer.Location = new System.Drawing.Point(79, 8);
            this.labelEmailCustomer.Name = "labelEmailCustomer";
            this.labelEmailCustomer.Size = new System.Drawing.Size(42, 17);
            this.labelEmailCustomer.TabIndex = 0;
            this.labelEmailCustomer.Text = "Email";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbName);
            this.panel5.Controls.Add(this.labelNameCustomer);
            this.panel5.Location = new System.Drawing.Point(416, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(467, 31);
            this.panel5.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(213, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 23);
            this.tbName.TabIndex = 1;
            // 
            // labelNameCustomer
            // 
            this.labelNameCustomer.AutoSize = true;
            this.labelNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameCustomer.Location = new System.Drawing.Point(79, 8);
            this.labelNameCustomer.Name = "labelNameCustomer";
            this.labelNameCustomer.Size = new System.Drawing.Size(115, 17);
            this.labelNameCustomer.TabIndex = 0;
            this.labelNameCustomer.Text = "Tên Khách Hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbPhoneNb);
            this.panel3.Controls.Add(this.labelIDCustomer);
            this.panel3.Location = new System.Drawing.Point(416, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 31);
            this.panel3.TabIndex = 3;
            // 
            // tbPhoneNb
            // 
            this.tbPhoneNb.Enabled = false;
            this.tbPhoneNb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNb.Location = new System.Drawing.Point(213, 3);
            this.tbPhoneNb.Name = "tbPhoneNb";
            this.tbPhoneNb.Size = new System.Drawing.Size(228, 23);
            this.tbPhoneNb.TabIndex = 1;
            // 
            // labelIDCustomer
            // 
            this.labelIDCustomer.AutoSize = true;
            this.labelIDCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDCustomer.Location = new System.Drawing.Point(79, 5);
            this.labelIDCustomer.Name = "labelIDCustomer";
            this.labelIDCustomer.Size = new System.Drawing.Size(36, 17);
            this.labelIDCustomer.TabIndex = 0;
            this.labelIDCustomer.Text = "SĐT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm Khách Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Controls.Add(this.btnDeleteFoods);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAddGoods);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(13, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 453);
            this.panel1.TabIndex = 1;
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.price,
            this.count,
            this.total});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(6, 183);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(495, 260);
            this.listView.TabIndex = 11;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Mã Sản Phẩm";
            this.id.Width = 80;
            // 
            // name
            // 
            this.name.Text = "Tên Sản Phẩm";
            this.name.Width = 170;
            // 
            // price
            // 
            this.price.Text = "Giá";
            this.price.Width = 68;
            // 
            // count
            // 
            this.count.Text = "Số Lượng";
            this.count.Width = 70;
            // 
            // total
            // 
            this.total.Text = "Thành Tiền";
            this.total.Width = 100;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(580, 382);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(107, 39);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sản Phẩm";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(760, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 39);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng Tiền";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(676, 313);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(156, 23);
            this.tbTotal.TabIndex = 5;
            // 
            // btnDeleteFoods
            // 
            this.btnDeleteFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFoods.Location = new System.Drawing.Point(559, 255);
            this.btnDeleteFoods.Name = "btnDeleteFoods";
            this.btnDeleteFoods.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteFoods.TabIndex = 4;
            this.btnDeleteFoods.Text = "Xóa";
            this.btnDeleteFoods.UseVisualStyleBackColor = true;
            this.btnDeleteFoods.Click += new System.EventHandler(this.btnDeleteFoods_Click);
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGoods.Location = new System.Drawing.Point(738, 255);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(75, 28);
            this.btnAddGoods.TabIndex = 2;
            this.btnAddGoods.Text = "Thêm";
            this.btnAddGoods.UseVisualStyleBackColor = true;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbCountFood);
            this.panel4.Controls.Add(this.nmFoodsCount);
            this.panel4.Controls.Add(this.cmbListFoods);
            this.panel4.Location = new System.Drawing.Point(519, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 53);
            this.panel4.TabIndex = 3;
            // 
            // tbCountFood
            // 
            this.tbCountFood.Enabled = false;
            this.tbCountFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountFood.Location = new System.Drawing.Point(314, 12);
            this.tbCountFood.Name = "tbCountFood";
            this.tbCountFood.Size = new System.Drawing.Size(52, 26);
            this.tbCountFood.TabIndex = 15;
            // 
            // nmFoodsCount
            // 
            this.nmFoodsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFoodsCount.Location = new System.Drawing.Point(255, 12);
            this.nmFoodsCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmFoodsCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodsCount.Name = "nmFoodsCount";
            this.nmFoodsCount.Size = new System.Drawing.Size(46, 26);
            this.nmFoodsCount.TabIndex = 3;
            this.nmFoodsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbListFoods
            // 
            this.cmbListFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbListFoods.FormattingEnabled = true;
            this.cmbListFoods.Location = new System.Drawing.Point(7, 10);
            this.cmbListFoods.Name = "cmbListFoods";
            this.cmbListFoods.Size = new System.Drawing.Size(242, 28);
            this.cmbListFoods.TabIndex = 1;
            this.cmbListFoods.SelectedIndexChanged += new System.EventHandler(this.cmbListFoods_SelectedIndexChanged);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.customerToolStripMenuItem.Text = "Khách Hàng";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(132, 23);
            this.infoToolStripMenuItem.Text = "Thông tin cá nhân";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // ManagerToolStripMenuItem
            // 
            this.ManagerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ManagerToolStripMenuItem.Name = "ManagerToolStripMenuItem";
            this.ManagerToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.ManagerToolStripMenuItem.Text = "Quản lý";
            this.ManagerToolStripMenuItem.Click += new System.EventHandler(this.ManagerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.ManagerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(916, 27);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.Location = new System.Drawing.Point(296, 36);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(105, 25);
            this.labelTittle.TabIndex = 2;
            this.labelTittle.Text = "HÓA ĐƠN";
            // 
            // dtNow
            // 
            this.dtNow.CustomFormat = "dd/M/yyyy";
            this.dtNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNow.Location = new System.Drawing.Point(773, 36);
            this.dtNow.Name = "dtNow";
            this.dtNow.Size = new System.Drawing.Size(102, 23);
            this.dtNow.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 530);
            this.Controls.Add(this.dtNow);
            this.Controls.Add(this.labelTittle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodsCount)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbListFoods;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnDeleteFoods;
        private System.Windows.Forms.Button btnAddGoods;
        private System.Windows.Forms.NumericUpDown nmFoodsCount;
        private System.Windows.Forms.DateTimePicker dtNow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelEmailCustomer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelNameCustomer;
        private System.Windows.Forms.Label labelIDCustomer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPhoneNb;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdCustomer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.TextBox tbCountFood;
        private System.Windows.Forms.ColumnHeader total;
    }
}