Console.WriteLine("Hello !");

// Input for two parameters of calculator

Console.WriteLine("Input the first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int number2 = int.Parse(Console.ReadLine());

// Ask type of calculation

Console.WriteLine("What do you want to do with those numbers ?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubstract");
Console.WriteLine("[M]ultiply");
string choice = Console.ReadLine().ToUpper();

// Calculation

if (choice.Equals("A"))
{
    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
}
else if (choice.Equals("S"))
{
    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
}
else if (choice.Equals("M"))
{
    Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
}
else
{
    Console.WriteLine("Invalid option");
}

Console.WriteLine("Press any key to close");
var close = Console.ReadLine();
return;