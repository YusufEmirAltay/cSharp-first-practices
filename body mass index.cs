internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Kilonuzu giriniz");
        int kilo= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Boyunuzu giriniz(Metre cinsinden nokta ile)");
        double boy= Convert.ToDouble(Console.ReadLine());

        double indeks= kilo/(boy*boy);

        

        if (indeks < 18)
        {
            Console.WriteLine("Zayıf");
        }
        else if (18<indeks && indeks<25)
        {
            Console.WriteLine("İdeal");
        }
        else
        {
            Console.WriteLine("Obez");
        }

        Console.WriteLine(indeks);
    }
}