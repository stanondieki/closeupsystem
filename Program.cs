using System;

namespace closeupsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO AVERTZ VOTING SYSTEM");
            Console.WriteLine("Enter your first name please!");
            var firstName=Console.ReadLine();
            Console.WriteLine("Enter your second name please!");
            var secondName=Console.ReadLine();
            var name=firstName+secondName;

            Console.WriteLine("Where do you live");
                var residencyArea=Console.ReadLine();

            Console.WriteLine( "Are beyond 18 years of age (YES/NO)");
            var answer=Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("The voting process awaits you");
            }
            if (answer== "no")
            {
                Console.WriteLine("You may not qualify for the voting process");
            }

            Console.WriteLine("Enter your age please");
            var age=Console.ReadLine(); 
             
            var newAge=int.Parse(age);

            Console.WriteLine("Enter your first number of choice just for a short calculation");
            var firstNumber=Console.ReadLine();
            Console.WriteLine("Enter the second number please");
            var secondNumber=Console.ReadLine();

            Console.WriteLine("Enter opertation please(-, +, *, /)");
            var operation=Console.ReadLine();
            
            var firstNum=int.Parse(firstNumber);    
            var secondNum=int.Parse(secondNumber);  


            if(operation=="+")
            {
                int jibu = firstNum + secondNum;
                Console.WriteLine("Your answer is:"+ jibu);
            }
            if(operation=="-")
            {
                int jibu = firstNum - secondNum;    
                Console.WriteLine("Your answer is:"+jibu);
            }
            if(operation=="*")
            {
                int jibu = firstNum * secondNum;    
                Console.WriteLine("Your answer is:"+jibu);  
            }
            if(operation=="/")
            {
                int jibu = firstNum /secondNum;    
                Console.WriteLine("Your answer is:"+jibu);
            }

            Console.WriteLine("Enter the number for your best day of the week(1, 2, 3, ...7)");
            var bestday=Console.ReadLine(); 

            if (bestday== "1")
            {
                Console.WriteLine("Your best day is: Monday");
            }
            if(bestday== "2")
            {
                Console.WriteLine("Your best day is: Tuesday");
            }
            if(bestday== "3")
            {
                Console.WriteLine("Your best day is: Wednesday");
            }
            if(bestday== "4")
            {
                Console.WriteLine("Your best day is: Thursday");
            }
            if(bestday== "5")
            {
                Console.WriteLine("Your best day is: Friday");
            }
            if(bestday== "6")
            {
                Console.WriteLine("Your best day is: Saturday");
            }
            if(bestday=="7")
            {
                Console.WriteLine("your best day is: Sunday");
            }


            if(newAge >=18)
            {
                Console.WriteLine("Conratulations! You are eligible to vote in our system without hesitating directly secure your voting card as early as now. Thank ver much for trusting our system");
            }
            else
            {
                Console.WriteLine("Dear user we are sorry because you have not yet attained your voting age. Only people who are beyond 18 are eligible to vote. Thank you for the trial  come again next time as far as the system is concerned.");
            }

            Console.WriteLine("Your name is:"+name);
            Console.WriteLine("Your area of residency is:"+residencyArea);
            Console.WriteLine("Your age is:"+age);
            Console.WriteLine("KISII COUNTY");
            Console.WriteLine("KENYAN");
            Console.WriteLine("THANK YOU VERY MUCH FOR CHOOSING OUR SYSTEM!!");


        }
    }
}
