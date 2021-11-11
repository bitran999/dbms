using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DTO
{
    class Title
    {
        private string id;
        private string name;
        private float salary;

        public Title()
        {
        }
        public Title(DataRow dataRow)
        {
            this.id = dataRow["MaChucVu"].ToString();
            this.name = dataRow["TenChucVu"].ToString();
            this.salary =(float)Convert.ToDouble(dataRow["Luong"].ToString());
        }
        public Title(string id, string name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Salary { get => salary; set => salary = value; }
    }
}
