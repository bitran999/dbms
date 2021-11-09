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
            Customer customer = new Customer();
            string query = "exec Search_KhachHang @Tim";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] {data });
                customer.Id = dataTable.Rows[0]["MaKH"].ToString();
                customer.Name = dataTable.Rows[0]["TenKH"].ToString();
                customer.Gender = dataTable.Rows[0]["GioiTinh"].ToString();
                customer.Dob = dataTable.Rows[0]["NgaySinh"].ToString();
                customer.Address = dataTable.Rows[0]["DiaChi"].ToString();
                customer.PhoneNb = dataTable.Rows[0]["SDT"].ToString();
                customer.Email = dataTable.Rows[0]["Email"].ToString();
                return customer;
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
    }
}
