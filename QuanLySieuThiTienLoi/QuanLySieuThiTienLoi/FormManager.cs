using QuanLySieuThiTienLoi.DAO;
using QuanLySieuThiTienLoi.DTO;
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

namespace QuanLySieuThiTienLoi
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
            LoadListEmployee();
            LoadListBill();
        }
        public void LoadListEmployee()
        {
            dtgvEmployee.DataSource = EmployeeDAO.Instance.listEmployee();
        }

        private void btnViewEmp_Click(object sender, EventArgs e)
        {
            dtgvEmployee.DataSource = EmployeeDAO.Instance.getEmployeeByFind(tbSearch.Text);
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Id = tbId.Text;
            employee.Name = tbName.Text;
            employee.Gender = tbGender.Text;
            employee.Dob = tbDoB.Text;
            employee.Address = tbAddress.Text;
            employee.PhoneNb = tbPhoneNb.Text;
            employee.UserName = tbUser.Text;
            employee.PassWord = tbPass.Text;
            employee.IdTitle = tbIdTitle.Text;
            if (EmployeeDAO.Instance.checkIdEmployee(employee.Id))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập lại!");
            }
            else
            {
                if (EmployeeDAO.Instance.checkUser(employee.UserName))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                }
                else
                {
                    EmployeeDAO.Instance.add(employee);
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
            LoadListEmployee();
        }

        private void dtgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbId.Text= dtgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbId.Enabled = false;
                LoadInfoEmployee();
            }
        }
        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            EmployeeDAO.Instance.delete(tbId.Text);
            LoadListEmployee();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Id = tbId.Text;
            employee.Name = tbName.Text;
            employee.Gender = tbGender.Text;
            employee.Dob = tbDoB.Text;
            employee.Address = tbAddress.Text;
            employee.PhoneNb = tbPhoneNb.Text;
            employee.UserName = tbUser.Text;
            employee.PassWord = tbPass.Text;
            employee.IdTitle = tbIdTitle.Text;
            if (EmployeeDAO.Instance.checkUser(employee.UserName)){
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
            }
            else { 
                EmployeeDAO.Instance.updateAdmin(employee);
                MessageBox.Show("Cập nhật thành công!");
            }
            LoadInfoEmployee();
        }
        public void LoadInfoEmployee()
        {
            Employee employee = EmployeeDAO.Instance.getEmployeeById(tbId.Text);
            tbId.Text = employee.Id;
            tbName.Text = employee.Name;
            tbGender.Text = employee.Gender;
            tbDoB.Text = employee.Dob;
            tbAddress.Text = employee.Address;
            tbPhoneNb.Text = employee.PhoneNb;
            tbUser.Text = employee.UserName;
            tbPass.Text = employee.PassWord;
            tbIdTitle.Text = employee.IdTitle;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbName.Text = "";
            tbGender.Text = "";
            tbDoB.Text = "";
            tbAddress.Text = "";
            tbPhoneNb.Text = "";
            tbUser.Text = "";
            tbPass.Text = "";
            tbIdTitle.Text = "";
            tbId.Enabled = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void LoadListBill()
        {
            dtgvBill.DataSource = BillDAO.Instance.getListBill();
        }

        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbIdBill.Text = dtgvBill.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbIdBill.Enabled = false;
                LoadListBillInfo();
                LoadBill();
            }
        }
        public void LoadListBillInfo()
        {
            dtgvBillInfo.DataSource = BillInfoDAO.Instance.getListBillInfoById(tbIdBill.Text);
        }
        public void LoadBill()
        {
            Bill bill = BillDAO.Instance.getBillById(tbIdBill.Text);
            tbIdBill.Text = bill.Id;
            tbIdCustomer.Text = bill.IdCustomer;
            tbDate.Text = bill.Date;
            tbIdEmployee.Text = bill.IdEmp;
            tbValue.Text = bill.Price.ToString();
        }
        public void LoadBillInfo()
        {
            BillInfo billInfo = BillInfoDAO.Instance.getBillInfoByIdAll(tbIdBillInfo.Text,tbIdFood.Text);
            tbIdBillInfo.Text = billInfo.IdBill;
            tbIdFood.Text = billInfo.IdFood;
            tbCount.Text = billInfo.Count.ToString();
            tbValueFood.Text = billInfo.Value.ToString();
        }

        private void dtgvBillInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbIdBillInfo.Text = dtgvBillInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbIdBillInfo.Enabled = false;
                tbIdFood.Text = dtgvBillInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbIdFood.Enabled = false;
                LoadBillInfo();
            }
        }
    }
}
