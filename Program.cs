// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World! This is my first C# Program!");


using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Car Model: ");
        string? carModel = Console.ReadLine();

        Console.WriteLine("Enter Plate Number: ");
        string? plateNumber = Console.ReadLine();

        Console.WriteLine("Enter Number of Hours Parked: ");
        int hoursParked = Convert.ToInt32(Console.ReadLine());

        double fee = ParkingFee(hoursParked);

        Console.WriteLine("<================================================>");
        Console.WriteLine($"Car Model: {carModel}");
        Console.WriteLine($"Plate Number: {plateNumber}");
        Console.WriteLine($"Hours Parked: {hoursParked}");
        Console.WriteLine($"Total Parking Fee: NGN {fee}");
    }


    public static double ParkingFee(int hoursParked)
    {
        const double firstHour = 500.00;
        const double subsequentHour = 100.00;

        int extraHours = hoursParked - 1;
        double fee = firstHour + (subsequentHour * extraHours);

        return fee;
    }
}

