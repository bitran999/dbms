using QuanLySieuThiTienLoi.DAO;
using QuanLySieuThiTienLoi.DTO;
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
    public partial class FormCustommer : Form
    {
        public FormCustommer()
        {
            InitializeComponent();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = tbName.Text;
            customer.Gender = tbGender.Text;
            customer.Dob = dtDoB.Value.ToString("yyyy/M/dd");
            customer.Address = tbAddress.Text;
            customer.PhoneNb = tbPhoneNb.Text;
            customer.Email = tbEmail.Text;
            if (CustomerDAO.Instance.check(customer))
            {
                MessageBox.Show("Số điện thoại hoặc email đã được đăng ký");
                Customer customer1;
                if (CustomerDAO.Instance.Search(customer.PhoneNb) != null)
                {
                    customer1  = CustomerDAO.Instance.Search(customer.PhoneNb);

                }
                else
                {
                    customer1 = CustomerDAO.Instance.Search(customer.Email);
                }
                load(customer1);
            }
            else
            {
                CustomerDAO.Instance.add(customer);
                MessageBox.Show("Thêm thành công");
            }
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void load(Customer customer)
        {
            tbId.Text = customer.Id;
            tbName.Text = customer.Name;
            tbGender.Text = customer.Gender;
            dtDoB.Value = DateTime.Parse(customer.Dob);
            tbAddress.Text = customer.Address;
            tbPhoneNb.Text = customer.PhoneNb;
            tbEmail.Text = customer.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Id = tbId.Text;
            customer.Name = tbName.Text;
            customer.Gender = tbGender.Text;
            customer.Dob = dtDoB.Value.ToString("yyyy/M/dd");
            customer.Address = tbAddress.Text;
            customer.PhoneNb = tbPhoneNb.Text;
            customer.Email = tbEmail.Text;
            CustomerDAO.Instance.update(customer);
            MessageBox.Show("Cập nhật thành công!");
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerDAO.Instance.Search(tbId.Text);
            tbId.Text = customer.Id;
            tbGender.Text = customer.Gender;
            dtDoB.Value = DateTime.Parse(customer.Dob);
            tbAddress.Text = customer.Address;
            tbName.Text = customer.Name;
            tbPhoneNb.Text = customer.PhoneNb;
            tbEmail.Text = customer.Email;
        }
    }
}
