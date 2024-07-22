using System;

class Program
{
    static void Main()
    {
        int baslangic = 3;
        int bitis = 120;
        int toplam = 0;

        for (int i = baslangic; i < bitis; i += 2)
        {
            toplam += i;
        }

        Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {toplam}");
    }
}