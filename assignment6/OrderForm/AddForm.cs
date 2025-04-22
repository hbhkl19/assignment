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
        public string TextOfBox1 => addTextBox1.Text;
        public string TextOfBox2 => addTextBox2.Text;
        public string TextOfBox3 => addTextBox3.Text;
        public string TextOfBox4 => addTextBox4.Text;
        public string TextOfBox5 => addTextBox5.Text;
        public string TextOfBox6 => addTextBox6.Text;

        private void addButton1_Click(object sender, EventArgs e)
        {
            Button1Clicked?.Invoke();
            addButton2.Enabled = true;
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            Button2Clicked?.Invoke();
        }

        private void addButton3_Click(object sender, EventArgs e)
        {
            Button3Clicked?.Invoke();
        }

        private void addLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
