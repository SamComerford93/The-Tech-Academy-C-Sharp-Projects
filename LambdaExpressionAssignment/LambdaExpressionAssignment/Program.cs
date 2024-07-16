using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of 10 employees
            List<Employee> staff = new List<Employee>()
            {
                new Employee() { Id = 01, FirstName = "Richard", LastName = "Williams" },
                new Employee() { Id = 02, FirstName = "Joe", LastName = "Smith" },
                new Employee() { Id = 03, FirstName = "Angela", LastName = "Jones" },
                new Employee() { Id = 04, FirstName = "Ryan", LastName = "Blake" },
                new Employee() { Id = 05, FirstName = "Mary", LastName = "Anne" },
                new Employee() { Id = 06, FirstName = "Victoria", LastName = "Flower" },
                new Employee() { Id = 07, FirstName = "Joe", LastName = "Palmer" },
                new Employee() { Id = 08, FirstName = "Lauren", LastName = "Clark" },
                new Employee() { Id = 09, FirstName = "James", LastName = "Platt" },
                new Employee() { Id = 10, FirstName = "Helen", LastName = "Johnson" }
            };

            // Using a foreach loop create a new list of all employees with first name "Joe"
            List<Employee> joes = new List<Employee>();
            foreach (Employee emp in staff)
            {
                if (emp.FirstName == "Joe")
                {
                    joes.Add(emp);
                }
            }

            // Perform the same action again with a lambda expression
            List<Employee> joes2 = staff.Where(x => x.FirstName == "Joe").ToList();

            // Using a lambda expression make a list of all employees with Id number greater than 5
            List<Employee> greaterThan5 = staff.Where(x => x.Id > 5).ToList();
        }
    }
}