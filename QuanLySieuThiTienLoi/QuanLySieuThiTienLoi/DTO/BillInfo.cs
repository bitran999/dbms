using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DTO
{
    class BillInfo
    {
        private string idBill;
        private string idFood;
        private int count;
        private float value;

        public BillInfo()
        {
        }

        public BillInfo(string idBill, string idFood, int count, float value)
        {
            this.idBill = idBill;
            this.idFood = idFood;
            this.count = count;
            this.value = value;
        }
        public BillInfo(DataRow dataRow)
        {
                this.idBill = dataRow["MaHD"].ToString();
                this.idFood = dataRow["MaMH"].ToString();
                this.count =int.Parse(dataRow["SoLuong"].ToString());
                this.value = float.Parse(dataRow["GiaTriMH"].ToString());
        }

        public string IdBill { get => idBill; set => idBill = value; }
        public string IdFood { get => idFood; set => idFood = value; }
        public int Count { get => count; set => count = value; }
        public float Value { get => value; set => this.value = value; }
    }
}
