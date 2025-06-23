using System;

class Program
{
    // Enum untuk bulan yang memberikan nama yang lebih deskriptif
    enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    static void Main()
    {
        // Array jumlah hari dalam bulan untuk tahun non-kabisat (index sesuai dengan enum - 1)
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        Console.Write("Masukkan bulan (1-12): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int monthNumber) &&
            Enum.IsDefined(typeof(Months), monthNumber))
        {
            Months month = (Months)monthNumber;

            int days = daysInMonth[monthNumber - 1];

            Console.WriteLine($"Jumlah hari dalam bulan {month} adalah {days} hari.");
        }
        else
        {
            Console.WriteLine("Bulan tidak valid. Silakan masukkan angka antara 1 dan 12.");
        }
    }
}

