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
            loadListFoods();
            loadTitle();
        }
        /*-------------------------Menu-----------------------------*/
        /*-------------------------Nhân Viên-----------------------------*/
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
        /*-------------------------Doanh số-----------------------------*/
        private void LoadListBill()
        {
            dtgvBill.DataSource = BillDAO.Instance.getListBill();
            sales();
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
            dateTimeBill.Value = DateTime.Parse(bill.Date);
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

        private void btnViewData_Click(object sender, EventArgs e)
        {
            string dayFront=dateTimePickerFront.Value.ToString("yyyy/M/dd");
            string dayBack = dateTimePickerBack.Value.ToString("yyyy/M/dd");
            dtgvBill.DataSource = BillDAO.Instance.getListBill(dayFront, dayBack);
            sales();
        }
        private void sales()
        {
            float sales = 0;
            for(int i = 0; i < dtgvBill.Rows.Count; i++)
            {
               sales+=float.Parse(dtgvBill.Rows[i].Cells[4].Value.ToString());
            }
            tbSales.Text = sales.ToString();
        }

        private void btnDelelteBill_Click(object sender, EventArgs e)
        {
            BillDAO.Instance.deleteById(tbIdBill.Text);
            LoadListBill();
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Id = tbIdBill.Text;
            bill.IdCustomer=tbIdCustomer.Text;
            bill.Date=dateTimeBill.Value.ToString("yyyy/M/dd");
            bill.IdEmp=tbIdEmployee.Text;
            bill.Price = float.Parse(tbValue.Text);
            BillDAO.Instance.Update(bill);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            BillDAO.Instance.create(tbIdCustomer.Text,tbIdEmployee.Text);
            MessageBox.Show("Thêm thành công!");
        }

        private void btnSearchIdBill_Click(object sender, EventArgs e)
        {
            Bill bill=BillDAO.Instance.getBillById(tbIdBill.Text);
            if (bill != null)
            {
                tbIdBill.Text = bill.Id;
                tbIdCustomer.Text = bill.IdCustomer;
                dateTimeBill.Value = DateTime.Parse(bill.Date);
                tbIdEmployee.Text = bill.IdEmp;
                tbValue.Text = bill.Price.ToString();
            }
        }

        private void tbLoad_Click(object sender, EventArgs e)
        {
            tbIdBill.Enabled = true;
            tbIdBillInfo.Enabled = true;
            tbIdBill.Text = "";
            tbIdCustomer.Text = "";
            dateTimeBill.Value = DateTime.Now;
            tbIdEmployee.Text = "";
            tbValue.Text = "";
            tbIdBillInfo.Text = "";
            tbIdFood.Text = "";
            tbCount.Text = "";
            tbValueFood.Text = "";
        }

        private void btnAddBillInfo_Click(object sender, EventArgs e)
        {
             BillInfoDAO.Instance.add(tbIdBillInfo.Text, tbIdFood.Text, int.Parse(tbCount.Text));
            MessageBox.Show("Thêm thành công!");
        }

        private void loadListFoods()
        {
            List<Foods> list = FoodsDAO.Instance.getList();
            cmbListFoods.DataSource = list;
            cmbListFoods.DisplayMember = "name";
            countFood();
        }
        private void countFood()
        {
                Foods food = cmbListFoods.SelectedItem as Foods;
                Category category = CategoryDAO.Instance.getFood(food.Id);
                tbCountFood.Text = category.Count.ToString();
                tbIdFood.Text = category.Id;
        }

        private void cmbListFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            countFood();
        }

        private void btnUpdateBillInfo_Click(object sender, EventArgs e)
        {
            BillInfoDAO.Instance.update(tbIdBill.Text, tbIdFood.Text, int.Parse(tbCount.Text));
            MessageBox.Show("Sửa thành công!");
        }

        private void btnDeleteBillInfo_Click(object sender, EventArgs e)
        {
            BillInfoDAO.Instance.delete(tbIdBill.Text, tbIdFood.Text);
            MessageBox.Show("Xóa thành công!");
        }
        /*-------------------------Chức Vụ-----------------------------*/
        private void loadTitle()
        {
            dtgvTitle.DataSource = TitleDAO.Instance.getListTitle();
        }
        private void dtgvTitle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbIdTitleM.Text = dtgvTitle.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTitle.Text = dtgvTitle.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbSalary.Text = dtgvTitle.Rows[e.RowIndex].Cells[2].Value.ToString();
                loadTitle();
            }
        }

        private void btnDeleteTitle_Click(object sender, EventArgs e)
        {
            TitleDAO.Instance.delete(tbIdTitleM.Text);
        }

        private void btnUpdateTitle_Click(object sender, EventArgs e)
        {
            Title title = new Title();
            title.Id = tbIdTitleM.Text;
            title.Name = tbTitle.Text;
            title.Salary =(float)Convert.ToDouble(tbSalary.Text);
            TitleDAO.Instance.update(title);
        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            Title title = new Title();
            title.Id = tbIdTitleM.Text;
            title.Name = tbTitle.Text;
            title.Salary = (float)Convert.ToDouble(tbSalary.Text);
            TitleDAO.Instance.add(title);
        }
    }
}
