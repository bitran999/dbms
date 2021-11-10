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
                idDefault = "KH001";
            }
            else
            {
                idDefault = data;
            }
            string query = "exec Add_HoaDon @Date , @MaKH , @MaNV ";
            string date = DateTime.Now.ToString("yyyy/M/dd");
            DataProvider.Instance.ExecuteQuery(query, new object[] { date, idDefault, EmployeeDAO.Instance.getId() });
        }
        public void create(string idCus,string idEmp)
        {
            string idDefault;
            if (idCus == "")
            {
                idDefault = "KH01";
            }
            else
            {
                idDefault = idCus;
            }
            string query = "exec Add_HoaDon @Date , @MaKH , @MaNV ";
            string date = DateTime.Now.ToString("yyyy/M/dd");
            DataProvider.Instance.ExecuteQuery(query, new object[] { date, idDefault, idEmp});
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
                Bill bill = new Bill(item);
                l.Add(bill);
            }
            return l;
        }
        public Bill getBillById(string data)
        {
            string query = "exec info_HoaDon @MaHD";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query,new object[] { data});
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                Bill bill = new Bill(dataRow);
                return bill;
            }
            return null;
        }
        public List<Bill> getListBill(string dateF,string dateB)
        {
            List<Bill> l = new List<Bill>();
            string query = "exec  Load_Bill_Date @DateFont , @DateBack ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query,new object[] { dateF,dateB});
            foreach (DataRow item in dataTable.Rows)
            {
                Bill bill = new Bill(item);
                l.Add(bill);
            }
            return l;
        }
        public void deleteById(string data)
        {
            string query = "exec  Delete_HoaDon @MaHD ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { data });
        }
        public void Update(Bill bill)
        {
            string query = "exec  Update_HoaDon @MaHD , @NgayLHD , @MaKH , @MaNV ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { bill.Id,bill.Date,bill.IdCustomer,bill.IdEmp,bill.Price });
        }
        public float profit(List<string> l)
        {
            float rs = 0;
            string query = "exec LoiNhuan_HoaDon @MaHD";
            for(int i = 0; i < l.Count; i++)
            {
               rs+=(float)Convert.ToDouble(DataProvider.Instance.ExecuteQuery(query, new object[] { l[i] }).Rows[0]["LoiNhuan"].ToString());
            }
            return rs;
        }
    }
}
