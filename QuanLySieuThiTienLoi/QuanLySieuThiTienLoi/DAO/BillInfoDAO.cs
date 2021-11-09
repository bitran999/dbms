using QuanLySieuThiTienLoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DAO
{
    class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) return instance = new BillInfoDAO(); return instance; }
            private set { instance = value; }
        }
        private BillInfoDAO()
        {
        }
        public void add(string idBill,string idFood,int count)
        {
            string query = "exec Add_ChiTietHoaDon @MaHD , @MaMH , @SoLuong";
            DataProvider.Instance.ExecuteQuery(query, new object[] { idBill, idFood, count });
        }
        public List<BillInfo> getListBillInfoById(string data)
        {
            List<BillInfo> l = new List<BillInfo>();
            string query = "exec info_ChiTietHoaDon @MaHD";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query,new object[] { data});
            foreach (DataRow item in dataTable.Rows)
            {
                BillInfo bill = new BillInfo(item);
                l.Add(bill);
            }
            return l;
        }
        public BillInfo getBillInfoByIdAll(string id, string idf)
        {
            string query = "exec info_ChiTietHoaDon_FindOne @MaHD , @MaMH";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { id, idf });
            DataRow dataRow = dataTable.Rows[0];
            BillInfo bill = new BillInfo(dataRow);
            return bill;
        }
        public void update(string idBill, string idFood, int count)
        {
            string query = "exec Update_ChiTietHoaDon @MaHD , @MaMH , @SoLuong";
            DataProvider.Instance.ExecuteQuery(query, new object[] { idBill, idFood, count });
        }
        public void delete(string idBill, string idFood)
        {
            string query = "exec Delete_ChiTietHoaDon @MaHD , @MaMH ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { idBill, idFood});
        }
    }
}
