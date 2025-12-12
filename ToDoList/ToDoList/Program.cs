// int number = 0;
// 

// WHILE LOOP

// while (number < 10)
// {
//     number++;
//     Console.WriteLine($"Number is {number}");
// }

// DO WHILE LOOP 

// string word;
// do
// {
//     Console.WriteLine("Enter a word longer than 10 letters");
//     word = Console.ReadLine();
// } while (word.Length <= 10);
// 
// Console.WriteLine("The loop is finished");

// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine("Hello");
// }
// 
// int userNumber;
// 
// do
// {
//     Console.WriteLine("Enter a number larger than 10:");
//     var userInput = Console.ReadLine();
// 
//     if (userInput == "stop")
//     {
//         break;
//     }
// 
//     bool isParsableToInt = userInput.All(char.IsDigit);
//     if (!isParsableToInt)
//     {
//         userNumber = 0;
//         continue;
//     }
// 
//     userNumber = int.Parse(userInput);
// } while (userNumber <= 10);
// 

// ARRAYS
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

int[] numbers = new int[3];
Console.WriteLine($"Array size : {numbers.Length}");
Console.WriteLine($"Value in position 0 : {numbers[0]}");
Console.WriteLine($"Value in position 1 : {numbers[1]}");
Console.WriteLine($"Value in position 2 : {numbers[2]}");

numbers[0] = 35;
numbers[1] = 44;
numbers[2] = 68;

Console.WriteLine($"Value in position 0 : {numbers[0]}");
Console.WriteLine($"Value in position 1 : {numbers[1]}");
Console.WriteLine($"Value in position 2 : {numbers[2]}");

Console.WriteLine($"Print the value before the last value of array : Length - 2 : ^2 : {numbers[^2]}");

Console.ReadKey();


public class Exercise
    {
        public List<string> GetOnlyUpperCaseWords(List<string> words)
        {
            List<string> result = new List<string>();
    
            foreach(string word in words)
            {
                if (word.Equals(word.ToUpperInvariant()) && !result.Contains(word))
                {
                    result.Add(word);
                }
            }
            
            return result;
        }
    }


// 
// Console.WriteLine("Hello !");
// Console.WriteLine("[S]ee all TODOs");
// Console.WriteLine("[A]dd a TODO");
// Console.WriteLine("[R]emove a TODO");
// Console.WriteLine("[E]xit");
// 
// string userChoice = Console.ReadLine();
// 
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

//  switch (userChoice.ToUpper())
//  {
//      case "S":
//          PrintSelectedOption("See all TODOs");
//          break;
//      case "A":
//          PrintSelectedOption("Add a TODO");
//          break;
//      case "R":
//          PrintSelectedOption("Remove a TODO");
//          break;
//      case "E":
//          PrintSelectedOption("Exit");
//          break;
//      default:
//          Console.WriteLine("Invalid choice");
//          break;
//  }
//  
//  
//  void PrintSelectedOption(string selectedOption)
//  {
//      Console.WriteLine($"Selected option: {selectedOption}");
//  }
//  

// 
// int Add(int a, int b)
// 
//    return a + b;
// 
// 
// Console.WriteLine($"10 + 5 = {Add(10, 5)}");
// 



// Switch Statement :
// char ConvertPointsToGrade(int points)
// 
//    switch (points)
//    {
//        case 10:
//        case 9:
//            return 'A';
//        case 8:
//        case 7:
//        case 6:
//            return 'B';
//        case 5:
//        case 4:
//        case 3:
//            return 'C';
//        case 2:
//        case 1:
//            return 'D';
//        case 0:
//            return 'E';
//        default:
//            return '!';
//    }
// 

// Switch Expression
// char ConvertPointsToGrade(int points)
// {
//     return points switch
//     {
//         10 or 9 => 'A',
//         8 or 7 or 6 => 'B',
//         5 or 4 or 3 => 'C',
//         2 or 1 => 'D',
//         0 => 'E',
//         _ => '!'
//     };
// }

