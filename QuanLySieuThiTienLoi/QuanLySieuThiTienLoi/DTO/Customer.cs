using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DTO
{
    class Customer
    {
        private string id;
        private string name;
        private string gender;
        private string dob;
        private string address;
        private string phoneNb;
        private string email;

        public Customer()
        {
        }

        public Customer(string id, string name, string gender, string dob, string address, string phoneNb, string email)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.dob = dob;
            this.address = address;
            this.phoneNb = phoneNb;
            this.email = email;
        }
        
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNb { get => phoneNb; set => phoneNb = value; }
        public string Email { get => email; set => email = value; }
    }
}
