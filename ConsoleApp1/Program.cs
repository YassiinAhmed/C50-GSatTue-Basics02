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

            #region Question 3
            //Q03.Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
            // int pages = "464";

            // Compile-time Error

            // There are two ways to fix it.
            // First :-

            //int pages = 464;

            // Second :-

            //string pages = "464";

            #endregion

            #region Question 4
            // Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            //zero", and then prints "Done" in a finally block.

            //try
            //{
            //    int num = 10 / 0;
            //}
            //catch (DivideByZeroException ){
            //    Console.WriteLine("Cannot Divide By Zero");
            //}
            //finally{
            //    Console.WriteLine("Done");
            //}

            #endregion


            #region Question 5
            ////Q05.Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double var = pages;
            //Console.WriteLine(var);

            #endregion


            #region Question 6
            //Q06.Declare a double price = 49.99; then convert it into an int using a cast
            double price = 49.99;
            int p = (int)price;
            Console.WriteLine(p);
            #endregion 





        }
    }
}
