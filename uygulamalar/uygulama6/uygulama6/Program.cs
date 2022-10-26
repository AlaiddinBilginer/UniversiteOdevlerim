using System;

namespace uygulama6
{
    class Program
    {
        static void Main(string[] args)
        {


            int derece, radyan, gradyan;
            

            Console.WriteLine("Açı: ");
            derece = Convert.ToInt32(Console.ReadLine());

            radyan = Convert.ToInt32((derece * Math.PI) / 180);
            gradyan = (derece * 200) / 180;

            Console.WriteLine("Radyan = " + radyan);
            Console.WriteLine("Grad = " + gradyan);
            Console.ReadKey();
        }
    }
}
