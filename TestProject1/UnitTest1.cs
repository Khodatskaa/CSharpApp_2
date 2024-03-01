using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class Tests
{
    [TestMethod]
    public void TestJournal()
    {
        // Arrange
        Journal journal = new Journal();

        // Act
        journal.IncreaseEmployees(10);

        // Assert
        Assert.AreEqual(10, journal.NumberOfEmployees);

        journal.DecreaseEmployees(5);
        Assert.AreEqual(5, journal.NumberOfEmployees);

        Assert.IsTrue(journal.EqualsEmployees(5));
        Assert.IsTrue(journal.LessThanEmployees(10));
        Assert.IsTrue(journal.GreaterThanEmployees(1));
        Assert.IsFalse(journal.NotEqualsEmployees(5));

        Journal journal2 = new Journal();
        journal2.IncreaseEmployees(5);

        Assert.IsTrue(journal.Equals(journal2));
    }

    [TestMethod]
    public void TestStore()
    {
        // Arrange
        Store store = new Store();

        // Act
        store.IncreaseStoreArea(50.5);

        // Assert
        Assert.AreEqual(50.5, store.StoreArea);

        store.DecreaseStoreArea(25.0);
        Assert.AreEqual(25.5, store.StoreArea);

        Assert.IsTrue(store.EqualsStoreArea(25.5));
        Assert.IsTrue(store.LessThanStoreArea(50.0));
        Assert.IsTrue(store.GreaterThanStoreArea(20.0));
        Assert.IsFalse(store.NotEqualsStoreArea(25.5));

        Store store2 = new Store();
        store2.IncreaseStoreArea(25.5);

        Assert.IsTrue(store.Equals(store2));
    }

    [TestMethod]
    public void TestBookReadList()
    {
        // Arrange
        BookReadList bookList = new BookReadList();

        // Act
        bookList.AddBook("Book1");
        bookList.AddBook("Book2");

        // Assert
        Assert.IsTrue(bookList.ContainsBook("Book1"));
        Assert.AreEqual("Book1", bookList[0]);

        bookList.RemoveBook("Book1");
        Assert.IsFalse(bookList.ContainsBook("Book1"));
    }
}
