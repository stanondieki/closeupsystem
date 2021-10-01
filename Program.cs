using System;

namespace closeupsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO AVERTZ VOTING SYSTEM");
            Console.WriteLine("Enter your first name please!");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter your second name please!");
            var secondName = Console.ReadLine();
            // You can use interpolation to concatenate strings
            var name = $"{firstName} {secondName}";

            Console.WriteLine("Where do you live");
            var residencyArea = Console.ReadLine();

            Console.WriteLine("Are you over 18 years of age (YES/NO)");
            var answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "y")
            {
                Console.WriteLine("The voting process awaits you");
            }
            if (answer == "no" || answer == "n")
            {
                Console.WriteLine("You may not qualify for the voting process");
            }

            Console.WriteLine("Enter your age please");
            _ = int.TryParse(Console.ReadLine(), out int age);

            Console.WriteLine("Enter your first number of choice just for a short calculation");
            var firstNumber = Console.ReadLine();
            Console.WriteLine("Enter the second number please");
            var secondNumber = Console.ReadLine();

            Console.WriteLine("Enter opertation please (-, +, *, /)");
            var operation = Console.ReadLine();

            var firstNum = int.Parse(firstNumber);
            var secondNum = int.Parse(secondNumber);

            int jibu = 0;
            switch (operation)
            {
                case "+":
                    jibu = firstNum + secondNum;
                    break;
                case "-":
                    jibu = firstNum - secondNum;
                    break;
                case "*":
                    jibu = firstNum * secondNum;
                    break;
                case "/":
                    jibu = firstNum / secondNum;
                    break;
            }
            Console.WriteLine($"Your answer is: {jibu}");

            Console.WriteLine("Enter the number for your best day of the week(1, 2, 3, ...7)");
            _ = Enum.TryParse(Console.ReadLine(), out WeekEnum bestDay);
            Console.WriteLine($"Your best day is: {bestDay}");

            if (age >= 18)
            {
                Console.WriteLine("Conratulations! \nYou are eligible to vote in our system without hesitating directly secure your voting card as early as now. \nThank you very much for trusting our system");
            }
            else
            {
                Console.WriteLine("Dear user we are sorry because you have not yet attained your voting age. \nOnly people who are older than 18 are eligible to vote. \nThank you for the trial  come again next time as far as the system is concerned.");
            }

            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"Your area of residency is: {residencyArea}");
            Console.WriteLine($"Your age is: {age}");
            Console.WriteLine("KISII COUNTY");
            Console.WriteLine("KENYAN");
            Console.WriteLine("THANK YOU VERY MUCH FOR CHOOSING OUR SYSTEM!!");
        }
    }
}
