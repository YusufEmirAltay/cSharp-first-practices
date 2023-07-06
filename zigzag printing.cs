
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("bir metin giriniz");
        string metin=Console.ReadLine();
        string üst = " ";
        string alt = " ";

        for(int i =0; i< metin.Length ;i++)
        {
            if(i%2==0)
            {
                üst = üst + metin[i] + " ";
            }
            else if(i%2==1)
            {
                alt = alt + metin[i] + " ";
            }

        }
        Console.WriteLine(üst);
        Console.WriteLine(" "+alt);
    }
}