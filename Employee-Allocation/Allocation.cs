using System;
using System.Collections.Generic;

namespace Employee_Allocation
{
    class Allocation
    {
        internal List<Employee> hireEmployees()
        {
            Employee employee = new Employee();
            var employees = employee.OpenFile(@"C:\Users\randj\Dropbox\NET\Employee-Allocation\Employee-Allocation\Employee-Allocation\Files\employees.csv");
            return employees;
        }

        internal List<Task> getTastks()
        {
            Task task = new Task();
            var tasks = task.OpenFile(@"C:\Users\randj\Dropbox\NET\Employee-Allocation\Employee-Allocation\Employee-Allocation\Files\tasks.csv");
            return tasks;
        }
    }
}
