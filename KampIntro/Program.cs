internal class Program
{
    private static void Main(string[] args)
    {
        string katogoriEtiketi = "Katagoriler";
        int ogrenciayisi = 32000;
        double faizOranı = 1.45;
        bool sistemeGrisYapmısMı = true;
        double dolarDun = 7.55;
        double dolarBugun = 7.45;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("Azalış Butonu");
        }
        else if (dolarDun<dolarBugun)
        {
            Console.WriteLine("Artış butonu");
            
        }
        else
        {
            Console.WriteLine("değişmedi butonu");
        }


        if (sistemeGrisYapmısMı== true)
        {
            Console.WriteLine("Kullanıcı ayarları butonu");
        }
        else
        {
            Console.WriteLine("Giriş yap butonu");
        }




        Console.WriteLine (katogoriEtiketi);
        


    }
}