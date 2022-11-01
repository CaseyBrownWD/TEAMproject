using System.Collections;

namespace SATproj
{
    public class Employee
    {


        static void Main(string[] args)
        {
            //Array max value
            int studentClass;

            //Intro and asking User input
            Console.Write($"***** Student Pairing App *****\n\nEnter the number of students you wish to pair: ");

            //User's input converted to studentClass
            studentClass = Convert.ToInt32(Console.ReadLine());

            //Array that holds students
            string[] student = new string[studentClass];

            //For loop that that requests student names 
            for (int i = 0; i < studentClass; i++)
            {
                //Asking the User for the student names
                Console.Write("Input the Student's name: ");
                student[i] = Console.ReadLine();

            }//end 

            Console.WriteLine();
            Console.WriteLine("Students not assigned a partner:\n");
            //Reads back the users but doesnt sort.
            Array.Sort(student);
            foreach (var item in student)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

  
        }//end Main()

    }

}