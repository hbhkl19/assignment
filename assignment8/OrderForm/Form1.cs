using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class Form1 : Form
    {
        private OrderService orderService = new OrderService();
        public Form1()
        {
            InitializeComponent();
        }

        //删除
        private void button2_Click(object sender, EventArgs e)
        {
            string orderNum = textBox1.Text;
            if (orderNum.Length == 0)
            {
                OrderBindingSource.DataSource = orderService.Orders;
                OrderBindingSource.ResetBindings(false);
            }
            orderService.RemoveOrder(orderNum);
            OrderBindingSource.DataSource = orderService.Orders;
            OrderBindingSource.ResetBindings(false);
        }
        //更新
        private void button4_Click(object sender, EventArgs e)
        {
            string orderNum = textBox1.Text;
            if (orderNum.Length == 0)
            {
                OrderBindingSource.DataSource = orderService.Orders;
                OrderBindingSource.ResetBindings(false);
            }
            UpdateForm form = new UpdateForm();
            
            Order newOrder = orderService.GetOrder(textBox1.Text);
            form.Button3Clicked += () =>
            {
                newOrder.Details = new List<OrderDetail>();
                newOrder.Customer = Customer.GetCustomerByName(form._CustomerName);
            };
            form.Button1Clicked += () =>
            {
                Product product = Product.GetProductByName(form._ProductName);
                OrderDetail orderDetail = new OrderDetail()
                {
                    Product = product,
                    Quantity = form.Quantity
                };
                newOrder.AddDetail(orderDetail);
            };
            form.Button2Clicked += () =>
            {
                orderService.UpdateOrder(newOrder);
                OrderBindingSource.DataSource = orderService.Orders;
                OrderBindingSource.ResetBindings(false);
                form.Close();
            };
            form.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrderBindingSource.DataSource = orderService.Orders;
        }

        //查询
        private void button3_Click(object sender, EventArgs e)
        {
            string orderNum = textBox1.Text;
            if(orderNum.Length==0)
            {
                OrderBindingSource.DataSource = orderService.Orders;
                OrderBindingSource.ResetBindings(false);
            }
            Order order = orderService.GetOrder(orderNum);
            if(order!=null)
            {
                OrderBindingSource.DataSource = order;
                OrderBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("订单不存在");
            }
        }

        //添加
        private void button1_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();
            AddForm form = new AddForm();
            form.Button1Clicked += () =>
            {
                newOrder.Customer = Customer.GetCustomerByName(form._CustomerName);
            };
            form.Button2Clicked += () =>
            {
                Product product = Product.GetProductByName(form._ProductName);
                OrderDetail orderDetail = new OrderDetail()
                {
                    Product = product,
                    Quantity = form.Quantity
                };
                newOrder.AddDetail(orderDetail);
            };
            form.Button3Clicked += () =>
            {
                orderService.AddOrder(newOrder);
                OrderBindingSource.DataSource = orderService.Orders;
                OrderBindingSource.ResetBindings(false);
                form.Close();
            };
            form.ShowDialog();
        }
    }
}
