using System;
namespace OurAdvanceApp
{
    public class  Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Enter a number");
            if(int.TryParse(Console.ReadLine(),out int number))
            {

                Console.WriteLine($"Number entered by you {number} and Cube of Number is {Cube(number)}");
            }
            else{

                Console.WriteLine("Invalid Input");
            }
            Console.Read();

        }
        public static int Cube(int number)
        {
            return number*number*number;
        }
    }
}