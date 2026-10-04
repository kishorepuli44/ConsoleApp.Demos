// Declare variables for user input
string name;
int age;
int retirementAge = 65;

// Prompt the user for input
Console.Write("Enter your name: ");
// Read the user's name
name = Console.ReadLine();

Console.WriteLine("Enter your age: ");
age = int.Parse(Console.ReadLine());

// Process the input and display a message
int workingYearsLeft = retirementAge - age;

if (workingYearsLeft > 0)
{
    Console.WriteLine($"Hello {name}, you have {workingYearsLeft} years left until retirement.");
}
else
{
    Console.WriteLine($"Hello {name}, you are already at or past retirement age.");
}
