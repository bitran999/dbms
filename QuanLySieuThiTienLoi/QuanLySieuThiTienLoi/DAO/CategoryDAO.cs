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
        public List<Category> getListCategory()
        {
            List<Category> l = new List<Category>();
            string query = "exec  Load_KhoHang";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                Category SupBill = new Category(item);
                l.Add(SupBill);
            }
            return l;
        }
        public void add(Category category)
        {
            string query = "";
            if (category.Count == 0)
            {
                query = "exec  Add_KhoHang @MaMH";
                DataProvider.Instance.ExecuteQuery(query,new object[] { category.Id});
            }
            else
            {
                query = "exec  Add_KhoHang_All @MaMH , @SoLuong";
                DataProvider.Instance.ExecuteQuery(query, new object[] { category.Id,category.Count });
            }
        }
        public void update(Category category)
        {
            string query = "exec  Update_SoLuongMH @MaMH , @SoLuong";
            DataProvider.Instance.ExecuteQuery(query, new object[] { category.Id, category.Count });
        }
        public void delete(string data)
        {
            string query = "exec   Delete_KhoHang @MaMH ";
            DataProvider.Instance.ExecuteQuery(query, new object[] {data });
        }
        public List<Category> search(string data)
        {
            List<Category> l = new List<Category>();
            string query = "exec  Search_KhoHang @Tim";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query,new object[] { data});
            foreach (DataRow item in dataTable.Rows)
            {
                Category SupBill = new Category(item);
                l.Add(SupBill);
            }
            return l;
        }
        public bool checkFoodInCategory(string id)
        {
            string query = "select * from KHOHANG where MaMH=@MaMH";
             return DataProvider.Instance.ExecuteQuery(query, new object[] { id }).Rows.Count>0;
        }
        public List<Category> listOF()
        {
            List<Category> l = new List<Category>();
            string query = "exec   Load_MatHang_HetHan";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                Category category = new Category(item);
                l.Add(category);
            }
            return l;
        }
        public List<Category> listNOF()
        {
            List<Category> l = new List<Category>();
            string query = "exec  Load_MatHang_ChuaHetHSD";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                Category category = new Category(item);
                l.Add(category);
            }
            return l;
        }
    }
}
