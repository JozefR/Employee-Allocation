using System;
using System.Collections.Generic;
using System.Linq;

namespace Employee_Allocation
{
    class Strategy
    {
        private Allocation _allocation;

        public Strategy()
        {
            _allocation = new Allocation();
        }

        public void PrepareResources()
        {
            var emp = _allocation.hireEmployees();
            var tsk = _allocation.getTastks();

            startStrategy(emp, tsk);
        }

        private void startStrategy(List<Employee> emp, List<Task> tsk)
        {
            if (emp.Count > tsk.Count)
            {
                performAction(emp, tsk);
            }
            else
            {
                performAction(emp, tsk);
            }
        }

        private void performAction(List<Employee> emp, List<Task> tsk)
        {
            var effectivitySort = emp.OrderBy(e => e.Effectivity).Reverse();
            var complexitySort = tsk.OrderBy(t => t.Complexity).Reverse();

            List<Employee> employeetasks = new List<Employee>();

            foreach (var task in complexitySort)
            {
                foreach (var empl in effectivitySort)
                {
                    Employee employee = new Employee();
                    employee.Task.Name = task.Name;
                    employee.Task.Complexity = task.Complexity;
                    employee.Name = empl.Name;
                    employee.Effectivity = empl.Effectivity;
                    employeetasks.Add(employee);
                }
            }

            foreach (var item in employeetasks)
            {
                Console.WriteLine("{0} {1} {2} {3}",item.Name, item.Effectivity, item.Task.Name, item.Task.Complexity);
            }
        }
    }
}
