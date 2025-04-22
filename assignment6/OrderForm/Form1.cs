using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSource;

namespace OrderForm
{

    public partial class Form1 : Form
    {
        private OrderService orderService = new OrderService();

        public Form1()
        {
            InitializeComponent();
            Order o = new Order()
            {
                orderNumber = 1234,
                client = new Client()
                { Id = 1111, Name = "lisa" }
            };
            OrderDetails d = new OrderDetails()
            { ProductName = "milk", Price = 5, Quantity = 8 };
            o.AddDetail(d);
            orderService.AddOrder(o);

            Order o1 = new Order()
            {
                orderNumber = 5678,
                client = new Client()
                { Id = 2222, Name = "tom" }
            };
            OrderDetails d1 = new OrderDetails()
            { ProductName = "egg", Price = 1, Quantity = 80 };
            o1.AddDetail(d1);
            orderService.AddOrder(o1);
            orderBindingSource.DataSource = orderService.QueryAll().ToList();
            orderBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBt_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();

            Order newOrder = new Order();
            addForm.Button1Clicked += () =>
            {
                int oNum = Convert.ToInt32(addForm.TextOfBox1);
                newOrder.orderNumber = oNum;
                Client c = new Client();
                int cId = Convert.ToInt32(addForm.TextOfBox2);
                c.Id = cId;
                c.Name = addForm.TextOfBox6;
                newOrder.client = c;
            };

            addForm.Button2Clicked += () =>
            {
                OrderDetails oDetail = new OrderDetails();
                oDetail.ProductName = addForm.TextOfBox3;
                oDetail.Price = Convert.ToDecimal(addForm.TextOfBox4);
                oDetail.Quantity = Convert.ToInt32(addForm.TextOfBox5);
                newOrder.AddDetail(oDetail);
            };

            addForm.Button3Clicked += () =>
            {
                orderService.AddOrder(newOrder);
                orderBindingSource.DataSource = orderService.QueryAll();
                orderBindingSource.ResetBindings(false);
            };
            addForm.ShowDialog();
        }

        private void findBt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                orderBindingSource.DataSource = orderService.QueryAll().ToList();
                return;
            }
            int oNum = Convert.ToInt32(textBox1.Text);
            orderBindingSource.DataSource = orderService.QueryByNumber(oNum).ToList();
            orderBindingSource.ResetBindings(false);

        }

        private void removeBt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                orderBindingSource.DataSource = orderService.QueryAll().ToList();
                return;
            }
            int oNum = Convert.ToInt32(textBox1.Text);
            orderService.RemoveOrder(oNum);
            orderBindingSource.DataSource = orderService.QueryAll().ToList();
            orderBindingSource.ResetBindings(false);
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                orderBindingSource.DataSource = orderService.QueryAll().ToList();
                return;
            }
            int oNum = Convert.ToInt32(textBox1.Text);
            Order newOrder = new Order();
            newOrder.orderNumber = oNum;
            ModifyForm modifyForm = new ModifyForm();

            modifyForm.Button1Clicked += () =>
            {
                Client c = new Client();
                c.Id = Convert.ToInt32(modifyForm.TextOfBox1);
                c.Name = modifyForm.TextOfBox2;
                newOrder.client = c;
            };
            modifyForm.Button2Clicked += () =>
            {
                OrderDetails orderDetails = new OrderDetails();
                orderDetails.ProductName = modifyForm.TextOfBox3;
                orderDetails.Price = Convert.ToDecimal(modifyForm.TextOfBox4);
                orderDetails.Quantity = Convert.ToInt32(modifyForm.TextOfBox5);
                newOrder.AddDetail(orderDetails);
            };

            modifyForm.Button3Clicked += () =>
            {
                orderService.UpdateOrder(newOrder);
                orderBindingSource.DataSource = orderService.QueryAll().ToList();
                orderBindingSource.ResetBindings(false);
            };

            modifyForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
