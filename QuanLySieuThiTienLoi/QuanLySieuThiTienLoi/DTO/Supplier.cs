using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DTO
{
    class Supplier
    {
        private string id;
        private string name;
        private string address;
        private string contract;
        private string bankId;

        public Supplier()
        {
        }
        public Supplier(DataRow dataRow)
        {
            this.id = dataRow["MaNCC"].ToString();
            this.name = dataRow["TenNCC"].ToString();
            this.address = (dataRow["DiaChi"]).ToString();
            this.contract = (dataRow["SDT"]).ToString();
            this.bankId = (dataRow["STK"]).ToString();
        }
        public Supplier(string id, string name, string address, string contract, string bankId)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.contract = contract;
            this.bankId = bankId;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Contract { get => contract; set => contract = value; }
        public string BankId { get => bankId; set => bankId = value; }
    }
}
