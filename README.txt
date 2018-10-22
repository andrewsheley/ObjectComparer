This example uses nuget package to object compare


URL:  https://www.c-sharpcorner.com/article/using-objects-comparer-to-compare-complex-objects-in-c-sharp/
URL:  https://www.codeproject.com/Articles/1186154/Objects-Comparer


Basicly add nuget:  Install-Package ObjectsComparer  in PM


Then here is the code snippet:

            var compr = new ObjectsComparer.Comparer<Employee>();

            Employee e1 = new Employee() {
                EmployeeID=1,
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