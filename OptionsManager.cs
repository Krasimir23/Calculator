using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static string[] OptionsList = {
            "s- Subtract"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a -b}");

        }

            public static string[] OptionsList = {
            "m - Multyply"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public static string[] OptionsList = {
            "k -Devide "
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }





    }
}
