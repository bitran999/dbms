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
            loadListSupplier();
            loadListFoodWarehouse();
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
        private Employee getEmployee()
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
            return employee;
        }
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            Employee employee =getEmployee();
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
                tbId.Text = dtgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
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
            Employee employee = getEmployee();
            if (EmployeeDAO.Instance.checkUser(employee.UserName)) {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
            }
            else {
                EmployeeDAO.Instance.updateAdmin(employee);
                MessageBox.Show("Cập nhật thành công!");
            }
            LoadInfoEmployee();
            LoadListEmployee();
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
            profit();
        }

        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbIdBill.Text = dtgvBill.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbIdBill.Enabled = false;
                LoadListBillInfo();
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
            BillInfo billInfo = BillInfoDAO.Instance.getBillInfoByIdAll(tbIdBillInfo.Text, tbIdFood.Text);
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
            string dayFront = dateTimePickerFront.Value.ToString("yyyy/M/dd");
            string dayBack = dateTimePickerBack.Value.ToString("yyyy/M/dd");
            dtgvBill.DataSource = BillDAO.Instance.getListBill(dayFront, dayBack);
            sales();
            profit();
        }
        private void sales()
        {
            float sales = 0;
            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                sales += float.Parse(dtgvBill.Rows[i].Cells[4].Value.ToString());
            }
            tbSales.Text = sales.ToString();
        }
        private void profit()
        {
            List<string> listId = new List<string>();
            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                listId.Add(dtgvBill.Rows[i].Cells[0].Value.ToString());
            }
            tbPh.Text = BillDAO.Instance.profit(listId).ToString();
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
            bill.IdCustomer = tbIdCustomer.Text;
            bill.Date = dateTimeBill.Value.ToString("yyyy/M/dd");
            bill.IdEmp = tbIdEmployee.Text;
            bill.Price = float.Parse(tbValue.Text);
            BillDAO.Instance.Update(bill);
            LoadListBill();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            BillDAO.Instance.create(tbIdCustomer.Text, tbIdEmployee.Text);
            MessageBox.Show("Thêm thành công!");
            LoadListBill();
        }

        private void btnSearchIdBill_Click(object sender, EventArgs e)
        {
            Bill bill = BillDAO.Instance.getBillById(tbIdBill.Text);
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
            tbPriceFood.Text = FoodsDAO.Instance.getPrice(category.Id).ToString();
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
            title.Salary = (float)Convert.ToDouble(tbSalary.Text);
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




        /*-------------------------------------------Nhà cung cấp-------------------------------*/
        private void dtgvSup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Supplier supplier = new Supplier();
                supplier.Id = dtgvSup.Rows[e.RowIndex].Cells[0].Value.ToString();
                supplier.Name = dtgvSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                supplier.Address = dtgvSup.Rows[e.RowIndex].Cells[2].Value.ToString();
                supplier.Contract = dtgvSup.Rows[e.RowIndex].Cells[3].Value.ToString();
                supplier.BankId = dtgvSup.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbIdSup.Text = dtgvSup.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbIdBill.Enabled = false;
                loadListSupBill();
                loadSup(supplier);
            }
        }
        private void loadSup(Supplier supplier)
        {
            tbNameSup.Text = supplier.Name;
            tbAddressSup.Text = supplier.Address;
            tbSupContract.Text = supplier.Contract;
            tbSupPay.Text = supplier.BankId;
        }
        private void loadListSupplier() {
            dtgvSup.DataSource = SupplierDAO.Instance.getList();
        }
        private void loadListSupBill()
        {
            dtgvSupBill.DataSource = SupBillDAO.Instance.getList(tbIdSup.Text);
        }

        private void dtgvSupBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SupBill supBill = new SupBill();
                supBill.Id = dtgvSupBill.Rows[e.RowIndex].Cells[0].Value.ToString();
                supBill.IdSup = dtgvSupBill.Rows[e.RowIndex].Cells[1].Value.ToString();
                supBill.IdFood = dtgvSupBill.Rows[e.RowIndex].Cells[2].Value.ToString();
                supBill.Count = (int)Convert.ToInt32(dtgvSupBill.Rows[e.RowIndex].Cells[3].Value.ToString());
                supBill.Date = dtgvSupBill.Rows[e.RowIndex].Cells[4].Value.ToString();
                supBill.Value = (float)Convert.ToDouble(dtgvSupBill.Rows[e.RowIndex].Cells[5].Value.ToString());
                tbId.Text = dtgvSupBill.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbIdBill.Enabled = false;
                loadSupBill(supBill);
            }
        }
        private void loadSupBill(SupBill supBill)
        {
            tbSupBill.Text = supBill.Id;
            tbIdSup2.Text = supBill.IdSup;
            tbIdFoodSup.Text = supBill.IdFood;
            tbCountSup.Text = supBill.Count.ToString();
            dtSupBill.Value = Convert.ToDateTime(supBill.Date);
            tbValueSup.Text = supBill.Value.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            dtgvSup.DataSource = SupplierDAO.Instance.getList(tbIdSup.Text);
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            SupplierDAO.Instance.add(getSup());
            loadListSupplier();
        }
        private Supplier getSup()
        {
            Supplier supplier = new Supplier();
            supplier.Id = tbIdSup.Text;
            supplier.Name = tbNameSup.Text;
            supplier.Address = tbAddressSup.Text;
            supplier.Contract = tbSupContract.Text;
            supplier.BankId = tbSupPay.Text;
            return supplier;
        }
        private SupBill getSupBill()
        {
            SupBill supBill = new SupBill();
            supBill.Id = tbSupBill.Text;
            supBill.IdSup = tbIdSup2.Text;
            supBill.IdFood = tbIdFoodSup.Text;
            supBill.Count = Convert.ToInt32(tbCountSup.Text);
            supBill.Date = dtSupBill.Value.ToString("yyyy/M/dd"); ;
            supBill.Value = (float)Convert.ToDouble(tbValueSup.Text);
            return supBill;
        }
        private void btnUpdateSup_Click(object sender, EventArgs e)
        {
            SupplierDAO.Instance.update(getSup());
            loadListSupplier();
        }

        private void btnDeleteSup_Click(object sender, EventArgs e)
        {
            SupplierDAO.Instance.delete(tbIdSup.Text);
            loadListSupplier();
        }

        private void btnAddSupBill_Click(object sender, EventArgs e)
        {
            SupBillDAO.Instance.add(getSupBill());
        }

        private void btnUpdateSupBill_Click(object sender, EventArgs e)
        {
            SupBillDAO.Instance.update(getSupBill());
            MessageBox.Show("Sửa thành công!");
        }

        private void btnDeleteSupBill_Click(object sender, EventArgs e)
        {
            SupBillDAO.Instance.delete(tbIdSup2.Text);
            MessageBox.Show("Xóa thành công!");
        }

        private void cbIdFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadListIdFoods()
        {
            List<SupBill> list = SupBillDAO.Instance.searchIdFoods(tbIdSup2.Text);
            cmbIdFood.DataSource = list;
            cmbIdFood.DisplayMember = "idFood";
        }

        private void tbIdSup2_TextChanged(object sender, EventArgs e)
        {
            loadListIdFoods();
        }

        private void btnAddFoods_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageWareHouse;
        }




        /*-------------------------------------Kho Hàng -------------------------------------*/

        private void loadListFoodWarehouse()
        {
            dtgvWareHouse.DataSource = CategoryDAO.Instance.getListCategory();
        }
        private void loadCategory(Category category)
        {
            tbIdFoodWH.Text = category.Id;
            Foods foods = FoodsDAO.Instance.getById(category.Id);
            if (foods != null)
            {
                tbNameFood.Text = foods.Name;
                tbPriceFoodWH.Text = foods.Price.ToString();
                tbPriceHisWH.Text = foods.PriceHis.ToString();
                dtpMF.Value = Convert.ToDateTime(foods.ManuafatorDate);
                dtpOF.Value = Convert.ToDateTime(foods.OutDate);
                if (DateTime.Compare(dtpOF.Value, DateTime.Now) < 0)
                {
                    tbStatus.Text = "Đã hết hạn sử dụng";
                    tbStatus.BackColor = Color.Red;
                }
                else
                {
                    tbStatus.Text = "Còn  hạn sử dụng";
                    tbStatus.BackColor = Color.White;
                }
            }
            tbWHSave.Text = category.Count.ToString();
        }
        private void dtgvWareHouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Category category = new Category();
                category.Id = dtgvWareHouse.Rows[e.RowIndex].Cells[0].Value.ToString();
                category.Status = dtgvWareHouse.Rows[e.RowIndex].Cells[1].Value.ToString();
                category.Count = Convert.ToInt32(dtgvWareHouse.Rows[e.RowIndex].Cells[2].Value.ToString());
                tbIdBill.Enabled = false;
                loadCategory(category);
            }
        }
        private Foods getFoods()
        {
            Foods foods = new Foods();
            foods.Id = tbIdFoodWH.Text;
            foods.Name = tbNameFood.Text;
            foods.Price = (float)Convert.ToDouble(tbPriceFoodWH.Text);
            foods.PriceHis = (float)Convert.ToDouble(tbPriceHisWH.Text);
            foods.ManuafatorDate = dtpMF.Value.ToString("yyyy/M/dd");
            foods.OutDate = dtpOF.Value.ToString("yyyy/M/dd");
            return foods;
        }
        private Category getCategory()
        {
            Category category = new Category();
            category.Id = tbIdFoodWH.Text;
            category.Status = "";
            category.Count = Convert.ToInt32(tbWHSave.Text);
            return category;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgvWareHouse.DataSource = CategoryDAO.Instance.search(tbIdFoodWH.Text);
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            FoodsDAO.Instance.delete(tbIdFoodWH.Text);
            CategoryDAO.Instance.delete(tbIdFoodWH.Text);
            MessageBox.Show("Xóa thành công");
            loadListFoodWarehouse();
        }
        private bool check()
        {
            return DateTime.Compare(dtpMF.Value, dtpOF.Value) > 0;
        }

        private void btnAddFood_Click_1(object sender, EventArgs e)
        {
            if(CategoryDAO.Instance.checkFoodInCategory(tbIdFoodWH.Text))
            {
                FoodsDAO.Instance.add(getFoods());
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Cần thêm mặt hàng vào kho trước khi thêm vào danh sách mặt hàng");
            }
            loadListFoodWarehouse();
        }

        private void btnUpdateFoods_Click(object sender, EventArgs e)
        {
            FoodsDAO.Instance.update(getFoods());
            MessageBox.Show("Sửa thành công");
            loadListFoodWarehouse();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryDAO.Instance.add(getCategory());
            MessageBox.Show("Thêm thành công");
            loadListFoodWarehouse();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            CategoryDAO.Instance.update(getCategory());
            MessageBox.Show("Sửa thành công");
            loadListFoodWarehouse();
        }

        private void btnFilterNoOF_Click(object sender, EventArgs e)
        {
            dtgvWareHouse.DataSource = CategoryDAO.Instance.listNOF();
        }

        private void btnFilterOF_Click(object sender, EventArgs e)
        {
            dtgvWareHouse.DataSource= CategoryDAO.Instance.listOF();
        }
    }
}
