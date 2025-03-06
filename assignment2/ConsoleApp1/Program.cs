using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要运行的作业编号（1/2/3/4）：");
            string jobNumber = Console.ReadLine();
            if(jobNumber == "1")
            {
                Job1();   
            }
            else if (jobNumber == "2")
            {
                Job2();
            }
            else if (jobNumber == "3")
            {
                Job3();
            }
            else if (jobNumber == "4")
            {
                Job4();
            }
            else
            {
                Console.WriteLine("输入的作业编号不正确！");
            }
        }

        static void Job1()
        {
            Console.WriteLine("请输入一个大于等于2的整数：");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                if (num <= 1)
                {
                    Console.WriteLine("输入的数字不合法！");
                    return;
                }
                else
                {
                    List<int> list = new List<int>();
                    if (num % 2 == 0)
                    {
                        list.Add(2);
                    }
                    while (num % 2 == 0)
                    {
                        //list.Add(2);
                        num /= 2;
                    }
                    for (int i = 3; i <= Math.Sqrt(num); i += 2)
                    {
                        if (num % i == 0)
                        {
                            list.Add(i);
                        }
                        while (num % i == 0)
                        {
                            list.Add(i);
                            num /= i;
                        }
                    }
                    if (num > 2)
                    {
                        list.Add(num);
                    }
                    Console.WriteLine("该数的所有质因数为：");
                    foreach (int i in list)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("输入不合法，请重新输入！");
            }
        }
        static void Job2()
        {
            Console.WriteLine("请输入数组的长度：");
            string input = Console.ReadLine();
            if(int.TryParse(input,out int len))
            {
                double[]win= new double[len];
                double sum = 0;
                double max = 0;
                double min = 0;
                Console.WriteLine("请输入数组的元素：");
                for (int i = 0; i < len; i++)
                {
                    win[i] = double.Parse(Console.ReadLine());
                    sum += win[i];
                    if (i == 0)
                    {
                        max = win[i];
                        min = win[i];
                    }
                    else
                    {
                        if (win[i] > max)
                        {
                            max = win[i];
                        }
                        if (win[i] < min)
                        {
                            min = win[i];
                        }
                    }
                }
                double avg = sum / len;
                Console.WriteLine("数组的最大值为：" + max);
                Console.WriteLine("数组的最小值为：" + min);
                Console.WriteLine("数组的平均值为：" + avg);
                Console.WriteLine("数组的和为：" + sum);
            }
            else
            {
                Console.WriteLine("输入的长度不正确！");
            }
        }
        static void Job3()
        {
            Console.WriteLine("2~100之间的所有素数：");
            List<int> list = new List<int>();
            for(int i=2;i<=100;i++)
            {
                if (i % 2 == 0 && i / 2 > 1)
                {
                    continue;
                }
                else if (i % 3 == 0 && i / 3 > 1)
                {
                    continue;
                }
                else if(i%5==0&&i/5>1)
                {
                    continue;
                }
                else
                    list.Add(i);

            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
        static void Job4()
        {
            Console.Write("请输入矩阵的行数：");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("请输入矩阵的列数：");
            int cols = int.Parse(Console.ReadLine());

            // 创建二维数组
            int[,] matrix = new int[rows, cols];

            // 使用嵌套循环逐行逐列输入矩阵数据
            Console.WriteLine("请输入矩阵的元素：");
            for (int i = 0; i < rows; i++) // 外层循环控制行
            {
                for (int j = 0; j < cols; j++) // 内层循环控制列
                {
                    Console.Write($"请输入第 {i + 1} 行第 {j + 1} 列的元素：");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //判断该矩阵是否为托普利茨矩阵
            bool isToeplitz = true;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i, j] != matrix[i + 1, j + 1])
                    {
                        isToeplitz = false;
                        break;
                    }
                }
            }
            Console.WriteLine("该矩阵" + (isToeplitz ? "是" : "不是") + "托普利茨矩阵。");
        }
    }
}