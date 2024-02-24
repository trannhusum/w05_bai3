using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w05_bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 12, 7, 8, 1, 6, 9 };
            int n=arr.Length;
            arr=deleteArray(arr);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        public static int[] deleteArray(int[] arr)
        {
            Console.Write("Nhap phan tu muon xoa: ");
            int choose=int.Parse(Console.ReadLine());
            if (choose >= arr.Length)
                Console.WriteLine("Khong co phan tu " + choose + " trong mang");
            else
                for (int i = choose; i < arr.Length-1; i++)
                    arr[i] = arr[i + 1];
            int[] err = new int[arr.Length - 1];
            for (int i=0;i<err.Length;i++)
                 err[i] = arr[i];
            return err;
        }
    }
}
