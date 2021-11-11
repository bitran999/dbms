using QuanLySieuThiTienLoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DAO
{
    class TitleDAO
    {
        private static TitleDAO instance;
        public static TitleDAO Instance
        {
            get { if (instance == null) return instance = new TitleDAO(); return instance; }
            private set { instance = value; }
        }
        private TitleDAO()
        {
        }
        public List<Title> getListTitle()
        {
            List<Title> l = new List<Title>();
            string query = "exec Load_ChucVu";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                Title title = new Title(item);
                l.Add(title);
            }
            return l;
        }
        public void add(Title title)
        {
            string query = "exec Add_ChucVu @MaCV , @Ten , @Luong ";
            DataProvider.Instance.ExecuteQuery(query,new object[] { title.Id,title.Name,title.Salary});
        }
        public void update(Title title)
        {
            string query = "exec Update_ChucVu @MaCV , @Ten , @Luong ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { title.Id, title.Name, title.Salary });
        }
        public void delete(string id)
        {
            string query = "exec Delete_ChucVu @MaCV , @Ten , @Luong ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }
    }
}
