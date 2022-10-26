using System;

namespace uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 15;
            int sayi2 = 3;

            if(sayi1 % sayi2 == 0)
            {
                Console.WriteLine(sayi1 + " sayısı " + sayi2 + " sayısına tam bölünür.");
            }
            else
            {
                Console.WriteLine(sayi1 + " sayısı " + sayi2 + " sayısına tam bölünmez.");
            }
        }
    }
}
