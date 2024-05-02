using System;

class Program
{
    static void Main(string[] args)
    {
        int newNumber;
        int sum = 0;
        int average;
        int largestNumber = 0;
        List<int> numberList = new List<int>();

        do 
        {
            Console.Write("What is your number?\n\nStop by entering 0: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber !=0) {
                numberList.Add(newNumber);
            }
        }   
        while (newNumber != 0);

        for (int i = 0; i < numberList.Count; i++)
        {
            sum += numberList[i];
            if (numberList[i] > largestNumber)
            {
                largestNumber = numberList[i];
            }
        }
        average = sum / numberList.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}