using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello student, what is your grade percentage in the class?");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter = "";

        if (percent >= 90) {
            letter = "A";
        }
        else if (percent >= 80) {
            letter = "B";
        }
        else if (percent >= 70) {
            letter = "C";
        }
        else if (percent >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        Console.WriteLine($"Student your grade is: {letter}");

        if (percent >= 70) {
            Console.WriteLine("Congrats you passed the class!");
        }
        else {
            Console.WriteLine("Sorry you didnt pass the class, better luck next semester!");
        }
    }
}

//        if (percent >= 90) {
//            Console.WriteLine("You have an A in the class!");
//        }
//        else if (percent >= 80) {
//            Console.WriteLine("You have an B in the class! ");
//        }
//        else if (percent >= 70) {
//            Console.WriteLine("You have a C in the class!");
//        }
//        else if (percent >= 60) {
//            Console.WriteLine("You have a D in the class!");
//        }
//        else {
//            Console.WriteLine("Oh No! You have an F in the class!");
//        }