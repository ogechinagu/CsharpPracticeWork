namespace PracticeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a question (1-16) or press 'Q' to quit:\r\n");
                Console.WriteLine("1) Write a program that divides a number entered by the user by 2\r\n");
                Console.WriteLine("2) Write a program that will multiply any two numbers and display the result\r\n");
                Console.WriteLine("3) Write a program that will ask the user to enter any two numbers and display the division result.\r\n");
                Console.WriteLine("4) Write a program that will find the exponential of two numbers and display the result.\r\n");
                Console.WriteLine("5) Write a program that displays the multiplication table 6.\r\n");
                Console.WriteLine("6) Write a program that displays any times table the user requests.\r\n");
                Console.WriteLine("7) Write a program to ask the user what 24+9 is. Say “Excellent” if they get it right.\r\n");
                Console.WriteLine("8) Write a program to ask the user “how many in a bakers dozen?” and say “most excellent” if they get it right.\r\n");
                Console.WriteLine("9) Write a program to ask the user to enter their age. If their age is under 18 then say “Sorry, this film is not for you”.\r\n");
                Console.WriteLine("10) Write a program to ask the user for two numbers. Compare the first with the second and then print out one of three messages. Either the numbers are equal, the first is bigger, or the second is bigger. You will need more than one IF to solve this one.\r\n");
                Console.WriteLine("11) Write a program which asks the user to enter their password. If they enter the word “PASSWORD” then display the message “Welcome to the treasure”, otherwise display a message which says “go away, it’s all mine”.\r\n");
                Console.WriteLine("12) Write a program which asks the user to enter a number between 1 and 10. If the number entered is out with this range then display a message “Sorry…out of range”.\r\n");
                Console.WriteLine("13) Write a program that asks for 5 numbers, calculates the mean average and then rounds it down. Display the result on the screen.\r\n");
                Console.WriteLine("14) Write a program that checks a username against a stored value. How the user enters the username should NOT be case-sensitive.\r\n");
                Console.WriteLine("15) Adapt program 1 so that it also takes in a password. If the user enters spaces after the password, the computer will trim them out automatically.\r\n");
                Console.WriteLine("16) Write a program that will check if a phone number is of the correct length.\r\n");

                string? input = Console.ReadLine();
                if (input.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Exit the program if the user enters 'Q'
                }
                else if (int.TryParse(input, out int selectedQuestion) && selectedQuestion >= 1 && selectedQuestion <= 16)
                {
                    Console.Clear();
                    RunSelectedQuestion(selectedQuestion);
                    Console.WriteLine("Press Enter to go back to the list of questions.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 16 or 'Q' to quit.");
                }
            }
        }


        static void RunSelectedQuestion(int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    Question1();
                    break;
                case 2:
                    Question2();
                    break;
                case 3:
                    Question3();
                    break;
                case 4:
                    Question4();
                    break;
                case 5:
                    Question5();
                    break;
                case 6:
                    Question6();
                    break;
                case 7:
                    Question7();
                    break;
                case 8:
                    Question8();
                    break;
                case 9:
                    Question9();
                    break;
                case 10:
                    Question10();
                    break;
                case 11:
                    Question11();
                    break;
                case 12:
                    Question12();
                    break;
                case 13:
                    Question13();
                    break;
                case 14:
                    Question14();
                    break;
                case 15:
                    Question15();
                    break;
                case 16:
                    Question16();
                    break;
                default:
                    Console.WriteLine("Selected question is not implemented!");
                    break;
            }
        }

        // Implement the methods for each question
        static void Question1()
        {
            Console.WriteLine("Enter a number:");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                double result = number / 2;
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static void Question2()
        {
            Console.WriteLine("Enter the first number:");
            if (double.TryParse(Console.ReadLine(), out double number1))
            {
                Console.WriteLine("Enter the second number:");
                if (double.TryParse(Console.ReadLine(), out double number2))
                {
                    double result = number1 * number2;
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number. Please enter a valid number.");
            }
        }

        static void Question3()
        {
            Console.WriteLine("Enter the first number:");
            if (double.TryParse(Console.ReadLine(), out double number1))
            {
                Console.WriteLine("Enter the second number:");
                if (double.TryParse(Console.ReadLine(), out double number2) && number2 != 0)
                {
                    double result = number1 / number2;
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number. Please enter a valid number (non-zero).");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number. Please enter a valid number.");
            }
        }

        static void Question4()
        {
            Console.WriteLine("Enter the base number:");
            if (double.TryParse(Console.ReadLine(), out double number1))
            {
                Console.WriteLine("Enter the exponent:");
                if (double.TryParse(Console.ReadLine(), out double number2))
                {
                    double result = Math.Pow(number1, number2);
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input for the exponent. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the base number. Please enter a valid number.");
            }
        }

        static void Question5()
        {
            int tableOf = 6;
            for (int i = 1; i <= 12; i++)
            {
                int result = tableOf * i;
                Console.WriteLine($"{tableOf} * {i} = {result}");
            }
        }

        static void Question6()
        {
            Console.WriteLine("Enter the number for the times table:");
            if (int.TryParse(Console.ReadLine(), out int tableOf))
            {
                for (int i = 1; i <= 12; i++)
                {
                    int result = tableOf * i;
                    Console.WriteLine($"{tableOf} * {i} = {result}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static void Question7()
        {
            Console.WriteLine("What is 24 + 9?");
            if (int.TryParse(Console.ReadLine(), out int answer) && answer == 33)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is 33.");
            }
        }

        static void Question8()
        {
            Console.WriteLine("How many are there in a bakers dozen?");
            string input = Console.ReadLine().Trim();
            if (input.Equals("13", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Most excellent!");
            }
            else
            {
                Console.WriteLine("Incorrect. A bakers dozen contains 13 items.");
            }
        }

        static void Question9()
        {
            Console.WriteLine("Enter your age:");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 18)
                {
                    Console.WriteLine("Sorry, this film is not for you.");
                }
                else
                {
                    Console.WriteLine("Enjoy the film!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age (a whole number).");
            }
        }

        static void Question10()
        {
            Console.WriteLine("Enter the first number:");
            if (double.TryParse(Console.ReadLine(), out double number1))
            {
                Console.WriteLine("Enter the second number:");
                if (double.TryParse(Console.ReadLine(), out double number2))
                {
                    if (number1 == number2)
                    {
                        Console.WriteLine("The numbers are equal.");
                    }
                    else if (number1 > number2)
                    {
                        Console.WriteLine("The first number is bigger.");
                    }
                    else
                    {
                        Console.WriteLine("The second number is bigger.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number. Please enter a valid number.");
            }
        }

        static void Question11()
        {
            Console.WriteLine("Enter your password:");
            string? password = Console.ReadLine().Trim();

            if (password.Equals("PASSWORD", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Welcome to the treasure!");
            }
            else
            {
                Console.WriteLine("Go away, it's all mine.");
            }
        }

        static void Question12()
        {
            Console.WriteLine("Enter a number between 1 and 10:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number >= 1 && number <= 10)
                {
                    Console.WriteLine($"You entered: {number}");
                }
                else
                {
                    Console.WriteLine("Sorry... out of range.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static void Question13()
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Enter number {i}:");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--; // Decrement i to retry for the same number.
                }
            }

            double average = sum / 5.0; // Calculate the mean average
            int roundedAverage = (int)Math.Floor(average); // Round down the average
            Console.WriteLine($"Mean average rounded down: {roundedAverage}");
        }

        static void Question14()
        {
            string storedUsername = "OgeGod";
            Console.WriteLine("Enter your username:");
            string? inputUsername = Console.ReadLine();

            if (inputUsername.Equals(storedUsername, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Username correct.");
            }
            else
            {
                Console.WriteLine("Incorrect username.");
            }
        }

        static void Question15()
        {
            Console.WriteLine("Enter a number:");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine().Trim();

                if (password.Equals("your_password", StringComparison.OrdinalIgnoreCase))
                {
                    double result = number / 2;
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Access denied.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static void Question16()
        {
            const int validPhoneNumberLength = 11;
            Console.WriteLine("Enter the phone number:");
            string? phoneNumber = Console.ReadLine().Replace(" ", "");

            if (phoneNumber.Length == validPhoneNumberLength && long.TryParse(phoneNumber, out _))
            {
                Console.WriteLine("Valid phone number.");
            }
            else
            {
                Console.WriteLine("Not a vilid phone number.");
            }
        }
    }
}