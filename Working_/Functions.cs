using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Working_.Entyties;

namespace Working_
{
    
    internal class Functions
    {
        //Add
        public void StaffAdd(string Name, string Description)
        {
             var db = new Database();
             db.staffs.Add(new Staff()
            {
                name = Name,
                description = Description
            });
            db.SaveChanges();
            Console.WriteLine("Added");
        }

        public void EmpAdd(string Fname, string Lname, string Email, string Password, int staffId)
        {
            
            var db = new Database();
            db.Employees.Add(new Employee()
            {
                firstname = Fname,
                lastname = Lname,
                email = Email,
                password = Password,
                StaffId = staffId

            });
            db.SaveChanges();
            Console.WriteLine("Added");
        }

        //Update
        public void UpdateUser(int userId, string update)
        {
            var db = new Database();
            var user = db.Employees.FirstOrDefault(emp => emp.Id == userId);
            user.firstname = "Kamoliddin";
            db.Employees.Update(user);
            db.SaveChanges();
        }

        //Get

        public Employee GetUserById(int userId)
        {
            var db = new Database();
            var employee = db.Employees.FirstOrDefault(emp => emp.Id == userId);
            if (employee == null)
                return null;

            return new Employee()
            {
                Id = employee.Id,
                firstname = employee.firstname,
                lastname = employee.lastname,
                email = employee.email,
                password = employee.password,
                StaffId = employee.StaffId
            };
        }

        //Delete

        public void DeleteUserById(int id)
        {
             var db = new Database();
            var employee = db.Employees.FirstOrDefault(emp => emp.Id == id);
            db.Employees.Remove(employee);

            if (db.SaveChanges() == 0)
                Console.WriteLine("Bunda user yuq");
            else
                Console.WriteLine("deleted");
        }
    }
}
