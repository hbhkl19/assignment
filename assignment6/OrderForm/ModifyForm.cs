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
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
        }

        public string TextOfBox1 => modifyTextbox1.Text;
        public string TextOfBox2 => modifyTextbox2.Text;
        public string TextOfBox3 => modifyTextbox3.Text;
        public string TextOfBox4 => modifyTextbox4.Text;
        public string TextOfBox5 => modifyTextbox5.Text;

        public event Action Button1Clicked;
        public event Action Button2Clicked;
        public event Action Button3Clicked;

        private void modifyButton3_Click(object sender, EventArgs e)
        {
            Button3Clicked?.Invoke();
        }

        private void modifyButton1_Click(object sender, EventArgs e)
        {
            Button1Clicked?.Invoke();
            modifyButton2.Enabled = true;
        }

        private void modifyButton2_Click(object sender, EventArgs e)
        {
            Button2Clicked?.Invoke();
        }
    }
}
