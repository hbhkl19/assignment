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
                MessageBox.Show("请输入有效的第一个数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtNumber2.Text, out double num2))
            {
                MessageBox.Show("请输入有效的第二个数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 获取运算符
            string operation = choice.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(operation))
            {
                MessageBox.Show("请选择运算符！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 计算结果
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
                        MessageBox.Show("除数不能为零！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result1 = num1 / num2;
                    break;
                default:
                    MessageBox.Show("无效的运算符！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // 显示结果
            result.Text = Convert.ToString(result1);
        }
    }
}
