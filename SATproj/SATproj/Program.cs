static void Main(string[] args)
{
    //Declared a studentClass for array max value
    int studentClass;
    //Intro and asking User input so our app knows the max value of students
    Console.Write($"***** Student Pairing App *****\n\nEnter the number of students you wish to pair: ");

    //Convert and assign User's input to our declared studentClass
    studentClass = Convert.ToInt32(Console.ReadLine());

    //Created an array to hold students with a max size of our studentClass...I think? I made a Student object in Student.cs and think we could have the User create Students below but I'm not sure if we even need to do this
    string[] student = new string[studentClass];

    //Creating a for loop that should fire off a request for student names equal to the value of studentClass
    for (int i = 0; i < studentClass; i++)
    {
        //Asking the User for the student names and hopefully saving it to our array
        Console.Write("Input the Student's name: ");
        student[i] = Console.ReadLine();

    }//end for loop user input student name

    Console.WriteLine();
    Console.WriteLine("Students not assigned a partner:\n");
    //should read back the array to the user just to see if it is working
    foreach (var item in student)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();

    //Thinking about using that blackjack logic to draw pairs of students and probably have logic where if 3 students are left it will put them in the final group and we could throw an error if there is only 1 student left in the array. I dunno if we are supposed to use the SOLID stuff we did in class but I'm not sure if any of it is applicable for this right now. Thinking about it makes me want to lay down.

}//end Main()