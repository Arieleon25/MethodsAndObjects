using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee= new Employee();

            employee.FirstName = "Sample";
            Console.WriteLine(employee.FirstName);
            employee.LastName = "Student";
            Console.WriteLine(employee.LastName);
            employee.SayName();

            
            Console.ReadLine();
        }
    }
}
