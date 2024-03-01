namespace CSharpApp_2
{
    public class Model
    {
        public class Employee
        {
            private string? name;
            private double salary;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public double Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public static Employee operator +(Employee emp, double amount)
            {
                emp.Salary += amount;
                return emp;
            }

            public static Employee operator -(Employee emp, double amount)
            {
                emp.Salary -= amount;
                return emp;
            }

            public static bool operator ==(Employee emp1, Employee emp2)
            {
                return emp1.Salary == emp2.Salary;
            }

            public static bool operator !=(Employee emp1, Employee emp2)
            {
                return emp1.Salary != emp2.Salary;
            }

            public override bool Equals(object obj)
            {
                if (obj is Employee)
                {
                    return this.Salary == ((Employee)obj).Salary;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return Salary.GetHashCode();
            }
        }

        public class Matrix
        {
            private int[,] matrix;

            public int this[int i, int j]
            {
                get { return matrix[i, j]; }
                set { matrix[i, j] = value; }
            }

            public static Matrix operator +(Matrix m1, Matrix m2)
            {
                return new Matrix();
            }

            public static Matrix operator -(Matrix m1, Matrix m2)
            {
                return new Matrix();
            }

            public static Matrix operator *(Matrix m1, Matrix m2)
            {
                return new Matrix();
            }

            public static Matrix operator *(Matrix m1, int scalar)
            {
                return new Matrix();
            }

            public static bool operator ==(Matrix m1, Matrix m2)
            {
                return true;
            }

            public static bool operator !=(Matrix m1, Matrix m2)
            {
                return true;
            }

            public override bool Equals(object obj)
            {
                return true;
            }

            public override int GetHashCode()
            {
                return 0;
            }
        }

        public class City
        {
            private string cityName;
            private int population;

            public string CityName
            {
                get { return cityName; }
                set { cityName = value; }
            }

            public int Population
            {
                get { return population; }
                set { population = value; }
            }

            public static City operator +(City city, int increment)
            {
                city.Population += increment;
                return city;
            }

            public static City operator -(City city, int decrement)
            {
                city.Population -= decrement;
                return city;
            }

            public static bool operator ==(City city1, City city2)
            {
                return city1.Population == city2.Population;
            }

            public static bool operator !=(City city1, City city2)
            {
                return city1.Population != city2.Population;
            }

            public override bool Equals(object obj)
            {
                if (obj is City)
                {
                    return this.Population == ((City)obj).Population;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return Population.GetHashCode();
            }
        }

        public class CreditCard
        {
            private string cvcCode;
            private double amount;

            public string CvcCode
            {
                get { return cvcCode; }
                set { cvcCode = value; }
            }

            public double Amount
            {
                get { return amount; }
                set { amount = value; }
            }

            public static CreditCard operator +(CreditCard card, double increaseAmount)
            {
                card.Amount += increaseAmount;
                return card;
            }

            public static CreditCard operator -(CreditCard card, double decreaseAmount)
            {
                card.Amount -= decreaseAmount;
                return card;
            }

            public static bool operator ==(CreditCard card1, CreditCard card2)
            {
                return card1.Amount == card2.Amount;
            }

            public static bool operator !=(CreditCard card1, CreditCard card2)
            {
                return card1.Amount != card2.Amount;
            }

            public override bool Equals(object obj)
            {
                if (obj is CreditCard)
                {
                    return this.Amount == ((CreditCard)obj).Amount;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return Amount.GetHashCode();
            }
        }
    }
}
