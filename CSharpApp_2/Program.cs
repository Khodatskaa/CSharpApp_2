namespace CSharpApp_2
{
    public class Program
    {
        static void Main()
        {
            // Task 1
            Journal journal = new Journal();
            journal.IncreaseEmployees(10);
            Console.WriteLine($"Number of Employees: {journal.NumberOfEmployees}");

            // Task 2
            Store store = new Store();
            store.IncreaseStoreArea(100.5);
            Console.WriteLine($"Store Area: {store.StoreArea}");

            // Task 3
            BookReadList bookList = new BookReadList();
            bookList.AddBook("Book1");
            bookList.AddBook("Book2");
            Console.WriteLine($"Book at index 0: {bookList[0]}");
        }
    }
}
