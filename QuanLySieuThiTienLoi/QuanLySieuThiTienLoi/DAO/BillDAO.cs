using QuanLySieuThiTienLoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DAO
{
    class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) return instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }
        private BillDAO()
        {
        }
        public void create(string data)
        {
            string idDefault;
            if (data == "")
            {
                idDefault = "KH01";
            }
            else
            {
                idDefault = data;
            }
            string query = "exec Add_HoaDon @Date , @MaKH , @MaNV ";
            string date = DateTime.Now.ToString("yyy/M/dd");
            DataProvider.Instance.ExecuteQuery(query, new object[] { date, idDefault, EmployeeDAO.Instance.getId() });
        }
        public string getId()
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("SELECT TOP 1 * FROM HOADON ORDER BY MaHD DESC");
            return dataTable.Rows[0]["MaHD"].ToString();
        }
        public List<Bill> getListBill( ) 
        {
            List<Bill> l = new List<Bill>();
            string query = "exec Load_HoaDon";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                Bill billInfo = new Bill(item);
                l.Add(billInfo);
            }
            return l;
        }
        public Bill getBillById(string data)
        {
            string query = "exec info_HoaDon @MaHD";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query,new object[] { data});
            DataRow dataRow = dataTable.Rows[0];
            Bill bill = new Bill(dataRow);
            return bill;
        }
    }
}
