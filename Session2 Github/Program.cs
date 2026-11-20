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
        Book myBook = new Book { Title = "C# Programming", Pages = 464 };
        object obj = myBook;
        Console.WriteLine(obj);
        #endregion

        
    }
}
#endregion