// Variables Demo

/* Different data types in C#

text - string
integer - int
decimal - decimal, float, double
logical - bool
 
 */

string name = "John Doe"; // string
int age = 30; // integer
decimal salary = 50000.00m; // decimal
bool isEmployed = true; // logical

// You can also use string concatenation to display the values of the variables
Console.WriteLine("Name: " + name);

// You can also use string interpolation to display the values of the variables
Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}, Is Employed: {isEmployed}");

// String formatting can also be used to display the values of the variables
Console.WriteLine("Name: {0}, Age: {1}, Salary: {2}, Is Employed: {3}", name, age, salary, isEmployed);