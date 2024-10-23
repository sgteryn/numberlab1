// See https://aka.ms/new-console-template for more information

// prompt user to enter an integer between 1 and 100 inclusive

Console.WriteLine("Enter an integer between 1 and 100.");

    // Display the associated result

int userInteger = Convert.ToInt32(Console.ReadLine());

// Use if/else statements to take different actions depending on user input.
// Given an integer entered by a user, perform the following conditional actions:
//If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.
if (userInteger % 2 != 0 && userInteger > 60)
{
    Console.WriteLine(" {} . Odd and less than 60.", userInteger);
}
else if (userInteger % 2 == 0 && userInteger >= 2 && userInteger <= 24)
//If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
{
    Console.WriteLine("Even and less than 25");
}
else if (userInteger % 2 == 0 && userInteger >= 26 && userInteger <= 60)
//If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
{
    Console.WriteLine("Even and between 26 and 60 inclusive");
}
else if (userInteger % 2 == 0 && userInteger > 60) 
// If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
{
    Console.WriteLine(" {}. Even and greater than 60.", userInteger);
}
else if (userInteger % 2 != 0 && userInteger > 60)
// If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”
{
    Console.WriteLine("User Input is {} . Odd and greater than 60.", userInteger);
}
else
{
    Console.WriteLine("Input Invalid");
}


//How can if statements be used to cover multiple situations?
//Can you show an example.

// If statements can be used to cover multiple situations by using else if until
// the last possible situation whcih is written with else.
//An example would be if you were given a task of looking for an object and
//there are multiple places this object could be. Directions for finding the
//might look like this: Look for the paper in my office on the desk. If you
//find the object stop looking. Else if you do not find the object on the desk
//look in the left drawer of the desk. if you find the paper there stop looking.
//else the paper is in the brief case. Another example would be deciding what
//to wear in different weather conditions. One may use if statements to describe
//the weather and what should be worn under each range of weather situations. 