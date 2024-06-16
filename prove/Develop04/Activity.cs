using System;

// defines the Activity class
public class Activity {
    private string activityName;    // creates a variable to hold the name of the activity
    private string description;     // creates a variable to hold the description of the activity
    protected int seconds;          // creates a variable to hold the number of seconds the activity will last
    protected Activity(string activityName, string description, int seconds){  // creates a constructor for the Activity class
        this.activityName = activityName;
        this.description = description;
        this.seconds = seconds;
    }

    public static void MenuLoop(){  // creates a method to display the menu and allow the user to choose an activity
        string input = "";          // creates a variable to hold the user's input
        while (input != "4")        // creates a loop that will continue until the user enters 4
        {
            Console.Clear();        // clears the console
            Console.WriteLine("Which Program would you like to choose?\n");     // displays the menu
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. quit\n");
            Console.Write("Enter your choice here: ");
            input = Console.ReadLine();     // gets the user's input

            switch(input)       // creates a switch statement to determine which activity to run
            {
                case "1":    // if the user enters 1

                    // creates a new instance of the BreathingActivity class
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 0);

                    // calls the CommonMessage method, then the breathing method and then the ExitMessage method
                    breathingActivity.CommonMessage();
                    breathingActivity.Breathing();
                    breathingActivity.ExitMessage();

                    break;

                case "2":   // if the user enters 2

                    // creates a new instance of the ReflectingActivity class
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);

                    // calls the CommonMessage method, then the Reflection method and then the ExitMessage method
                    reflectingActivity.CommonMessage();
                    reflectingActivity.Reflection();
                    reflectingActivity.ExitMessage();

                    break;

                case "3":   // if the user enters 3

                    // creates a new instance of the ListingActivity class
                    ListingActivity listingActivity = new ListingActivity("listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);

                    // calls the CommonMessage method, then the Listing method and then the ExitMessage method
                    listingActivity.CommonMessage();
                    listingActivity.Listing();
                    listingActivity.ExitMessage();

                    break;
                case "4":   // if the user enters 4
                    Console.WriteLine("Goodbye!");
                    
                    break;
                
                default:    // if the user enters anything other than 1, 2, 3, or 4
                    Console.WriteLine("Please enter a number 1 - 4");
                    DisplayAnimation(5);

                    break;
            }
        }
    }

    // creates a method to display the common message for each activity
    private void CommonMessage(){

        Console.Clear();    // clears the console
        Console.WriteLine($"Welcome to the {activityName}.\n");   // displays the name of the activity
        Console.WriteLine(description);     // displays the description of the activity
        Console.WriteLine();         // creates a blank line

        // prompts the user to choose how long the activity will go for
        Console.Write("How long would you like the activity to go? ");
        seconds = int.Parse(Console.ReadLine());

        Console.Clear();    // clears the console
        Console.WriteLine("Get ready...");      // displays a get ready message to the user
        DisplayAnimation(3);
        Console.WriteLine();
    }

    // creates a method to display a spinning animation
    public static void DisplayAnimation(int seconds){
        
        // creates a variable for when the animation should stop
        DateTime futureTime = DateTime.Now.AddSeconds(seconds);

        // creates a loop that will continue until the current time is greater than the future time
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime){

            // displays a spinning animation that changes every 150 ms
            Console.Write("-");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(150);
            Console.Write("\b \b");
            currentTime = DateTime.Now;    // updates the current time
        }

    }

    // creates a method to display a countdown for a given amount of seconds
    public static void Countdown(int countdown){

        for (int i = countdown; i > 0; i--){

            // displays the current number in the countdown
            Console.Write(i);
            Thread.Sleep(1000);         // pauses for 1 second
            Console.Write("\b \b");     // erases the current number
        }
    }

    // creates a method to display the exit message for each activity
    private void ExitMessage(){

        // displays a message to the user that the activity is over
        Console.WriteLine("\nWell done!!");
        DisplayAnimation(3);

        // displays the user the number of seconds they did the activity
        Console.WriteLine($"\nYou have completed another {seconds} seconds of the {activityName}\n");
        DisplayAnimation(3);
    }
}