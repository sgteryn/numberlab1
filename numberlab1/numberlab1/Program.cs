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
