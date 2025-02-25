using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("请输入运算符 (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("请输入第二个数字: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    // 检查除数是否为零
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("错误：除数不能为零！");
                        return; // 结束程序
                    }
                    break;
                default:
                    Console.WriteLine("错误：无效的运算符！");
                    return; // 结束程序
            }

            // 输出计算结果
            Console.WriteLine($"计算结果: {num1} {operation} {num2} = {result}");
        }
    }
}