using System.Drawing;
using System.Dynamic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //// Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            //// variable of type object.Print it.

            //Book b1 = new Book() { title = "Programming", pages = 200 };
            //Console.WriteLine(b1.title);
            //Console.WriteLine(b1.pages);
            #endregion


            #region Question 2
            //Q02.Using the Book class above, print the result of calling ToString(), Equals() (compare book 
            //withitself), GetHashCode(), and GetType() on book.

            Book b1 = new Book() { title = "Programming", pages = 200 };
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1.Equals(b1));
            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(b1.GetType());


            #endregion



        }
    }
}
