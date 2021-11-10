using QuanLySieuThiTienLoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DAO
{
    class SupBillDAO
    {
        private static SupBillDAO instance;
        public static SupBillDAO Instance
        {
            get { if (instance == null) return instance = new SupBillDAO(); return instance; }
            private set { instance = value; }
        }
        private SupBillDAO()
        {
        }
        public List<SupBill> getList(string id)
        {
            List<SupBill> l = new List<SupBill>();
            string query = "exec Load_HoaDonNhan @MaNCC";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query,new object[] { id});
            foreach (DataRow item in dataTable.Rows)
            {
                SupBill SupBill = new SupBill(item);
                l.Add(SupBill);
            }
            return l;
        }
        public void add(SupBill supBill)
        {
            string query = "exec Add_HoaDonNhanHang @MaNCC , @MaMH , @NgayGiao , @SoLuong";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { supBill.IdSup, supBill.IdFood,supBill.Date,supBill.Count});
        }
        public void update(SupBill supBill)
        {
            string query = "exec Update_HoaDonNhanHang @MaHDN , @SoLuong";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { supBill.Id, supBill.Count });
        }
        public void delete(string data)
        {
            string query = "exec Delete_HoaDonNhan @MaHDN";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { data});
        }
        public List<SupBill> searchIdFoods(string id)
        {
            List<SupBill> l = new List<SupBill>();
            string query = "exec Search_MatHang_NCC @Tim";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in dataTable.Rows)
            {
                SupBill SupBill = new SupBill(item);
                l.Add(SupBill);
            }
            return l;
        }
    }
}
