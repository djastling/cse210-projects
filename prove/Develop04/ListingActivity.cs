using System;

//defines the ListingActivity class
public class ListingActivity : Activity{

    //creates an empty constructor for the ListingActivity class
    public ListingActivity(string activityName, string description, int seconds) : base(activityName, description, seconds){
    }

    // creates a list of prompts for the user to respond to
    private List<string> promptList = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // creates a method to run the Listing activity
    public void Listing(){

        // chooses a random number to select a prompt from the list
        Random random = new Random();
        int randomPrompt = random.Next(promptList.Count);

        // displays the prompt to the user
        Console.WriteLine("List as many responses as you can to the following prompt: \n");
        Console.WriteLine($" --- {promptList[randomPrompt]} --- \n");

        // displays a countdown to the user
        Console.Write("You may begin in: ");
        Activity.Countdown(5);
        Console.WriteLine();

        // creates a variable for when the loop will end
        DateTime futureTime = DateTime.Now.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;

        // creates a loop that will continue until the current time is greater than the future time
        int count = 0;
        while (currentTime < futureTime){

            // allows the user to list items
            Console.Write(">");
            Console.ReadLine();

            // updates the current time and the count
            currentTime = DateTime.Now;

            count++;
        }

        // displays the number of items listed by the user
        Console.WriteLine($"You listed {count} items!");
        Activity.DisplayAnimation(5);
    }

}