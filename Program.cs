using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            AddX(8, 4); MultX(13, 1); DivX(19, 1); SubX(90, 1);
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();



            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("I love that color! What's your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("Ok, last but not least. Who's your favorite artist?");
            string artist = Console.ReadLine();

            Console.WriteLine($"Once upon a time, {name} went for a walk." +
                              $"{name} ran into {artist} on their walk." +
                              $"{artist} was walking a {color}{animal}." +
                              $" 'Wow, I'm such a huge fan of your work! {name} told {artist}." +
                              $"{artist} smiled at {name}. 'Thank you!'" +
                              $"They both continued on their walk and enjoyed the rest of their day." +
                              $"The End.");
        }
        public static void AddX(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }

        public static void MultX(int x, int y)
        {
            int answer = x * y;
            Console.WriteLine(answer);
        }


        public static void DivX(int x, int y)
        {
            int answer = x / y;
            Console.WriteLine(answer);
        }


        public static void SubX(int x, int y)
        {
            int answer = x - y;
            Console.WriteLine(answer);
        }
    }

}
