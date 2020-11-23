using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciZ23
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamArrays();
            ArraysAsParams();
            Console.ReadKey();
        }
        static void ParamArrays()
        {
            int sum = GetSum(2, 12, 22, 32, 42, 52);
            Console.WriteLine("The sum is {0}", sum);
        }
        static int GetSum(params int[] arr)
        {
            int sum = 0;
            foreach(int n in arr)
            {
                sum = sum + n;
            }
            return sum;
        }
        static void ArraysAsParams()
        {
            int[] balance = new int[] { 2, 12, 22, 32, 42, 52 };
            double avg;
            avg = GetAverage(balance, 6);
            Console.WriteLine("Prosecna vrednost je {0}", avg);
        }
        static double GetAverage(int[] arr, int size)
        {
            double avg;
                int sum = 0;
            for(int i =0; i< size; i++)
            {
                sum = sum + arr[i];
            }
            avg = sum / size;
            return avg;

        }
    }
}
