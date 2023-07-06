
    class MyProgram
{
    private static void MyMain(string[] args)
    {
        
        int hak = 3;
        while(true) //Döngüye girmesi için while'ın iiçne true yazdım 
        {
            Console.WriteLine("Kullanıcı adınıızı giriniz");
            string kullaniciadi = Console.ReadLine();

            Console.WriteLine("Şifrenizi giriniz");
            string sifre=Console.ReadLine();

            
           if (kullaniciadi == "ysufemrlty" && sifre == "411304")
            { 
            Console.WriteLine("Başarılı bir şekilde giriş yaptınız");
                break;

            }

             if(kullaniciadi =="ysufemrlty" && sifre != "411304")
            {
                Console.WriteLine("Şifreniz yanlıştır");
                hak=hak-1;
                

            }

            if (kullaniciadi != "ysufemrlty" && sifre == "411304")
            {

                Console.WriteLine("Kullanıcı adınız yanlıştır");
                hak = hak - 1;


            }
            if(kullaniciadi != "ysufemrlty" && sifre != "411304")
            {
                Console.WriteLine("Kullanıcı adı ve şifreniz yanlıştır");
                hak = hak - 1;

                if (hak == 0)
                {
                    Console.WriteLine("Deneme hakkınız bitmiştir");

                    break;
                }
            }


        }

        Console.ReadLine();


    }


    }