using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Employee_Allocation
{
    class Task : IAcceptResources
    {
        public string Name { get; set; }
        public int Complexity { get; set; }

        public dynamic OpenFile(string path)
        {
            var tasksFile = File.ReadAllLines(@"C:\Users\randj\Dropbox\NET\Employee-Allocation\Employee-Allocation\Employee-Allocation\Files\tasks.csv").Select(e => e.Split(','));

            List<Task> tasks = new List<Task>();

            foreach (var emp in tasksFile)
            {
                if (emp[0] == "NAME") ;
                else
                {
                    Task e = new Task();
                    e.Name = emp[0];
                    e.Complexity = int.Parse(emp[1]);
                    tasks.Add(e);
                }

            }
            return tasks;
        }
    }
}
