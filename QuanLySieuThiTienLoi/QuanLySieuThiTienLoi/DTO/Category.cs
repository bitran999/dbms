using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DTO
{
    class Category
    {
        private string id;
        private string status;
        private int count;

        public Category()
        {
        }
        public Category(DataRow dataRow)
        {

            this.id = (string)dataRow["MaMH"];
            this.status = (string)dataRow["TrangThai"];
            this.count = Convert.ToInt32(dataRow["SoLuong"]);
        }

        public Category(string id, string status, int count)
        {
            this.id = id;
            this.status = status;
            this.count = count;
        }

        public string Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }
        public int Count { get => count; set => count = value; }
    }
}
