using System.Text;
using System.Linq; 
namespace _1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate.Text = "OK";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumber1.Text, out double num1))
            {
                MessageBox.Show("��������Ч�ĵ�һ�����֣�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtNumber2.Text, out double num2))
            {
                MessageBox.Show("��������Ч�ĵڶ������֣�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ��ȡ�����
            string operation = choice.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(operation))
            {
                MessageBox.Show("��ѡ���������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ������
            double result1 ;
            switch (operation)
            {
                case "+":
                    result1 = num1 + num2;
                    break;
                case "-":
                    result1 = num1 - num2;
                    break;
                case "*":
                    result1 = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("��������Ϊ�㣡", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result1 = num1 / num2;
                    break;
                default:
                    MessageBox.Show("��Ч���������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // ��ʾ���
            result.Text = Convert.ToString(result1);
        }
    }
}
