

internal class Program
{
    private static void Main(string[] args)
    {
        //-----------------------------------------------
        int x = Karsilastir_1(3, 5);
        Console.WriteLine(x);
        Console.WriteLine("----------");

        //-----------------------------------------------
        int y = Karsilastir_2(3, 5);
        Console.WriteLine(y);
        Console.WriteLine("----------");

        //-----------------------------------------------
        var z = KareAl(5);
        double zz = KareAl(z);
        Console.WriteLine(z);
        Console.WriteLine(zz);
        Console.WriteLine("----------");

        //-----------------------------------------------
        SeriToplami(5.521, 15.222, 25.454, 56.46861);
        Console.WriteLine("----------");

        //-----------------------------------------------
        Console.WriteLine("Metodların aşırı yüklenmesi");
        var odenecekMiktar1 = SatisYap(100);
        Console.WriteLine("Ödeme Tutarı : " + odenecekMiktar1 + " TL");

        var odenecekMiktar2 = SatisYap(100, 0.1);
        Console.WriteLine("İndirimli Ödeme Tutarı : {0 : 0.##} TL", odenecekMiktar2);

    }

    /// <summary>
    /// Satış yapan fonksiyon
    /// </summary>
    /// <param name="miktar">Alışveriş tutarı.</param>
    /// <returns>KDV eklenmiş toplam ödenecek tutar.</returns>
    private static double SatisYap(double miktar = 0)
    {
        return miktar * 1.18;
    }

    /// <summary>
    /// Satış yapan fonksiyon
    /// </summary>
    /// <param name="miktar">Alışveriş tutarı.</param>
    /// <param name="indirim">İndirim tutarı</param>
    /// <returns>KDV eklenmiş toplam ödenecek tutar.</returns>
    private static double SatisYap(double miktar, double indirim)
    {
        return miktar * (1.0 - indirim) * 1.18;
    }

    private static void SeriToplami(params double[] seri)
    {
        Console.WriteLine("SeriToplami() metodu çalıştı");
        double toplam = 0;
        foreach (var s in seri)
        {
            toplam += s;
        }

        Console.WriteLine("{0, 5}", toplam);
        Console.WriteLine("{0, 5 : 0.##}", toplam); // Ondaliık hane 2 karakterle sınırlandırıldı
        Console.WriteLine("{0 : 0.##}", toplam); // Ondaliık hane 2 karakterle sınırlandırıldı

    }

    public static int Karsilastir_1(int A, int B)
    {
        Console.WriteLine("Karsilastir_1() çalıştı.");

        if (A > B)
        {
            return A;
        }
        else
        {
            return B;
        }
    }

    public static int Karsilastir_2(int A, int B)
    {
        Console.WriteLine("Karsilastir_2() çalıştı.");
        return A > B ? A : B;
    }

    static double KareAl(double sayi)
    {
        Console.WriteLine("KareAl("+ sayi +") çalıştı.");
        double kare = sayi * sayi;
        return kare;
    }


}