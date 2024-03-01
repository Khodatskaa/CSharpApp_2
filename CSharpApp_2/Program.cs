using System;

namespace CSharpApp_2
{
    public class Program
    {
        public static void Main()
        {
            Employee emp1 = new Employee { Name = "John", Salary = 50000 };
            Employee emp2 = new Employee { Name = "Jane", Salary = 60000 };

            emp1 = emp1 + 5000;
            emp2 = emp2 - 2000;

            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 != emp2);

            Matrix matrix1 = new Matrix();
            Matrix matrix2 = new Matrix();

            matrix1 = matrix1 + matrix2;
            matrix1 = matrix1 - matrix2;

            Console.WriteLine(matrix1 == matrix2);
            Console.WriteLine(matrix1 != matrix2);

            City city1 = new City { CityName = "CityA", Population = 1000000 };
            City city2 = new City { CityName = "CityB", Population = 800000 };

            city1 = city1 + 50000;
            city2 = city2 - 20000;

            Console.WriteLine(city1 == city2);
            Console.WriteLine(city1 != city2);

            CreditCard card1 = new CreditCard { CvcCode = "123", Amount = 5000 };
            CreditCard card2 = new CreditCard { CvcCode = "456", Amount = 7000 };

            card1 = card1 + 1000;
            card2 = card2 - 500;

            Console.WriteLine(card1 == card2);
            Console.WriteLine(card1 != card2);
        }
    }
}

