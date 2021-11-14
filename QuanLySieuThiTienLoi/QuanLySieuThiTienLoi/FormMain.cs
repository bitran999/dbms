using QuanLySieuThiTienLoi.DAO;
using QuanLySieuThiTienLoi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiTienLoi
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            loadListFoods();

        }

        private void ManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EmployeeDAO.Instance.Admin)
            {
                FormManager f = new FormManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfoAccout f = new FormInfoAccout();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustommer f = new FormCustommer();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCustommer f = new FormCustommer();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerDAO.Instance.Search(tbCustomer.Text);
            if (customer == null)
            {
                MessageBox.Show("Không tìm thấy khash hàng, vui lòng thêm khách hàng mới");
            }
            else
            {
                tbIdCustomer.Text = customer.Id;
                tbName.Text = customer.Name;
                tbPhoneNb.Text = customer.PhoneNb;
                tbEmail.Text = customer.Email;
            }
        }
        private void loadListFoods()
        {
            List<Foods> list = FoodsDAO.Instance.getList();
            cmbListFoods.DataSource = list;
            cmbListFoods.DisplayMember = "name";
            countFood("");
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            Foods food = cmbListFoods.SelectedItem as Foods;
            int count = (int)nmFoodsCount.Value;
            food.Count = count;
            Category category = CategoryDAO.Instance.getFood(food.Id);
            int tmp = category.Count;
            nmFoodsCount.Maximum = tmp;
            countFood(tmp.ToString());
            if (count != 0)
            {
                if (count > category.Count)
                {
                    MessageBox.Show("Số lượng lớn hơn hàng trong kho");
                }
                else
                {
                    if (category.Count == 0)
                    {
                        MessageBox.Show("Sản phẩm đã hết hàng");
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem();
                        float sum = food.Count * food.Price;
                        item.Text = food.Id;
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.Name });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (food.Price).ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.Count.ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = sum.ToString() });
                        foreach (ListViewItem item1 in listView.Items)
                        {
                            if (item1.Text == item.Text)
                            {
                                listView.Items.Remove(item1);
                            }
                        }
                        listView.Items.Add(item);
                        tmp -= count;
                        countFood(tmp.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Số sản phẩm phải lớn hơn 0");
            }
            nmFoodsCount.Value = 0;
            moneyPay();
        }
        private void btnDeleteFoods_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item1 in listView.Items)
            {
                if (item1.Checked)
                {
                    listView.Items.Remove(item1);
                }
            }
            countFood("");
        }
        private void countFood(string data)
        {
            if (data == "")
            {
                Foods food = cmbListFoods.SelectedItem as Foods;
                Category category = CategoryDAO.Instance.getFood(food.Id);
                tbCountFood.Text = category.Count.ToString();
            }
            else
            {
                tbCountFood.Text = data;
            }
        }
        private void cmbListFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            countFood("");
        }
        private void moneyPay()
        {
            float sum = 0;
            for (int i = 0; i < listView.Items.Count; i++)
            {
                string a = listView.Items[i].SubItems[4].Text;
                float b = float.Parse(a);
                sum += b;
            }
            tbTotal.Text = sum.ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
                BillDAO.Instance.create(tbIdCustomer.Text);
                string idBill = BillDAO.Instance.getId();
                for (int i = 0; i < listView.Items.Count; i++)
                {
                    string idFood = listView.Items[i].Text;
                    string countStr = listView.Items[i].SubItems[3].Text;
                    int count = int.Parse(countStr);
                    BillInfoDAO.Instance.add(idBill, idFood, count);
                }
            MessageBox.Show("Hoàn thành!");
            reload();
        }
        private void reload()
        {
            listView.Items.Clear();
        }
    }
}
