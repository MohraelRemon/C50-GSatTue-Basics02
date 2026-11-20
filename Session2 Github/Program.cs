using System;

#region Book Class
/*-Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
variable of type object. Print it*/
class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
}
#endregion

#region Program
class Program
{
    static void Main()
    {
        #region Q01 - Store Book in object and print
        /// Book myBook = new Book { Title = "C# Programming", Pages = 464 };
        /// object obj = myBook;
        ///  Console.WriteLine(obj);
        #endregion
        #region Q2
        /* Q02Using the Book class above, print the result of calling ToString(), Equals() (compare book with
        itself), GetHashCode(), and GetType() on book.*/

        /*Book book = new Book { Title = "C# Programming", Pages = 464 };

        Console.WriteLine(book.ToString());
        Console.WriteLine(book.Equals(book));
        Console.WriteLine(book.GetHashCode());
        Console.WriteLine(book.GetType());*/
        #endregion
        #region Q03 - Type mismatch error & fix
        // Original (compile-time error): int pages = "464";
        /*int pages = int.Parse("464");
        Console.WriteLine(pages);*/
        #endregion
        #region Q04 - Try, catch, and finally
        /*try
        {
            int zero = 0;
            int result = 10 / zero;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Done");
        }*/
        #endregion
        #region Q05 - Implicit conversion from int to double
        /* int Pages = 300;
         double doublePages = pages;
         Console.WriteLine(doublePages);*/
        #endregion
        #region Q06 - Explicit cast from double to int
        /*double price = 49.99;
        int intPrice = (int)price;
        Console.WriteLine(intPrice);*/
        #endregion
        #region Q07 - Convert string to int using Convert class
        /*string pagesText = "464";
        int pages = Convert.ToInt32(pagesText);
        Console.WriteLine(Pages);*/
        #endregion
        #region Q08 - int.Parse() and int.TryParse()
        string yearText = "2023";
        int year = int.Parse(yearText);
        Console.WriteLine(year);

        string badText = "abc";
        if (!int.TryParse(badText, out int parsedNumber))
        {
            Console.WriteLine("Invalid number");
        }
        #endregion
    }
}
#endregion