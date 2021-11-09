using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DTO
{
    public class Employee
    {
        private string id;
        private string name;
        private string gender;
        private string dob;
        private string address;
        private string userName;
        private string passWord;
        private string phoneNb;
        private string idTitle;
        private string title;
        private float salary;
        public Employee()
        {

        }

        public Employee(string id, string name, string gender, string dob, string address, string userName, 
            string passWord, string phoneNb, string idTitle, string title, float salary)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.dob = dob;
            this.address = address;
            this.userName = userName;
            this.passWord = passWord;
            this.phoneNb = phoneNb;
            this.idTitle = idTitle;
            this.title = title;
            this.salary = salary;
        }
        public Employee(DataRow dataRow)
        {
            this.id = dataRow["MaNV"].ToString();
            this.name = dataRow["TenNV"].ToString();
            this.gender = dataRow["GioiTinh"].ToString();
            this.dob = dataRow["NgaySinh"].ToString();
            this.address = dataRow["DiaChi"].ToString();;
            this.userName = dataRow["Users"].ToString();
            this.phoneNb = dataRow["SDT"].ToString();
            this.passWord = dataRow["Pass"].ToString();
            this.idTitle = dataRow["MaChucVu"].ToString().Trim();
            this.title = dataRow["TenChucVu"].ToString();
            this.salary =(float)Convert.ToDouble(dataRow["Luong"].ToString());
        }
        public string Id { get => id; set => id = value ; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value ; }
        public string Dob { get => dob; set => dob = value; }
        public string Address { get => address; set => address = value ; }
        public string UserName { get => userName; set => userName = value ; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string PhoneNb { get => phoneNb; set => phoneNb = value; }
        public string IdTitle { get => idTitle; set => idTitle = value; }
        public string Title { get => title; set => title = value ; }
        public float Salary { get => salary; set => salary = value <0 ? 0 : value; }
    }
}
