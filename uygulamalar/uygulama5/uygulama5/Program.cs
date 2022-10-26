using System;

namespace uygulama5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                double x1 = ((-b - Math.Sqrt(delta)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("Denklemin İki Kökü Vardır");
                Console.WriteLine("x1 =" + x1);
                Console.WriteLine("x2 =" + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Denklemin Bir Kökü Vardır");
                Console.WriteLine("x =" + x);
            }
            else
            {
                Console.Write("Sanal Kök Vardır");
            }
            Console.ReadKey();
        }
    }
}
