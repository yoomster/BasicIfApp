//bool isComplete = true;

//if (!isComplete)
//{
//    Console.WriteLine("Good job, homework is done");
//}

//else
//{
//    Console.WriteLine("No slacking, do your homework!");
//}

//Console.WriteLine("End of program");

Console.Write("Please enter your first name: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "adam")
{
    Console.WriteLine("Hello my Mr. Akil");
}
else if (firstName.ToLower() == "teddy")
{
    Console.WriteLine("Hello Mr. Saurus-Rex");
}
else if (firstName.ToLower() == "snuggles")
{
    Console.WriteLine("Hello Mr. Snowflake");
}
else
{
    Console.WriteLine($"Hello {firstName}! ");
}

Console.Write("How do you do? (Please type good or bad): ");
string? howIsIt = Console.ReadLine();

if (howIsIt.ToLower() == "good")
{
    Console.WriteLine("I am glad! Enjoy the rest of your day!");
}
else if (howIsIt.ToLower() == "bad")
{
    Console.WriteLine("I'm sorry you're not feeling so good. Remember, after rain comes sunshine!");
}
else
{
    Console.WriteLine("I'm sorry, I did catch that.");
}

Console.WriteLine("End of program.");