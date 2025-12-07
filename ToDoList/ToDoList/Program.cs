using System.ComponentModel;

Console.WriteLine("Hello !");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();

// Console.WriteLine($"User input: {userChoice}");

//todo: handle user's input.
/*
This is a multiple line comment.
*/
// 
// // Boolean and logical operation
// bool someBoolean = true;
// var someOtherBoolean = false;
// bool isUserInputAbc = userChoice == "ABC";
// bool isUserInputNotAbc = userChoice != "ABC";
// bool isUserInputNotAbc2 = !(userChoice == "ABC");
// 
// var number = 10;
// var isLargerThan5 = number > 5;
// var isSmallerThan10 = number < 10;
// var isLargerOrEqualTo10 = number >= 10;
// var isSmallerOrEqualTo6 = number <= 6;
// 
// var is10Modulo3EqualTo1 = 10 % 3 == 1;
// var isEven = 10 % 2 == 0;
// 
// // AND and OR Operator
// var isLargerThan4andSmallerThan9 = number > 4 && number < 9;
// var isEqualTo2OrLargerThan6OrSmallerThan200 = number == 6 || number > 6 || number < 200;
// var isEqualTo123OrEvenAndSmallerThan20 = number == 123 || (number % 2 == 0 && number < 20);
// 
// // IF / ELSE Statements
// if (userChoice.Equals("ABC"))
// {
//     Console.WriteLine("User typed ABC");
// }
// else
// {
//     Console.WriteLine("Nope");
// }
// 

// if (userChoice.Equals("S"))
// {
//     PrintSelectedOption("See all TODOs");
// }
// else if (userChoice.Equals("A"))
// {
//     PrintSelectedOption("Add a TODO");
// }
// else if (userChoice.Equals("R"))
// {
//     PrintSelectedOption("Remove a TODO");
// }
// else if (userChoice.Equals("E"))
// {
//     PrintSelectedOption("Exit");
// }
// 
// 
// void PrintSelectedOption(string selectedOption)
// {
//     Console.WriteLine($"Selected option: {selectedOption}");
// }

int Add(int a, int b)
{
    return a + b;
}

Console.WriteLine($"10 + 5 = {Add(10, 5)}");

