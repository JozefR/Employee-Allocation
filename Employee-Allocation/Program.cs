using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Employee_Allocation
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategy strategy = new Strategy();

            strategy.PrepareResources();
        }
    }
}
