// See https://aka.ms/new-console-template for more information
using OOPConcepts.Logic;
using System.ComponentModel.DataAnnotations;

//try
//{
//    var date = new Date() { Year = 2050, Month = 09, Day = 12 };
//    var date1 = new Date() { Year = 1800, Month = 12, Day = 30 };
//    Console.WriteLine($"{date}");
//    Console.WriteLine($"{date1}");
//}
//catch (Exception ex)
//{

//    Console.WriteLine($"Error: {ex.Message}");
//}
//try
//{
//	var emplyoeee1 = new SalaryEmployee
//	{
//		Id = 1010,
//		BornDate = new(1980, 07, 14),
//		HireDate = new(2021, 09, 1),
//		FirstName = "john",
//		LastName = "brait",
//		isActive = true,
//		Salary = 1050000,

//	};
//    var emplyoeee2 = new HourlyEmployee
//    { 
//        Id = 1020,
//        BornDate = new(1983, 07, 14),
//        HireDate = new(2021, 09, 1),
//        FirstName = "john",
//        LastName = "brait",
//        isActive = true,
//        WorkingHours = 123.5f,
//        HourValue=120000,

//    };

//var emplyoeee3 = new CommissionEmployee
//{
//    Id = 1020,
//    BornDate = new(1983, 07, 14),
//    HireDate = new(2021, 09, 1),
//    FirstName = "john",
//    LastName = "brait",
//    isActive = true,
//    CommissionPercentage = 123.5f,
//    Sales = 120000,

//};
//    var emplyoeee4 = new BaseCommissionEmployee
//    {
//        Id = 1020,
//        BornDate = new(1983, 07, 14),
//        HireDate = new(2021, 09, 1),
//        FirstName = "john",
//        LastName = "brait",
//        isActive = true,
//        CommissionPercentage = 123.5f,
//        Sales = 120000,
//        Salary=600000,

//    };

//    Employee[] employees = new Employee[] { emplyoeee1, emplyoeee2, emplyoeee3, emplyoeee4 };
//    decimal payRoll = 0;
//    foreach (var item in employees)
//    {
//        Console.WriteLine(item);
//        payRoll += item.GetValueToPay();
//    }
//    Console.WriteLine("$.....================");
//    Console.WriteLine($"$Total Payment  ..==={payRoll}");

//    Invoice invoice1 = new Invoice
//    {
//        Id = 1010,
//        Description="test1",
//        Quantity=10,
//        Price=20,
//    };
//    Invoice invoice2 = new Invoice
//    {
//        Id = 1020,
//        Description = "test2",
//        Quantity = 10,
//        Price = 20,
//    };
//    Invoice invoice3 = new Invoice
//    {
//        Id = 1030,
//        Description = "test3",
//        Quantity = 10,
//        Price = 20,
//    };
//    Invoice invoice4 = new Invoice
//    {
//        Id = 1040,
//        Description = "test4",
//        Quantity = 10,
//        Price = 20,
//    };
//    Invoice[] invoices= new Invoice[] { invoice1, invoice2, invoice3, invoice4 };
//    decimal TotalInvoice = 0;
//    foreach (var item in invoices) 
//    { 
//        Console.WriteLine(item);
//        TotalInvoice += item.GetValuetoPay();
//    }
//    Console.WriteLine("$.....================");
//    Console.WriteLine($"$TotalInvoice  ..==={TotalInvoice}");
//}
//catch (Exception ex)
//{

//    Console.WriteLine($"Error: {ex.Message}");
//}
//------Array---------------
//MyArray array = new(10);
//unsorted array
//array.Fill(1, 10);
//Console.WriteLine("unsorted array");
//Console.WriteLine(array);

//sorted Array 

//array.Sort();
//Console.WriteLine("Sorted array");
//Console.WriteLine(array);

//------End Array --------
//---insert in array------
try
{
	Console.WriteLine("Hello Array");
    MyArray array = new(50);
	array.Fill();	
	Console.WriteLine(array);

	Console.WriteLine("odd number");
    var odds= array.GetOdds();
    Console.WriteLine(odds);

    Console.WriteLine("Prime number");
    var Prime = array.IsPrime();
    Console.WriteLine(Prime);

    Console.WriteLine("Not Repeated");
    var NonRepeated = array.GetNonRepeated();
    Console.WriteLine(NonRepeated);

    Console.WriteLine("Most Repeated");
    var MostRepeated = array.GetMostRepeated();
    Console.WriteLine(MostRepeated);

}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}