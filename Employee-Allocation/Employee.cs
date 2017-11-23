using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Employee_Allocation
{
    class Employee : Person, IAcceptResources
    {
        public int Effectivity { get; set; }
        public Task Task { get; set; }

        public Employee()
        {
            Task = new Task();
        }

        public dynamic OpenFile(string path)
        {
            var employeesFile = File.ReadAllLines(@"C:\Users\randj\Dropbox\NET\Employee-Allocation\Employee-Allocation\Employee-Allocation\Files\employees.csv").Select(e => e.Split(','));

            List<Employee> employees = new List<Employee>();

            foreach (var emp in employeesFile)
            {
                if (emp[0] == "NAME") ;
                else
                {
                    Employee e = new Employee();
                    e.Name = emp[0];
                    e.Effectivity = int.Parse(emp[1]);
                    employees.Add(e);
                }

            }
            return employees;
        }
    }
}
