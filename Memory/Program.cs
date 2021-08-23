using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{

    public class MyClass:MyClass2,In
    {

    }

    public class MyClass2
    {

    }

    public struct MyStract:In
    {

    }
    public interface In
    {

    }

    class Program
    {
        static void OkValue(int a)
        {
            a = a * 2;
            Console.WriteLine(a);

        }

        static void OkIntRef(ref int a)
        {
            a = a * 2;
            Console.WriteLine(a);
        }

        static void OkReference(int[] b)
        {
            b[0] = 10;

        } 

        static void OkRef(int []b)
        {
            b = null;
            Console.WriteLine(b+" удалили ссылку на массив");
        }

        static void OkRef(ref int[] b)
        {
            b = null;
            Console.WriteLine(b + " удалили ссылку на массив");
        }


        static void Main(string[] args)
        {
            int a = 2;

            int[] b= new int[5];

            
            OkValue(a);                             // структура, значимый тип
            Console.WriteLine(a);

            OkIntRef(ref a);                       // передача по ссылке
            Console.WriteLine(a);

            Console.WriteLine(b[0]);
            OkReference(b);                       
            Console.WriteLine(b[0]);              // ссылочный тип, работа с данными в управляемой куче


            OkRef(b);
            Console.WriteLine(b[0]+ " - массив b");
            OkRef(ref b);
            Console.WriteLine(b[0] + " - массив b");


        }
    }
}
