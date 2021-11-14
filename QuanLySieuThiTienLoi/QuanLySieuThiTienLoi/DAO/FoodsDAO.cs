using QuanLySieuThiTienLoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DAO
{
    class FoodsDAO
    {
        private static FoodsDAO instance;
        public static FoodsDAO Instance
        {
            get { if (instance == null) return instance = new FoodsDAO(); return instance; }
            private set { instance = value; }
        }
        private FoodsDAO()
        {
        }
        public List<Foods> getList()
        {
            List<Foods> l = new List<Foods>();
            string query = "exec Load_MatHang";
            DataTable dataTable= DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in dataTable.Rows)
            {
                Foods foods = new Foods(item);
                l.Add(foods);
            }
            return l;
        }
        public float priceHis(List<string> list)
        {
            List<Foods> l = new List<Foods>();
            foreach(string data in list)
            {
                string query = "exec get_GiaGoc @MaMH ";
                DataTable dataTable = DataProvider.Instance.ExecuteQuery(query,new object[] { data});
                foreach (DataRow item in dataTable.Rows)
                {
                    Foods foods = new Foods(item);
                    l.Add(foods);
                }
            }
            float rs = 0;
            foreach (Foods data in l)
            {
                rs+=data.PriceHis;
            }    
            return rs;
        }
        public List<Foods> search(string data)
        {
            List<Foods> l = new List<Foods>();
            string query = "exec Search_MatHang @Tim";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query,new object[] { data});
            foreach (DataRow item in dataTable.Rows)
            {
                Foods foods = new Foods(item);
                l.Add(foods);
            }
            return l;
        }
        public float getPrice(string id)
        {
            string query = "exec Load_MatHang_MaMH @MaMH ";
            return (float)Convert.ToDouble(DataProvider.Instance.ExecuteQuery(query, new object[] { id }).Rows[0]["Gia"].ToString());

        }
        public Foods getById(string id)
        {
            string query = "exec Load_MatHang_MaMH @MaMH ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                Foods foods = new Foods(dataRow);
                return foods;
            }
            return null;
        }
        public void add(Foods foods)
        {
            string query = "exec Add_MatHang @MaMH , @TenMH, @Gia , @GiaGoc , @NgaySX , @HanSD ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { foods.Id, foods.Name,foods.Price,foods.PriceHis,foods.ManuafatorDate,foods.OutDate });
        }
        public void update(Foods foods)
        {
            string query = "exec Update_MatHang @MaMH , @TenMH, @Gia , @GiaGoc , @NgaySX , @HanSD ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { foods.Id, foods.Name, foods.Price, foods.PriceHis, foods.ManuafatorDate, foods.OutDate });
        }
        public void delete(string data)
        {
            string query = "exec Delete_MatHang @MaMH  ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { data });
        }
        public bool check(string id)
        {
            string query = "exec Load_MatHang_MaMH @MaMH ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id }).Rows.Count>0;
        }
    }
}
