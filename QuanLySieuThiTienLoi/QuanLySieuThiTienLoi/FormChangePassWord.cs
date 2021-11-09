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
    public partial class FormChangePassWord : Form
    {
        public FormChangePassWord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (EmployeeDAO.Instance.checkPW(tbOldPass.Text))
            {
                if (tbNewPass.Text == tbRetypePass.Text)
                {
                    EmployeeDAO.Instance.changePass(tbNewPass.Text);
                    MessageBox.Show("Đổi thành công");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không giống nhau!");
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu!");
            }
        }
    }
}
