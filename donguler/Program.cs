using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Kodlamaya Giriş için Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Kodlamaya Giriş için Temel Kurs",
                "Java",
                "Python", 
                "C++"};
             

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach  (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
