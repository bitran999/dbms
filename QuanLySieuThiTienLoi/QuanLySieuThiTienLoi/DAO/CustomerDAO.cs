using QuanLySieuThiTienLoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DAO
{
    class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get { if (instance == null) return instance = new CustomerDAO(); return instance; }
            private set { instance = value; }
        }
        private CustomerDAO()
        {
        }
        public Customer Search(string data)
        {
            string query = "exec Search_KhachHang @Tim";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] {data });
            if (dataTable.Rows.Count==0)
            {
                return null;
            }
            else
            {
                return new Customer(dataTable.Rows[0]); ;
            }
        }
        public void add(Customer customer)
        {
            string query = "exec Add_KhachHang @TenKH , @GioiTinh , @NgaySinh , @DiaChi , @SDT , @Email";
             DataProvider.Instance.ExecuteQuery(query, new object[] { customer.Name, customer.Gender, customer.Dob, customer.Address, customer.PhoneNb, customer.Email });
        }
        public bool check(Customer customer)
        {
            string query = "exec Check_Customer @SDT , @Email";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { customer.PhoneNb, customer.Email }).Rows.Count>0;
        }
      
        public void update(Customer customer)
        {
            string query = "exec Update_KhachHang @MaKH , @TenKH , @GioiTinh , @NgaySinh , @DiaChi , @SDT , @Email";
            DataProvider.Instance.ExecuteQuery(query, new object[] { customer.Id,customer.Name, customer.Gender, customer.Dob, customer.Address, customer.PhoneNb, customer.Email });
        }
        public List<Customer> getListCustomer()
        {
            List<Customer> l = new List<Customer>();
            string query = "exec  Load_KhachHang";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                Customer customer = new Customer(item);
                l.Add(customer);
            }
            return l;
        }
        public List<Customer> search(string data)
        {
            List<Customer> l = new List<Customer>();
            string query = "exec Search_KhachHang @Tim ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query,new object[] { data});
            foreach (DataRow item in dataTable.Rows)
            {
                Customer customer = new Customer(item);
                l.Add(customer);
            }
            return l;
        }
        public void delete(string data)
        {
            string query = "exec Delete_KhachHang @MaKh ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { data });
        }
    }
}
