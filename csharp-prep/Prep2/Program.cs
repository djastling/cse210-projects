using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int intGrade = int.Parse(grade);

        string letter = "";
        string plusMinus = "";
        
        if (intGrade >= 90)
        {
            letter = "A";
        }
        else if (intGrade >= 80)
        {
            letter = "B";
        }
        else if (intGrade >= 70)
        {
            letter = "C";
        }
        else if (intGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int remainder = intGrade % 10;

        if (remainder >= 7)
        {
            plusMinus = "+";
        }
        else if (remainder < 3)
        {
            plusMinus = "-";
        }

        Console.WriteLine($"You got a {letter}{plusMinus}");
        if (intGrade >= 70)
        {
            Console.WriteLine("You passed the class, congratulations!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class, better luck next time!");
        }
    }   
}