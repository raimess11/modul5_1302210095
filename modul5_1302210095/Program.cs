using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, generic!");
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(13d, 02d, 10d));
    }
}

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        return (dynamic)angka1 + (dynamic)angka2 + (dynamic)angka3;
    }
}