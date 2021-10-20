
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.appNameLable = new System.Windows.Forms.Label();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.label_btn_NhanVien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appNameLable
            // 
            this.appNameLable.AutoSize = true;
            this.appNameLable.BackColor = System.Drawing.Color.Transparent;
            this.appNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLable.ForeColor = System.Drawing.Color.OrangeRed;
            this.appNameLable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appNameLable.Location = new System.Drawing.Point(148, 35);
            this.appNameLable.Name = "appNameLable";
            this.appNameLable.Size = new System.Drawing.Size(512, 44);
            this.appNameLable.TabIndex = 0;
            this.appNameLable.Text = "Quản Lý Của Hàng Tiện Lợi";
            this.appNameLable.Click += new System.EventHandler(this.appNameLable_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.BackgroundImage")));
            this.btn_NhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NhanVien.Location = new System.Drawing.Point(108, 168);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(79, 71);
            this.btn_NhanVien.TabIndex = 1;
            this.btn_NhanVien.UseVisualStyleBackColor = true;
            // 
            // label_btn_NhanVien
            // 
            this.label_btn_NhanVien.AutoSize = true;
            this.label_btn_NhanVien.BackColor = System.Drawing.Color.Transparent;
            this.label_btn_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_btn_NhanVien.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_btn_NhanVien.Location = new System.Drawing.Point(103, 254);
            this.label_btn_NhanVien.Name = "label_btn_NhanVien";
            this.label_btn_NhanVien.Size = new System.Drawing.Size(84, 18);
            this.label_btn_NhanVien.TabIndex = 2;
            this.label_btn_NhanVien.Text = "Nhân Viên";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(229, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 71);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(346, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 71);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(471, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 71);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(581, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 71);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(783, 491);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_btn_NhanVien);
            this.Controls.Add(this.btn_NhanVien);
            this.Controls.Add(this.appNameLable);
            this.Name = "FormMain";
            this.Text = "Hệ Thống Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appNameLable;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Label label_btn_NhanVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

