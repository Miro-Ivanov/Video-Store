using System;

namespace _5._WithOrder
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie Titanic = new Movie("Titanic", "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious,\n" +
                    "ill-fated R.M.S. Titanic.", new DateTime(1997,3,31),Genre.drama,3.99m,8.99m);
            Order order1 = new Order("Patrick");
            order1.movies.Add(Titanic);
            

            Movie Matrix = new Movie("Matrix", "When a beautiful stranger leads computer hacker Neo to a forbidding underworld,\n" +
                    "he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", new DateTime(1999, 12, 16), Genre.action, 4.99m, 10.99m);
            order1.movies.Add(Matrix);
            Console.WriteLine(order1.OrderInfo());

            Console.WriteLine(Titanic.DisplayInfo());
        }
    }
}
