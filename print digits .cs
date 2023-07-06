internal class Program
{
    private static void Main(string[] args)
    {
        int birler, onlar, yüzler, a;
        Console.WriteLine("3 basamaklı bir sayı giriniz");
        a = int.Parse(Console.ReadLine());
        birler = a % 10;
        onlar = (a / 10) % 10;
        yüzler = a / 100;
        switch (yüzler)
        {
            case 1:
                Console.WriteLine("yüz"); break;
            case 2:
                Console.WriteLine("ikiyüz"); break;
            case 3:
                Console.WriteLine("üçyüz"); break;
            case 4:
                Console.WriteLine("dörtyüz"); break;
            case 5:
                Console.WriteLine("beşyüz"); break;
            case 6:
                Console.WriteLine("altıyüz"); break;
            case 7:
                Console.WriteLine("yediyüz"); break;
            case 8:
                Console.WriteLine("sekizyüz"); break;
            case 9:
                Console.WriteLine("dokuzyüz"); break;
        }
        switch (onlar)
        {
            case 1:
                Console.WriteLine("on"); break;
            case 2:
                Console.WriteLine("yirmi"); break;
            case 3:
                Console.WriteLine("otuz"); break;
            case 4:
                Console.WriteLine("kırk"); break;
            case 5:
                Console.WriteLine("elli"); break;
            case 6:
                Console.WriteLine("altmış"); break;
            case 7:
                Console.WriteLine("yetmiş"); break;
            case 8:
                Console.WriteLine("seksen"); break;
            case 9:
                Console.WriteLine("doksan"); break;
        }
        switch (birler)
        {
            case 1:
                Console.WriteLine("bir"); break;
            case 2:
                Console.WriteLine("iki"); break;
            case 3:
                Console.WriteLine("üç"); break;
            case 4:
                Console.WriteLine("dört"); break;
            case 5:
                Console.WriteLine("beş"); break;
            case 6:
                Console.WriteLine("altı"); break;
            case 7:
                Console.WriteLine("yedi"); break;
            case 8:
                Console.WriteLine("sekiz"); break;
            case 9:
                Console.WriteLine("dokuz"); break;
        }
        Console.ReadLine();
    } 


    


}