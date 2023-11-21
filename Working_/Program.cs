using Microsoft.EntityFrameworkCore;
using Working_;
using Working_.Entyties;


var db = new Database();
var func = new Functions();  
func.StaffAdd("Alger", "O'quv bulimi");
func.EmpAdd("Akbar", "Akhunov", "okhunovakbar565@gmail.com", "1234", 3);
var stafs = db.staffs.Include(x => x.Employees).ToList();
foreach (var item in stafs)
{
    Console.WriteLine(item.name);
    foreach (var emp in item.Employees)

    {
        Console.WriteLine(emp.firstname);
    }
}

