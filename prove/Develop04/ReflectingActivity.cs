using System;

// defines the ReflectingActivity class
public class ReflectingActivity : Activity{

    // creates an empty constructor for the ReflectingActivity class
    public ReflectingActivity(string activityName, string description, int seconds) : base(activityName, description, seconds){
    }

    // creates a list of prompts for the user to reflect to
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // creates a list of prompts for the user to think about
    private List<string> reflectingPrompts = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // creates a method to run the Reflection activity
    public void Reflection(){

        // chooses a random number to select a prompt from the list
        Random random = new Random();
        int randomPrompt = random.Next(prompts.Count);

        // displays the prompt to the user
        Console.WriteLine("Consider the following Prompt: \n");
        Console.WriteLine($" --- {prompts[randomPrompt]} --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.Read();     // allows the user to press enter

        // displays a message and countdown to the user
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Activity.Countdown(5);
        Console.Clear();

        // creates a variable for when the loop will end
        DateTime futureTime = DateTime.Now.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;

        //creates a new variable to hold the list of prompts
        List <string> currentList = reflectingPrompts.ToList();

        // creates a loop that will continue until the current time is greater than the future time
        while (currentTime < futureTime){
            
            // if the program runs out of prompts, it will reset the list
            if (currentList.Count < 1){
                currentList = reflectingPrompts.ToList();
            }

            // chooses a random number to select a prompt from the list
            int randomReflection = random.Next(currentList.Count);
            Console.Write($"{currentList[randomReflection]} ");

            currentList.RemoveAt(randomReflection); // removes the prompt from the list
            Activity.DisplayAnimation(7);           // displays an animation for 7 seconds to let the user reflect
            Console.WriteLine();

            currentTime = DateTime.Now;             // updates the current time
        }
    }


}