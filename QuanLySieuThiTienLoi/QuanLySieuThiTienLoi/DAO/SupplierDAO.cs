using QuanLySieuThiTienLoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DAO
{
    class SupplierDAO
    {
        private static SupplierDAO instance;
        public static SupplierDAO Instance
        {
            get { if (instance == null) return instance = new SupplierDAO(); return instance; }
            private set { instance = value; }
        }
        private SupplierDAO()
        {
        }
        public List<Supplier> getList()
        {
            List<Supplier> l = new List<Supplier>();
            string query = "exec Load_NhaCungCap";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                Supplier supplier = new Supplier(item);
                l.Add(supplier);
            }
            return l;
        }
        public Supplier getSupplierById(string data)
        {
            string query = "exec info_HoaDon @MaHD";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { data });
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                Supplier supplier = new Supplier(dataRow);
                return supplier;
            }
            return null;
        }
         public List<Supplier> getList(string data)
        {
            List<Supplier> l = new List<Supplier>();
            string query = "exec Search_NhaCungCap @Tim ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { data });
            foreach (DataRow item in dataTable.Rows)
            {
                Supplier supplier = new Supplier(item);
                l.Add(supplier);
            }
            return l;
        }
        public void add(Supplier supplier)
        {
            string query = "exec Add_NhaCungCap @MaNCC , @TenNCC , @DiaChi , @SDT , @STK ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { supplier.Id,supplier.Name,supplier.Address,supplier.Contract,supplier.BankId });
        }
        public void update(Supplier supplier)
        {
            string query = "exec Update_NhaCungCap @MaNCC , @TenNCC , @DiaChi , @SDT , @STK ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { supplier.Id, supplier.Name, supplier.Address, supplier.Contract, supplier.BankId });
        }
        public void delete(string data)
        {
            string query = "exec Delete_NhaCungCap @MaNCC  ";
            DataProvider.Instance.ExecuteQuery(query, new object[] {data });
        }
    }
}
