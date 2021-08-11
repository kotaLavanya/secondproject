using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;

namespace EF_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e2 = new Employee { EmployeeId = 108, EmployeeName = "sushil", Salary = 9000, Designation = "Manager" };

            UpdateEmployee(e2);

            //Employee e1 = new Employee { EmployeeId = 201, EmployeeName = "sushil", Salary = 7000, Designation = "TL" };
            //InsertEmployee(e1);

            List<Employee> lst= GetEmployees();

            foreach(var e in lst)
            {
                Console.WriteLine("{0}-{1}-{2}-{3}",e.EmployeeId,e.EmployeeName,e.Salary,e.Designation);
            }
           


            Console.ReadKey();

        }
        public static bool UpdateEmployee(Employee emp)
        {
            EmployeeManagementContext context = new EmployeeManagementContext();
            try
            {
                context.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return true;
            }

        }

        public static List<Employee> GetEmployees()
        {
            EmployeeManagementContext context = new EmployeeManagementContext();
            return context.Employees.ToList();
        }

        public static bool InsertEmployee(Employee emp)
        {
            EmployeeManagementContext context = new EmployeeManagementContext();
            try
            {
                context.Employees.Add(emp);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
           
        }

    }
}
