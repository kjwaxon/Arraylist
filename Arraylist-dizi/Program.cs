using System;
using System.Collections;

namespace Arraylist_dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList kaç variable olucağını veya variable tipini tanımlamamıza gerek yok--
            ArrayList x = new ArrayList();
            x.Add(77);
            x.Add("KAAN");
            x.Add(3.14);
            foreach (var item in x)
                {
                Console.WriteLine(item + ",");
            }
                        Console.ReadKey();
        }


    }
}
