using System;

//Nor this
namespace CSharpIntro
{
    //? I dont even know what this does
    class Program
    {
        //Static = Entry Point 
        //Void bc char and strings
        //Main(String[] args)
        //https://www.tutorialspoint.com/csharp/csharp_strings.htm
        static void Main(string[] args)
        {
            //https://www.tutorialspoint.com/csharp/csharp_variables.htm (useful for future)
            //Byte Decleration: sample1 with an initial value of 0x3A and sample2 with an initial value of 58
            byte sample1 = 0x3A, sample2 = 58;
            //Int Varibles Heart Rate = 85, Age = 0, and Choice = 2
            int heartRate = 85, choice = 2, age = 0; ;
            //Double Declaration Deposits = 135002796 and Distance = 129.763001
            double deposits = 135002796, distance = 129.763001;
            //Float Declaration Acceleration = 9.8f and Mass = 14.6f
            float acceleration = 9.8f, mass = 14.6f;
            //Boolean Loops set to true Lost = True and Expensive = True
            bool lost = true, expensive = true;
            //Char Declaration \u222B. Is this supposed to be a "?" 
            char integral = '\u222B';
            //Strings (Thank god C# is easier than C for this)
            String Greeting = "Hello", Name = "Karen";
            //Compare sample1 to sample2 and if they are equal display “The samples are equal.” otherwise display “The samples are not equal.”
            //https://www.tutorialspoint.com/csharp/csharp_strings.htm
            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not equal.");
            }
            //If heartRate is greater than equal to 40 and less than equal to 80 display “Heart rate is normal.” otherwise display “Heart rate is not normal.”
            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }
            //If deposits is greater than or equal to 100000000 display “You are exceedingly wealthy.” otherwise display “Sorry you are so poor.”
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }
            //Declare a variable called force that is assigned to the mass times the acceleration. 
            //The force variable must be of the same type as the type that results from the multiplication of mass and acceleration.
            double force = mass * acceleration;
            Console.WriteLine("Force=" + force.ToString("#.000"));
            /*Display the value of distance followed by “ is the distance.”*/
            Console.WriteLine(distance + " is the distance.");
            //Using lost and expensive display “I am really sorry!
            //I will get the manager.” if lost and expensive are both true and
            //“Here is coupon for 10% off.” if lost is true and expensive is false.
            if (lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost == true && expensive == false)
            {
                Console.WriteLine("Here is coupon for 10% off.");
            }
            else if (lost == false && expensive == true)
            {
                Console.WriteLine("I am really sorry!");
            }
            //Use switch
            //You chose 1. if choice is 1, You chose 2. if choice is 2,
            //You chose 3. if choice is 3, and You made an unknown choice.
            //If choice is something other than 1, 2, or 3.
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }

            //Write the ? integral symbol.
            Console.WriteLine(integral + " is an integral.");
            //Using a “for” loop count from 5 to 10
            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine("i = " + i);
            }
            //Age - While loop that will evnetually break due to age++
            while (age < 6)
            {
                Console.WriteLine("age = " + age);
                age++;
            }
            //Hello Karen
            Console.WriteLine(Greeting + " " + Name);

            // Keep the console window open in debug mode. Push key to exit.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
