internal class Program
{
    static void Main(string[] args)
    {


        string kurs1 = "yazılım Geiştirme Kampı";
        string kurs2 = "Programlamaya başlangıç için teöel kurs";
        string kurs3 = "java";

        //array - dizi

        string[] kurslar = new string[] { "yazılım Geiştirme Kampı", "Programlamaya başlangıç için teöel kurs",
            "java","python","c#" };


        for (int i = 0; i < kurslar.Length  ; i++)
        {
            Console.WriteLine(kurslar[i]);
        }

        Console.WriteLine("for bitti");

        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }


        Console.WriteLine("sayfa sonu - footer");
    }
}