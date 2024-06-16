using System;

// defines the BreathingActivity class
public class BreathingActivity : Activity {

    // creates an empty constructor for the BreathingActivity class
    public BreathingActivity(string activityName, string description, int seconds) : base(activityName, description, seconds){

    }

    // creates a method to run the Breathing activity
    public void Breathing(){

        Console.Clear();        // clears the console
        Console.WriteLine("Get ready...");      // displays a message and countdown to the user
        Activity.DisplayAnimation(5);
        Console.WriteLine("\n");

        BreatheTimer();         // runs the BreatheTimer method
    }

    // creates a method to run the timer for the Breathing activity
    private void BreatheTimer(){

        // creates a variable for when the loop will end
        DateTime futureTime = DateTime.Now.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;

        // creates a loop that will continue until the current time is greater than the future time
        while (currentTime < futureTime){
            
            // displays a message and countdown for the user to breathe in
            Console.Write("Breathe in...");
            Activity.Countdown(4);
            Console.WriteLine();

            // displays a message and countdown for the user to breathe out
            Console.Write("Breathe out...");
            Activity.Countdown(6);
            Console.WriteLine("\n");

            // updates the current time
            currentTime = DateTime.Now;
        }
    }
}