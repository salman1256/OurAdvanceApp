using System;
namespace OurAdvanceApp
{
    public class  Program
    {
        public static void Main()
        {
            try{
            int number=1;
            System.Console.WriteLine("Enter a number");
            number=int.Parse(Console.ReadLine());
            Console.WriteLine($"Number entered by you {number} and Cube of Number is {Cube(number)}");
                       
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Exception Occured"+ex.Message);
            }
            finally
            {
              Console.Read(); 
            }

        }
        public static int Cube(int number)
        {
            return number*number*number;
        }
    }
}