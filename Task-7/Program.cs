using System;
using System.Linq;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. HackerRank - Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
            // Then print the respective minimum and maximum values as a single line of two space-separated long integers.
            //  MiniMaxSum()

            // 2.  HackerRank - Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
            // Print the decimal value of each fraction on a new line with  places after the decimal.
            // NegativePositive();

            // 3. You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age.
            // They will only be able to blow out the tallest of the candles. Count how many candles are tallest.
            // Candles();

            // 4. Given a time in -hour AM/PM format, convert it to military (24-hour) time.
            // Note: -12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
            // - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
            //Hour();

            // 5. Its base and height are both equal to n . It is drawn using # symbols and spaces.
            // The last line is not preceded by any spaces. Write a program that prints a staircase of size n.
            // Staircase();

        }

        static void MiniMaxSum()
        {

            int[] arr = new int[5];
            arr[0] = Convert.ToInt32(Console.ReadLine());
            arr[1] = Convert.ToInt32(Console.ReadLine());
            arr[2] = Convert.ToInt32(Console.ReadLine());
            arr[3] = Convert.ToInt32(Console.ReadLine());
            arr[4] = Convert.ToInt32(Console.ReadLine());

            Array.Sort(arr);
            //int ilkMax = arr[0]+arr[1]+arr[2]+arr[3];
            //int sonMax = arr[1]+arr[2]+arr[3]+arr[4];

            int ilkMax = arr.Take(4).Sum();
            int sonMax = arr.Skip(1).Sum();

            Console.WriteLine(ilkMax);
            Console.WriteLine(sonMax);
        }

        static void NegativePositive()
        {

            int[] arr = new int[5];
            arr[0] = Convert.ToInt32(Console.ReadLine());
            arr[1] = Convert.ToInt32(Console.ReadLine());
            arr[2] = Convert.ToInt32(Console.ReadLine());
            arr[3] = Convert.ToInt32(Console.ReadLine());
            arr[4] = Convert.ToInt32(Console.ReadLine());

            decimal pos = 0;
            decimal neg = 0;
            decimal zero = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i]>0)
                {
                    pos = pos+1;
                }
                else if (arr[i]<0)
                {
                    neg = neg+1;
                }
                else
                {
                    zero = zero+1;
                }
            }

            decimal posVal = pos/arr.Length;
            decimal negVal = neg/arr.Length;
            decimal zeroVal = zero/arr.Length;

            Console.WriteLine($"Poitive: {posVal} Negative: {negVal} Zero: {zeroVal}");

        }

        static void Candles()
        {
            Console.WriteLine("Ushaghin yashini qeyd edin");
            int yash = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[yash];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i+1}-ci sham uzunlughunu daxil edin");
                int uzn = Convert.ToInt32(Console.ReadLine());
                arr[i]= uzn;
            }

            int enBoyuk = arr[0];
            int enBoyukSay = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>enBoyuk)
                    enBoyuk = arr[i];
               
            }

            int enBoyukCem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (enBoyuk==arr[i])
                {
                    enBoyukCem++;
                }
            }

            Console.WriteLine($"En boyuk sham: {enBoyuk} sayi: {enBoyukCem} ");
        }

        static void Hour()
        {
            Console.WriteLine("Deyishmek istediyinizi vaxti girin. Diqqet vaxt 'saat:deqiqe PM ve ya AM' shekilinde yazilmalidir. " +
                "Meselen: 04:45 PM");
            string girilenSaat = Console.ReadLine();
            
            
            DateTime military = DateTime.Parse(girilenSaat);
            Console.WriteLine(military.ToString("HH:mm"));
        }

        static void Staircase()
        {

            Console.WriteLine( "Bir reqem daxil edin");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(
                  new String(' ', n - i) +
                   new string('#', i));
            }
        }



    }
}
