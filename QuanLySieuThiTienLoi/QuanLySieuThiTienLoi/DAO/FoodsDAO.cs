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
    }
}
