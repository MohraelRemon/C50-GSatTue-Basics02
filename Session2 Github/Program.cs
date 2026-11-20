using System;

namespace session2
{
    class Book
    {
        public string Title { get; set; } = string.Empty;
        public int Pages { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // ==========================================
            // Q01. Boxing a Book object
            // ==========================================
            Console.WriteLine("--- Q01 ---");
            Book myBook = new Book { Title = "C# Programming", Pages = 464 };
            object obj = myBook;
            Console.WriteLine(obj);

            // ==========================================
            // Q02. Object methods on a Book
            // ==========================================
            Console.WriteLine("\n--- Q02 ---");
            Book book = new Book { Title = "C# Programming", Pages = 464 };
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

            // ==========================================
            // Q03. Type mismatch error & fix
            // ==========================================
            Console.WriteLine("\n--- Q03 ---");
            // Original: int pages = "464"; -> Compile-time error
            int pagesQ03 = int.Parse("464");
            Console.WriteLine(pagesQ03);

            // ==========================================
            // Q04. Exception handling (try, catch, finally)
            // ==========================================
            Console.WriteLine("\n--- Q04 ---");
            try
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
            }

            // ==========================================
            // Q05. Implicit conversion (Widening)
            // ==========================================
            Console.WriteLine("\n--- Q05 ---");
            int pagesQ05 = 300;
            double doublePages = pagesQ05;
            Console.WriteLine(doublePages);

            // ==========================================
            // Q06. Explicit conversion (Narrowing)
            // ==========================================
            Console.WriteLine("\n--- Q06 ---");
            double price = 49.99;
            int intPrice = (int)price;
            Console.WriteLine(intPrice);

            // ==========================================
            // Q07. Parsing using Convert class
            // ==========================================
            Console.WriteLine("\n--- Q07 ---");
            string pagesText = "464";
            int pagesQ07 = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesQ07);

            // ==========================================
            // Q08. int.Parse() and int.TryParse()
            // ==========================================
            Console.WriteLine("\n--- Q08 ---");
            string yearText = "2023";
            int yearQ08 = int.Parse(yearText);
            Console.WriteLine(yearQ08);

            string badText = "abc";
            if (!int.TryParse(badText, out int parsedResult))
            {
                Console.WriteLine("Invalid number");
            }

            // ==========================================
            // Q09. ToString() and GetType()
            // ==========================================
            Console.WriteLine("\n--- Q09 ---");
            int pagesQ09 = 464;
            string pagesStr = pagesQ09.ToString();
            Console.WriteLine(pagesStr.GetType());

            // ==========================================
            // Q10. Boxing and Unboxing
            // ==========================================
            Console.WriteLine("\n--- Q10 ---");
            int copies = 100;
            object boxed = copies;
            int unboxed = (int)boxed;
            Console.WriteLine(boxed);
            Console.WriteLine(unboxed);

            // ==========================================
            // Q11. Nullable value types (int?)
            // ==========================================
            Console.WriteLine("\n--- Q11 ---");
            int? yearQ11 = null;
            Console.WriteLine(yearQ11.HasValue);
            yearQ11 = 2023;
            Console.WriteLine(yearQ11.Value);

            // ==========================================
            // Q12. Nullable reference types (string?)
            // ==========================================
            Console.WriteLine("\n--- Q12 ---");
            string? reviewer = null;
            Console.WriteLine(reviewer is null);

            // ==========================================
            // Q13. Null-conditional operator (?.)
            // ==========================================
            Console.WriteLine("\n--- Q13 ---");
            Book? nullableBook = null;
            string? title = nullableBook?.Title;
            Console.WriteLine(title);

            // ==========================================
            // Q14. Null-coalescing (??) and (??=)
            // ==========================================
            Console.WriteLine("\n--- Q14 ---");
            Console.WriteLine(title ?? "Untitled");
            title ??= "Untitled";
            Console.WriteLine(title);

            // ==========================================
            // Q15. Null-forgiving operator (!)
            // ==========================================
            Console.WriteLine("\n--- Q15 ---");
            string? name = "Ahmed";
            string confirmedName = name!;
            Console.WriteLine(confirmedName);
        }
    }
}