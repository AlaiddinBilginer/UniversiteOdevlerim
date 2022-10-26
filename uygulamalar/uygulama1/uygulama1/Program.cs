using System; 

namespace uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi;

            sayi = 48 / 6 / 4; //soldan sağa doğru işlem yapar, sonuç 2 çıkacaktır.
            Console.WriteLine(sayi);

            sayi = 24 / 3 * 2; //soldan sağa doğru işlem yapar, sonuç 16 çıkar. Eğer 3*2 yi paranteze alsaydık sonuç 4 çıkacaktı.
            Console.WriteLine(sayi);

            sayi = 2 * 2 + 5 - 1 + 4;
            Console.WriteLine(sayi);

            sayi = (7 + 4) * 2 - 1 + 8 / 2; //ilk olarak parantez içerisindeki işlemler yapılıp 2 ile çarpılır. Daha sonra bölme işlemi yapılır.
            Console.WriteLine(sayi);

            sayi = (5 - 1) * 2 - 1 + (double)7 * 7 / 2;
            Console.WriteLine(sayi);
            Console.Read();
        }
    }
}
