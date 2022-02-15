using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a subject: ");
            string userSubject = Console.ReadLine();

            switch(userSubject)
            {
                case "Software Engineering":
                    Console.WriteLine("This is the course name");
                    break;
                case "Git & Github":
                    Console.WriteLine("This is the first section");
                    break;
                case "C#":
                    Console.WriteLine("This is the second section we focus on.");
                    break;
                case "Javascript":
                    Console.WriteLine("This will be the third section we briefly look at.");
                    break;
                case "SQL":
                    Console.WriteLine("This will be one of the final sections");
                    break;
                default:
                    Console.WriteLine("This is all related to coding");
                    break;


            }
        }
    }
}
