using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            //int n;
            //int m;
            //m = 11;
            //n = 6;


            //if (n % 2 == 0 && m % 2 == 0)
            //{
            //    Console.WriteLine(n + m);
            //}
            //else
            //    Console.ReadLine("tek  ya da cut");


            //3
            //int n = 5;
            //int m = 12;
            //int sum = 0;

            //for(int i = n; i < m; i++)
            //{
            //    if (i % 2 == 0)
            //        sum += i;
            //}
            //Console.WriteLine("n<m deki cut ededlerin cemi=" + sum);
            //Console.ReadLine();


            //1
            //int n;
            //n = 30;

            //if(n%3==0 && n%7==0)
            //{
            //    Console.WriteLine("This number is true");
            //}
            //else
            //{
            //    Console.WriteLine("please check other number");
            //}

            //4
            //int[] arr = { 0, 6, 3, 9, 1, 12, 8 };
            //int sum = 0;

            //for (int i = 0; i<arr.Length; i++)
            //{
            //    if (i % 2 != 0) ;
            //    sum += arr[i];
            //}
            //Console.WriteLine("tek ededlerin cemi");


            //5
            int[] arr = { 5, 8, 2,, 9, 3, 1, 6 };
            int cut = 0;

            for (int i=0; i<arr.Length; i++)
            {
                if (i % 2 == 0)
                    cut++;
            }
            Console.WriteLine("cut ededlerin sayi=" + cut);

            
        }
    }
}
