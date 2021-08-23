using System;

namespace MemoryNET5
{
    class Program
    {
        static ref int Ok(int[] num)
        {
            return ref num[0];
        }

        static void Main(string[] args)
        {
            int[] arr = { 7, 8, 9 };


            int a = arr[0];
            a = 77;
            Console.WriteLine("Поле а: " +a+ " массив arr[0]: "+arr[0]);

            ref int aa =ref arr[0];
            aa = 77;
            Console.WriteLine("Поле аa " + aa + " массив arr[0]: " + arr[0]);

            int b =  Ok(arr);
            b = 88;
            Console.WriteLine("Поле аaa " + b + " массив arr[0]: " + arr[0]);

            ref int bb =ref Ok(arr);
            bb = 88;
            Console.WriteLine("Поле аaa " + bb + " массив arr[0]: " + arr[0]);

        }
    }
}
