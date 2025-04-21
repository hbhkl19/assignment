using System;

namespace GenericList
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            head = tail = null;
        }

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> current = head;
            for(; current != null; current = current.Next)
            {
                action(current.Value);
            }
        }

        public double Sum(Func<T, double> selector)
        {
            double sum = 0;
            Node<T> current = head;
            for(; current != null; current = current.Next)
            {
                sum += selector(current.Value);
            }
            return sum;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //生成列表
            Random random = new Random();
            GenericList<int> list = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(1, 100));
            }

            //打印列表内容
            Console.WriteLine("List contents:");
            list.ForEach(value => Console.WriteLine(value));

            //求和
            double sum = list.Sum(value => value);
            Console.WriteLine($"Sum of list values: {sum}");

            //求最小值和最大值
            double min = 1000, max = -1;
            list.ForEach(value =>
            {
                if (value < min) min = value;
                if (value > max) max = value;
            });
            Console.WriteLine($"Min value: {min}");
            Console.WriteLine($"Max value: {max}");

        }
    }
}