using System;
using System.Collections.Generic;

namespace CSharpApp_2
{
    public class Model
    {
        // Task 1
        public class Journal
        {
            private int numberOfEmployees;

            public int NumberOfEmployees
            {
                get { return numberOfEmployees; }
                set { numberOfEmployees = value; }
            }

            public void IncreaseEmployees(int quantity)
            {
                NumberOfEmployees += quantity;
            }

            public void DecreaseEmployees(int quantity)
            {
                NumberOfEmployees -= quantity;
            }

            public bool EqualsEmployees(int quantity)
            {
                return NumberOfEmployees == quantity;
            }

            public bool LessThanEmployees(int quantity)
            {
                return NumberOfEmployees < quantity;
            }

            public bool GreaterThanEmployees(int quantity)
            {
                return NumberOfEmployees > quantity;
            }

            public bool NotEqualsEmployees(int quantity)
            {
                return NumberOfEmployees != quantity;
            }

            public override bool Equals(object obj)
            {
                return obj is Journal journal && NumberOfEmployees == journal.NumberOfEmployees;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(NumberOfEmployees);
            }
        }

        // Task 2
        public class Store
        {
            private double storeArea;

            public double StoreArea
            {
                get { return storeArea; }
                set { storeArea = value; }
            }

            public void IncreaseStoreArea(double size)
            {
                StoreArea += size;
            }

            public void DecreaseStoreArea(double size)
            {
                StoreArea -= size;
            }

            public bool EqualsStoreArea(double size)
            {
                return StoreArea == size;
            }

            public bool LessThanStoreArea(double size)
            {
                return StoreArea < size;
            }

            public bool GreaterThanStoreArea(double size)
            {
                return StoreArea > size;
            }

            public bool NotEqualsStoreArea(double size)
            {
                return StoreArea != size;
            }

            public override bool Equals(object obj)
            {
                return obj is Store store && StoreArea == store.StoreArea;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(StoreArea);
            }
        }

        // Task 3
        public class BookReadList
        {
            private List<string> books = new List<string>();

            public void AddBook(string book)
            {
                books.Add(book);
            }

            public void RemoveBook(string book)
            {
                books.Remove(book);
            }

            public bool ContainsBook(string book)
            {
                return books.Contains(book);
            }

            public string this[int index]
            {
                get { return books[index]; }
                set { books[index] = value; }
            }
        }
    }
}
