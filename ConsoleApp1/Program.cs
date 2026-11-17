using System.Drawing;
using System.Dynamic;
using System.Numerics;
using System.Timers;

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

            //Book b1 = new Book() { title = "Programming", pages = 200 };
            //Console.WriteLine(b1.ToString());
            //Console.WriteLine(b1.Equals(b1));
            //Console.WriteLine(b1.GetHashCode());
            //Console.WriteLine(b1.GetType());


            #endregion

            #region Question3
            //Q03.Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
            // int pages = "464";

            // Compile-time Error

            // There are two ways to fix it.
            // First :-

            //int pages = 464;

            // Second :-
            
            //string pages = "464";

            #endregion

        }
    }
}
