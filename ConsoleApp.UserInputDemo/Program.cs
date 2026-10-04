// Declare variables for user input
string firstName;
string lastName;
int age;
int retirementAge = 65;

// Prompt the user for input
Console.Write("Enter your first name: ");
// Read the user's name
firstName = Console.ReadLine();
Console.Write("Enter your last name: ");
lastName = Console.ReadLine();

Console.WriteLine("Enter your age: ");
age = int.Parse(Console.ReadLine());

// Process the input and display a message
int workingYearsLeft = retirementAge - age;

if (workingYearsLeft > 0)
{
    Console.WriteLine($"Hello {firstName} {lastName}, you have {workingYearsLeft} years left until retirement.");
}
else
{
    Console.WriteLine($"Hello {firstName} {lastName}, you are already at or past retirement age.");
}
