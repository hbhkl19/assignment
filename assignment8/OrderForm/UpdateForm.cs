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
    public partial class UpdateForm : Form
    {
        public string _CustomerName => textBox2.Text;
        public string _ProductName => textBox3.Text;
        public int Quantity => Convert.ToInt32(textBox4.Text);

        public event Action Button1Clicked;
        public event Action Button2Clicked;
        public event Action Button3Clicked;

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void updateBt1_Click(object sender, EventArgs e)
        {
            Button1Clicked?.Invoke();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void updateBt2_Click(object sender, EventArgs e)
        {
            Button2Clicked?.Invoke();
        }

        private void updateBt3_Click(object sender, EventArgs e)
        {
            Button3Clicked?.Invoke();
        }
    }
}
