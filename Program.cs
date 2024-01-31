using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuizApplication
{
    internal class Program
    {
        private static int totalScore = 0;

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quiz!");
            Console.WriteLine("Press Enter to start the quiz ");
            Console.ReadLine();

            AskQuestion("1. What does C# stand for?",
                        "a. C-Sharp",
                        "b. Computer Language",
                        "c. Common Syntax",
                        "d. Code System",
                        "a");

            AskQuestion("2. Which of the following is not a valid data type in C#?",
                        "a. int",
                        "b. char",
                        "c. string",
                        "d. floatpoint",
                        "d");
            AskQuestion("3. What is the purpose of the 'using' statement in C#?",
                       "a. Declaring variables",
                       "b. Memory allocation",
                       "c. Including namespaces",
                       "d. Loop iteration",
                       "c");

            AskQuestion("4. How do you declare a variable in C#?",
                        "a. var x = 10;",
                        "b. int x = 10;",
                        "c. variable x = 10;",
                        "d. x = 10;",
                        "a");

            AskQuestion("5. Which keyword is used to define a class in C#?",
                        "a. struct",
                        "b. class",
                        "c. type",
                        "d. object",
                        "b");

            AskQuestion("6. What is the default access modifier for class members in C#?",
                        "a. private",
                        "b. public",
                        "c. protected",
                        "d. internal",
                        "b");

            AskQuestion("7. What is the correct syntax for a 'for' loop in C#?",
                        "a. for (int i = 0; i < 10; i++)",
                        "b. loop (int i = 0; i < 10; i++)",
                        "c. repeat (int i = 0; i < 10; i++)",
                        "d. iterate (int i = 0; i < 10; i++)",
                        "a");

            AskQuestion("8. In C#, what is the purpose of the 'static' keyword?",
                        "a. Creating dynamic variables",
                        "b. Defining constants",
                        "c. Indicating a method or property belongs to the class, not an instance",
                        "d. Allocating memory at runtime",
                        "c");

            AskQuestion("9. What does the 'try', 'catch', 'finally' blocks in C# handle?",
                        "a. Looping",
                        "b. File operations",
                        "c. Exception handling",
                        "d. Variable declaration",
                        "c");

            AskQuestion("10. How do you comment a single line in C#?",
                        "a. // Comment",
                        "b. /* Comment */",
                        "c. -- Comment",
                        "d. # Comment",
                        "a");

            AskQuestion("11. What is the purpose of the 'get' and 'set' keywords in C#?",
                        "a. Defining constructors",
                        "b. Accessing class methods",
                        "c. Defining properties",
                        "d. Controlling loop iterations",
                        "c");

            AskQuestion("12. Which of the following is a reference type in C#?",
                        "a. int",
                        "b. double",
                        "c. string",
                        "d. char",
                        "c");

            

            Console.WriteLine($"Quiz completed. Your total score is: {totalScore} out of 12.");
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }

        private static void AskQuestion(string question, string optionA, string optionB, string optionC, string optionD, string correctAnswer)
        {
            Console.WriteLine(question);
            Console.WriteLine(optionA);
            Console.WriteLine(optionB);
            Console.WriteLine(optionC);
            Console.WriteLine(optionD);

            Console.Write("Answer: ");

            string userAnswer;
            do
            {
                userAnswer = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userAnswer) && OnlyLetters(userAnswer))
                {
                    if (userAnswer.ToLower() == correctAnswer.ToLower())
                    {
                        Console.WriteLine("Correct!!");
                        totalScore++; 
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Oh! Wrong answer. The correct answer is {correctAnswer.ToLower()}.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a valid input : ");
                }

            } while (!string.IsNullOrWhiteSpace(userAnswer) || OnlyLetters(userAnswer));
        }

        private static bool OnlyLetters(string input)
        {
            foreach (char character in input)
            {
                if (!char.IsLetter(character))
                {
                    return false;
                }
            }
            return true;
        }
    }
}


