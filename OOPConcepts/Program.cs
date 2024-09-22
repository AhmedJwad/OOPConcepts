// See https://aka.ms/new-console-template for more information
using OOPConcepts.Logic;

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
try
{
	var emplyoeee1 = new SalaryEmployee
	{
		Id = 1010,
		BornDate = new(1980, 07, 14),
		HireDate = new(2021, 09, 1),
		FirstName = "john",
		LastName = "brait",
		isActive = true,
		Salary = 1050000,

	};
    var emplyoeee2 = new HourlyEmployee
    { 
        Id = 1020,
        BornDate = new(1983, 07, 14),
        HireDate = new(2021, 09, 1),
        FirstName = "john",
        LastName = "brait",
        isActive = true,
        WorkingHours = 123.5f,
        HourValue=120000,

    };

var emplyoeee3 = new CommissionEmployee
{
    Id = 1020,
    BornDate = new(1983, 07, 14),
    HireDate = new(2021, 09, 1),
    FirstName = "john",
    LastName = "brait",
    isActive = true,
    CommissionPercentage = 123.5f,
    Sales = 120000,

};
    var emplyoeee4 = new BaseCommissionEmployee
    {
        Id = 1020,
        BornDate = new(1983, 07, 14),
        HireDate = new(2021, 09, 1),
        FirstName = "john",
        LastName = "brait",
        isActive = true,
        CommissionPercentage = 123.5f,
        Sales = 120000,
        Salary=600000,

    };
    Console.WriteLine(emplyoeee1);
    Console.WriteLine(emplyoeee2);
    Console.WriteLine(emplyoeee3);
    Console.WriteLine(emplyoeee4);
}
catch (Exception ex)
{

    Console.WriteLine($"Error: {ex.Message}");
}