using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, generic!");
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(13d, 02d, 10d));
    
        Console.WriteLine("Hello, World!");
        SimpleDataBase<double> data = new SimpleDataBase<double>();

        for(int inputSize = 3; inputSize > 0; inputSize--)
        {
            double input = Convert.ToDouble(Console.ReadLine());
            data.AddNewData(input);
        }
        data.PrintAllData();
    }
}

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        return (dynamic)angka1 + (dynamic)angka2 + (dynamic)angka3;
    }
}
class SimpleDataBase<T>
{
    private List<T> storeData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storeData = new List<T> { };
        this.inputDates = new List<DateTime> { };
    }
    public void AddNewData(T data)
    {
        this.storeData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        for (int index = 0; index < storeData.Count; index++)
        {
            Console.WriteLine("Data 1 berisi: " + storeData[index] + ", yang disimpan pada waktu " + inputDates[index]);
        }
    }
}