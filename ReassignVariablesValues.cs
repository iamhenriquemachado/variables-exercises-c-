using System;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace changing_variables
{
    class Program
    {
        static void Main(string[] args) {
            int number1 = 10;
            int number2 = 20;

            Console.WriteLine("Numbers printed: " + number1 + number2);

            number1 = 30;
            number2 = 50;

            Console.WriteLine("New values: " + number1 + number2);

        }
        


    }
}
