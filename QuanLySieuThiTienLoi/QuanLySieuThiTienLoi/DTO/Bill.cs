using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DTO
{
    class Bill
    {
        private string id;
        private string date;
        private string idCustomer;
        private string idEmp;
        private float price;

        public Bill()
        {
        }

        public Bill(string id, string date, string idCustomer, string idEmp, float price)
        {
            this.id = id;
            this.date = date;
            this.idCustomer = idCustomer;
            this.idEmp = idEmp;
            this.price = price;
        }
        public Bill(DataRow dataRow)
        {
            this.id = dataRow["MaHD"].ToString();
            this.date = dataRow["NgayLHD"].ToString();
         
            if (dataRow["MaKH"].ToString() == null)
            {
                this.idCustomer = "";
            }
            else
            {
                this.idCustomer = dataRow["MaKH"].ToString();
            }
            if (dataRow["MaNV"].ToString() == null)
            {
                this.idEmp = "";
            }
            else
            {
                this.idEmp = dataRow["MaNV"].ToString();
            }
            try
            {
                this.price = (float)Convert.ToDouble(dataRow["GiaTri"].ToString());
            }
            catch
            {
                this.price = 0;
            }
        }
        public string Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public string IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string IdEmp { get => idEmp; set => idEmp = value; }
        public float Price { get => price; set => price = value; }
    }
}
