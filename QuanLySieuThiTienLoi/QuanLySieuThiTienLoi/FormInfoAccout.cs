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
    public partial class FormInfoAccout : Form
    {
        public FormInfoAccout()
        {
            InitializeComponent();
            LoadInfo();
        }
        public void LoadInfo()
        {
            Employee employee = EmployeeDAO.Instance.getEmployee();
            tbID.Text = employee.Id;
            tbName.Text = employee.Name; 
            tbGender.Text = employee.Gender;
            tbDoB.Text= employee.Dob;
            tbAddress.Text= employee.Address;
            tbPhoneNb.Text= employee.PhoneNb;
            tbUserName.Text= employee.UserName;
            tbPass.Text = employee.PassWord;
            tbTitle.Text = employee.Title;
            tbSalary.Text = employee.Salary.ToString();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee() ;
            employee.Name = tbName.Text;
            employee.Gender = tbGender.Text;
            employee.Dob = tbDoB.Text;
            employee.Address = tbAddress.Text;
            employee.PhoneNb = tbPhoneNb.Text;
            EmployeeDAO.Instance.update(employee);
            LoadInfo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnChangePassWord_Click(object sender, EventArgs e)
        {
            FormChangePassWord f = new FormChangePassWord();
            f.ShowDialog();
        }
    }
}
