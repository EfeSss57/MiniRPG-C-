using _3._11._25;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)

    {
        Random rnd = new Random();
        Karakter savasci = new Karakter() { Id = 1, Ad = "Savaşçı", Can = 40, Guc = 60 };
        Karakter buyucu = new Karakter() { Id = 2, Ad = "Büyücü", Can = 60, Guc = 70 };
        Karakter okcu = new Karakter() { Id = 3, Ad = "Okçu", Can = 50, Guc = 40 };
        Karakter suikastci = new Karakter() { Id = 4, Ad = "Suikastçi", Can = 70, Guc = 40 };
        Karakter tank = new Karakter() { Id = 5, Ad = "Tank", Can = 100, Guc = 40 };
        Karakter dev = new Karakter() { Id = 6, Ad = "Dev", Can = 100, Guc = 30 };


        List<Karakter> karakterler = new List<Karakter>() { savasci, buyucu,okcu,suikastci,tank,dev };
        Karakter hedef;
        Karakter saldiran;

        while (karakterler.Count > 1)
        {
            do
            {
                hedef = karakterler[rnd.Next(karakterler.Count)];
                saldiran = karakterler[rnd.Next(karakterler.Count)];
            }
            while (hedef == saldiran);
            SecimYazdir();
            string secim = Console.ReadLine().ToLower();
            switch (secim) {
                case "saldır":
                    saldiran.Saldir(hedef);
                    karakterler.RemoveAll(karakterler => karakterler.Can <= 0);
                    break;
                case "durum":
               
                    foreach (var item in karakterler)
                    {
                        item.BilgiYazdir();
                    }
                    break;
                default:
                    Console.WriteLine("Hatalı Yazım Yaptınız Tekrar Deneyin");
                    break;
            }
            if (karakterler.Count == 1) { 
                for (global::System.Int32 i = 0; i < 250; i++)
                {
                    Console.WriteLine($"{karakterler[0].Ad} kazandı!");

                }
            }
        }
    }
    static void SecimYazdir()
    {
        Console.Write("Yapılacak İşlemi Yazınız:(Saldır/Durum)");
    }
}
