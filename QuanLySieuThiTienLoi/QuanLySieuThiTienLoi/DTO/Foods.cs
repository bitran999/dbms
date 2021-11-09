using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiTienLoi.DTO
{
    class Foods
    {
        private string id;
        private string name;
        private float price;
        private string manuafatorDate;
        private string outDate;
        private int count;
        public Foods()
        {
        }
        public Foods(DataRow dataRow)

        {
            this.id = (string)dataRow["MaMH"];
            this.name = (string)dataRow["TenMH"];
            this.price = (float)Convert.ToDouble(dataRow["Gia"]);
            this.manuafatorDate = (dataRow["NgaySX"]).ToString();
            this.outDate = (dataRow["HanSD"]).ToString();
        }

        public Foods(string id, string name, float price, string manuafatorDate, string outDate, int count)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.manuafatorDate = manuafatorDate;
            this.outDate = outDate;
            this.count = count;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public string ManuafatorDate { get => manuafatorDate; set => manuafatorDate = value; }
        public string OutDate { get => outDate; set => outDate = value; }
        public int Count { get => count; set => count = value; }
    }
}
