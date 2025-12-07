Console.WriteLine("Hello !");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();
Console.WriteLine($"User input: {userChoice}");

//todo: handle user's input.
/*
This is a multiple line comment.
*/

// Boolean and logical operation
bool someBoolean = true;
var someOtherBoolean = false;
bool isUserInputAbc = userChoice == "ABC";
bool isUserInputNotAbc = userChoice != "ABC";
bool isUserInputNotAbc2 = !(userChoice == "ABC");

var number = 10;
var isLargerThan5 = number > 5;
var isSmallerThan10 = number < 10;
var isLargerOrEqualTo10 = number >= 10;
var isSmallerOrEqualTo6 = number <= 6;

var is10Modulo3EqualTo1 = 10 % 3 == 1;
var isEven = 10 % 2 == 0;