using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock
{

    public class ClockTime
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public ClockTime()
        {
            Hour = 0;
            Minute = 0;
            Second = 0;
        }
        public ClockTime(int hour ,int minute , int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        public bool isValid()
        {
            return Hour >= 0 && Minute >= 0 && Second >= 0
                && Hour < 24 && Minute < 60 && Second < 60;
        }

        public  string Tostring()
        {
            return Hour + ":" + Minute + ":" + Second;
        }
    }


    public class AlarmClock
    {

        public event Action<AlarmClock> AlarmEvent;

        public event Action<AlarmClock> TickEvent;

        private bool stop = false;

        public AlarmClock()
        {
            CurrentTime = new ClockTime();
            //为两个事件设置一个内部的处理函数
            TickEvent += c => Console.WriteLine("Tick!");
            AlarmEvent += c => Console.WriteLine("Ding! Ding! Ding!");
        }

        public ClockTime CurrentTime { get; set; }

        public ClockTime AlarmTime { get; set; }

        /// <summary>
        /// 启动时钟，持续运行，直到stop变为false
        /// </summary>
        public void Run()
        {
            Console.WriteLine("The clock started!");
            stop = false;
            while (!stop)
            {
                DateTime now = DateTime.Now;
                CurrentTime = new ClockTime(now.Hour, now.Minute, now.Second);
                TickEvent(this);
                if (AlarmTime.Equals(CurrentTime)) AlarmEvent(this);
                Thread.Sleep(1000);
            }
            Console.WriteLine("The clock stopped!");
        }

        public void Stop()
        {
            this.stop = true;
        }
    }


    class MainClass
    {

        static void Main(string[] args)
        {
             AlarmClock clock = new AlarmClock(); //时钟
             clock.AlarmTime = new ClockTime(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second + 5);
             clock.AlarmEvent += PlayMusic;
             int sum = 0;
             clock.TickEvent += (c => sum = sum + 1);
             new Thread(clock.Run).Start(); 
             Console.WriteLine("press any key to stop.");
             Console.ReadKey();
             clock.Stop();
             Console.WriteLine($"Sum= {sum}");

        }

        private static void Count(AlarmClock clock, ref int sum)
        {
            sum = sum + 1;
        }

        public static void PlayMusic(AlarmClock clock)
        {
            ClockTime time = clock.CurrentTime;
            Console.WriteLine($"Alarm Event: {time.Hour}:{time.Minute}:{time.Second}");
            Console.WriteLine("Playing music....");
        }
    }
}
