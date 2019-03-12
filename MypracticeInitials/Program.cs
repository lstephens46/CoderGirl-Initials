using System;

namespace Initials
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Console.Write("Please enter your first name: ");
            //string firstName = Console.ReadLine();

            //Console.Write("Please enter your middle name: ");
            //string middleName = Console.ReadLine();


            //Initials(lauren, faye, stephens)
            Console.WriteLine(Name(firstName));


            Console.ReadLine();
        }

        public static string Name(string typeOfName)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please enter your " + typeOfName + ": ");
                string name = Console.ReadLine();
                return name;
            }
            //Console.Write("Please enter your " + typeOfName + ": ");
            //string name = Console.ReadLine();
            //return name;
        }
        // TODO: Create a method that takes in a full name and return the initials in all capital letters.
        public static string Initials(string firstName, string middleName, string lastName)
        {


        }

    }

}
