using System;


namespace convert_types
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "123";
            Console.WriteLine("Original string: " + text1);

             int number1 = Convert.ToInt32((text1));
             Console.WriteLine("Converted variable: " + number1);
        }

    }
}
