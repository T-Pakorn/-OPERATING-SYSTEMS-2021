// Simple Thread
using System;
using System.Threading;

namespace Myproject
{
    // class Program
    // {
    //     static void TestThread1()
    //     {
    //         int i;
    //         for (i = 0; i < 1000; i++)
    //             Console.WriteLine("Thread# 1 i={0}", i);
    //     }
    //     static void TestThread2()
    //     {
    //         int i;
    //         for (i = 0; i < 1000; i++)
    //             Console.WriteLine("Thread# 2 i={0}", i);
    //     }
    //     static void Main(string[] args)
    //     {
    //         Thread th1 = new Thread(TestThread1);
    //         Thread th2 = new Thread(TestThread2);
    //         th1.Start();
    //         th2.Start();
    //     }
    // }
    // class Program
    // {
    //     static int resource = 10000;
    //     static void TestThread1()
    //     {
    //         resource -= 1;
    //         Console.WriteLine("Thread# 1 i={0}", resource);
    //     }
    //     static void TestThread2()
    //     {
    //         Console.WriteLine("Thread# 2 i={0}", resource);
    //     }
    //     static void Main(string[] args)
    //     {
    //         Thread th1 = new Thread(TestThread1);
    //         Thread th2 = new Thread(TestThread2);
    //         th1.Start();
    //         th2.Start();
    //     }
    // }
    // class Program
    // {
    //     static int resource = 10000;
    //     static void TestThread1()
    //     {
    //         resource = 55555;
    //         Console.WriteLine("Working");
    //     }
    //     static void Main(string[] args)
    //     {
    //         Thread th1 = new Thread(TestThread1);
    //         th1.Start();
    //         Thread.Sleep(5000);
    //         Console.WriteLine("resource={0}", resource);
    //     }
    // }
    // class Program
    // {
    //     static int resource = 10000;
    //     static void TestThread1()
    //     {
    //         int i;
    //         for (i = 0; i < 45555; i++)
    //         {
    //             resource++;
    //             Console.Write(".");
    //         }
    //     }
    //     static void Main(string[] args)
    //     {
    //         Thread th1 = new Thread(TestThread1);
    //         th1.Start();
    //         Thread.Sleep(1000);
    //         Console.WriteLine("resource={0}", resource);
    //     }
    // }
    class Program
    {
        static int resource = 10000;
        static void TestThread1()
        {
            int i;
            for (i = 0; i < 45555; i++)
            {
                resource++;
                Console.Write(".");
            }
        }
        static void Main(string[] args)
        {
            Thread th1 = new Thread(TestThread1);
            th1.Start();
            //Thread.Sleep(20);
            th1.Join();
            Console.WriteLine("resource={0}", resource);
        }
    }
}
