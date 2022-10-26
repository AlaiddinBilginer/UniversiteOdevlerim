using System;

namespace uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 13, z = 42;

            if (23 == 55 && 76 > 45 && 5 < 12)
            {
                Console.WriteLine("Doğru");
            }
            else
            {
                Console.WriteLine("Yanlış"); //Bu blok çalışacaktır. Eğer operatörler &&(ve) değil de ||(veya) olsaydı bu blok çalışmazdı.
            }
            Console.WriteLine("---------------------------------------");

            if (23 >= 23 && 45 != 18)
            {
                Console.WriteLine("Doğru"); //iki ifade de doğru olduğu için bu blok çalışır.
            }
            else
            {
                Console.WriteLine("Yanlış");
            }
            Console.WriteLine("---------------------------------------");

            if (x > y && z == y && z < x)
            {
                Console.WriteLine("Doğru");
            }
            else
            {
                Console.WriteLine("Yanlış"); //İfalerden birisi bile yanlış olursa  bu blok çalışacaktır.
            }
            Console.WriteLine("---------------------------------------");

            if(z > x && y < x)
            {
                Console.WriteLine("Doğru"); //iki ifade doğru olduğundan burası çalışır.
            }
            else
            { 
                Console.WriteLine("Yanlış");
            }
            Console.WriteLine("---------------------------------------");

            if(x != z || y <= z)
            {
                Console.WriteLine("Doğru"); //iki ifade doğru olduğundan burası çalışır.
            }
            else
            { 
                Console.WriteLine("Yanlış");
            }

        } 
    }
}
