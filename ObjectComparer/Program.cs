﻿using ObjectsComparer;
using System;
using System.Collections.Generic;

namespace ObjectComparer
{
    class Program
    {
        static void Main(string[] args)
        {


            var compr = new ObjectsComparer.Comparer<Employee>();

            Employee e1 = new Employee()
            {
                EmployeeID = 1,
                FirstName = "Andrew",
                LastName = "Sheley",
                UpdatedBy = "Jones",

            };
            Employee e2 = new Employee()
            {
                EmployeeID = 1,
                FirstName = "Andy",
                LastName = "Sheley",
                UpdatedBy = "Elvis",

            };


            //Compare objects  
            IEnumerable<Difference> differences;
            var isEqual = compr.Compare(e1, e2, out differences);


            Console.WriteLine("Hello World!");
        }
    }
}
