using QuanLySieuThiTienLoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DAO
{
    class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get { if (instance == null) return instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }
        private CategoryDAO()
        {
        }
        public Category getFood(string id)
        {
            string query = "exec Check_MatHang_Category @MaMH ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query,new object[]{id});
            Category category = new Category();
            category.Id = id;
            category.Status = dataTable.Rows[0]["TrangThai"].ToString();
            category.Count = (int)dataTable.Rows[0]["SoLuong"];
            return category;
        }
    }
}
