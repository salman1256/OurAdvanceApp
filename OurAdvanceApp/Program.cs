using System;
namespace OurAdvanceApp
{
    public class  Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Enter a number");
            int result=int.TryParse(Console.ReadLine(),out int number)?number:1;
                            Console.WriteLine($"Number entered by you {number} and Cube of Number is {Cube(number)}");
           
            Console.Read();

        }
        public static int Cube(int number)
        {
            return number*number*number;
        }
    }
}