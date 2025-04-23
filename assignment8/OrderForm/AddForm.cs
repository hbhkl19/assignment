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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        public event Action Button1Clicked;
        public event Action Button2Clicked;
        public event Action Button3Clicked;

        public string _CustomerName => textBox2.Text;
        public string _ProductName => textBox3.Text;
        public int Quantity => Convert.ToInt32(textBox4.Text);
        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void addBt1_Click(object sender, EventArgs e)
        {
            Button1Clicked?.Invoke();
        }

        private void addBt2_Click(object sender, EventArgs e)
        {
            Button2Clicked?.Invoke();
        }

        private void addBt3_Click(object sender, EventArgs e)
        {
            Button3Clicked?.Invoke();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
