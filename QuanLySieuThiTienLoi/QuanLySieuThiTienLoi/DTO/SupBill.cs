using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DTO
{
    class SupBill
    {
        private string id;
        private string idSup;
        private string idFood;
        private int count;
        private string date;
        private float value;

        public SupBill()
        {
        }
        public SupBill(DataRow dataRow)

        {
            this.id = dataRow["MaHDN"].ToString();
            this.idSup = dataRow["MaNCC"].ToString();
            this.idFood = dataRow["MaMH"].ToString();
            this.count = Convert.ToInt32(dataRow["SoLuong"].ToString());
            this.date = dataRow["NgayGiao"].ToString();
            this.value =(float)Convert.ToDouble(dataRow["GiaTri"].ToString());
        }
        public SupBill(string id, string idSup, string idFood, int count, string date, float value)
        {
            this.id = id;
            this.idSup = idSup;
            this.idFood = idFood;
            this.count = count;
            this.date = date;
            this.value = value;
        }

        public string Id { get => id; set => id = value; }
        public string IdSup { get => idSup; set => idSup = value; }
        public string IdFood { get => idFood; set => idFood = value; }
        public int Count { get => count; set => count = value; }
        public string Date { get => date; set => date = value; }
        public float Value { get => value; set => this.value = value; }
    }
}

