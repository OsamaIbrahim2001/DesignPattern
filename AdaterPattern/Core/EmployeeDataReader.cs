namespace AdaterPattern.Core
{
    internal class EmployeeDataReader
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return new[] { new Employee()
            {
                FirstName="Osama",
                SecondName="Ibrahim",
                LastName="Sadek",
                PayItems=new List<PayItem>()
                {
                    new PayItem(){Name="Basic Salary",Value=1000 },
                    new PayItem(){Name="Transportation",Value=250 },
                    new PayItem(){Name="Mediacal Insurance",Value=150,IsDeductive=true }
                }
            },
                new Employee()
            {
                FirstName="Mostafa",
                SecondName="Ibrahim",
                LastName="Sadek",
                PayItems=new List<PayItem>()
                {
                    new PayItem(){Name="Basic Salary",Value=1000 },
                    new PayItem(){Name="Transportation",Value=250 },
                    new PayItem(){Name="Mediacal Insurance",Value=-150 }
                }
                }
            };
        }
    }
}
