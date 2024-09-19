// See https://aka.ms/new-console-template for more information
using OOPConcepts.Logic;

try
{
    var date = new Date() { Year = 2050, Month = 09, Day = 12 };
    var date1 = new Date() { Year = 1800, Month = 12, Day = 30 };
    Console.WriteLine($"{date}");
    Console.WriteLine($"{date1}");
}
catch (Exception ex)
{

    Console.WriteLine($"Error: {ex.Message}");
}