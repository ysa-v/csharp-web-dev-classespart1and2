using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student myself = new Student("Ysabel", 000782338, 1, 4.0);

            Console.WriteLine("The student's name is " + myself.Name + "!");

            myself.Name = "still Ysabel";

            Console.WriteLine("The student's name is " + myself.Name + "!");
        }
    }
}
