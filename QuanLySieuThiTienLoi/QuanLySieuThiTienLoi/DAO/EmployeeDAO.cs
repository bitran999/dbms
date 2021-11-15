using QuanLySieuThiTienLoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DAO
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance;
        private string id; 
        private bool admin;
        public static EmployeeDAO Instance
        {
            get { if (instance == null) return instance = new EmployeeDAO();return instance; }
            private set { instance = value; }
        }

        public string Id { get => id; set => id = value; }
        public bool Admin { get => admin; set => admin = value; }

        private EmployeeDAO() {
        }

        public bool Login(string userName,string passWord,bool admin)
        {
            this.admin = admin;
            string query = "exec NhanVien_DangNhap @UserName , @PassWord";
            DataProvider.Instance.setAdmin(admin);
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            if (dataTable== null)
                return false;
            if (dataTable.Rows.Count > 0)
            {
                id = dataTable.Rows[0]["MaNV"].ToString();
                return true;
            }
            return false;
        }
        public void update(Employee employee)
        {
            string query = "exec Update_ThongTinNhanVien @MaNV , @TenNV , @GioiTinh , @NgaySinh , @DiaChi , @SDT ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { id,employee.Name,employee.Gender,employee.Dob,employee.Address,employee.PhoneNb });
        }
        public void updateAdmin(Employee employee)
        {
            string query = "exec Update_NhanVien_Admin @MaNV , @TenNV , @GioiTinh , @NgaySinh , @DiaChi , @Users , @Pass , @SDT , @MaChucVu ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { employee.Id, employee.Name, employee.Gender, employee.Dob, employee.Address,employee.UserName,employee.PassWord, employee.PhoneNb,employee.IdTitle });
        }
        public void add(Employee employee)
        {
            string query = "exec Add_NhanVien @MaNV , @TenNV , @GioiTinh , @NgaySinh , @DiaChi , @Users , @Pass , @SDT , @MaChucVu ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { employee.Id, employee.Name, employee.Gender, employee.Dob, employee.Address, employee.UserName, employee.PassWord, employee.PhoneNb, employee.IdTitle });
        }
        public List<Employee> listEmployee ()
        {
            List<Employee> l = new List<Employee>();
            string query = "exec Load_Info_NhanVien";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            if (dataTable == null)
                return null;
            foreach (DataRow item in dataTable.Rows)
            {
                Employee employee = new Employee(item);
                l.Add(employee);
            }
            return l;
        }
        public Employee getEmployee()
        {
            string query = "exec Load_ThongTinNV @MaNV";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            DataRow dataRow = dataTable.Rows[0];
            Employee employee = new Employee(dataRow);
            return employee;
        }
        public Employee getEmployeeById(string data)
        {
            string query = "exec Load_ThongTinNV @MaNV";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { data });
            DataRow dataRow = dataTable.Rows[0];
            Employee employee = new Employee(dataRow);
            return employee;
        }
        public List<Employee> getEmployeeByFind(string data )
        {
            List<Employee> l = new List<Employee>();
            string query = "exec  Search_NhanVien @Tim";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { data });
            foreach (DataRow item in dataTable.Rows)
            {
                string sql = item["MaNV"].ToString();
                Employee employee = getEmployeeById(sql);
                l.Add(employee);
            }
            return l;
        }
        public bool checkPW(string newPasss)
        {
            string query = "exec Check_PassWord @MaNV , @newPass ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id, newPasss }).Rows.Count>0;
        }
        public bool checkUser(string data)
        {
            string query = "exec Check_UserName  @User ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {data}).Rows.Count > 0;
        }
        public bool checkIdEmployee(string data)
        {
            string query = "exec Check_MaNV  @MaNV ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { data }).Rows.Count > 0;
        }
        public bool checkAdmin()
        {
            if(getEmployee().IdTitle == "MNG")
            {
                return true;
            }
            return false;
        }
        public void changePass(string newPasss)
        {
            string query = "exec Change_PassWord @MaNV , @newPass ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { id, newPasss });
        }
        public string getId()
        {
            return id;
        }
        public void delete(string data)
        {
            string query = "exec Delete_NhanVien @MaNV";
            DataProvider.Instance.ExecuteQuery(query, new object[] { data });
        }
    }
}
