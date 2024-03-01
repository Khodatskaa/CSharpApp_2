using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpApp_2.Tests
{
    [TestClass]
    public class TestModel
    {
        [TestMethod]
        public void TestEmployee()
        {
            Employee emp1 = new Employee { Name = "John", Salary = 50000 };
            Employee emp2 = new Employee { Name = "Jane", Salary = 60000 };

            emp1 = emp1 + 5000;
            emp2 = emp2 - 2000;

            Assert.AreEqual(emp1.Salary, 55000);
            Assert.AreEqual(emp2.Salary, 58000);
            Assert.IsTrue(emp1 == emp2);
        }

        [TestMethod]
        public void TestMatrix()
        {
            Matrix matrix1 = new Matrix();
            Matrix matrix2 = new Matrix();

            matrix1 = matrix1 + matrix2;
            matrix1 = matrix1 - matrix2;
        }

        [TestMethod]
        public void TestCity()
        {
            City city1 = new City { CityName = "CityA", Population = 1000000 };
            City city2 = new City { CityName = "CityB", Population = 800000 };

            city1 = city1 + 50000;
            city2 = city2 - 20000;

            Assert.AreEqual(city1.Population, 1050000);
            Assert.AreEqual(city2.Population, 780000);
            Assert.IsTrue(city1 != city2);
        }

        [TestMethod]
        public void TestCreditCard()
        {
            CreditCard card1 = new CreditCard { CvcCode = "123", Amount = 5000 };
            CreditCard card2 = new CreditCard { CvcCode = "456", Amount = 7000 };

            card1 = card1 + 1000;
            card2 = card2 - 500;

            Assert.AreEqual(card1.Amount, 6000);
            Assert.AreEqual(card2.Amount, 6500);
            Assert.IsFalse(card1 == card2);
        }
    }
}
