
internal class Program
{
    private static void Main(string[] args)
    {
        int sayı = 0;
        int tahmin = 0;
        int denemehakkı = 0;
        bool donustuMu = false;
        Random r = new Random();
        sayı = r.Next(100);
        do
        {
            while (donustuMu!=true)
            {
                Console.WriteLine("tahmin giriniz");
                donustuMu = int.TryParse(Console.ReadLine(), out tahmin);
            }
            if(tahmin>sayı)
            {
                Console.WriteLine("daha küçük bir sayı giriniz");
                denemehakkı++;
            }
            else if(tahmin<sayı)
            {
                Console.WriteLine("daha büyük bir sayı giriniz");
                denemehakkı++;
            }
            else
            {
                Console.WriteLine("tebrikler, " + denemehakkı + ". seferde bildiniz");
            }
            donustuMu = false;
        }
        while (sayı!=tahmin&&denemehakkı<5);
        if (denemehakkı == 5) 
        Console.WriteLine("deneme hakkınız bitti");
        Console.ReadKey();
    }
}