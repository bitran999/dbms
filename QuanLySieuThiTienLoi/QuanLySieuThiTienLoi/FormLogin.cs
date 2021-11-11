using QuanLySieuThiTienLoi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiTienLoi
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            string passWord = tbPassWord.Text;
            bool admin = cbAdmin.Checked;
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản hoặc mật khẩu!");
            }
            else
            {
                if (Login(userName, passWord, admin))
                {
                    if (admin)
                    {
                        if (EmployeeDAO.Instance.checkAdmin())
                        {
                            FormMain f = new FormMain();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Bạn không có quyền Quản Lý!");
                        }
                    }
                    else
                    {
                        FormMain f = new FormMain();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mặt khẩu");
                }
            }
        }
        bool Login(string userName, string passWord,bool admin)
        {
            return EmployeeDAO.Instance.Login(userName, passWord,admin);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát!","Thông báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
