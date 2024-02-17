using System;
using System.Data;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays

            //How to declare and assign a value an array

            string[] names = { "John", "Leo", "Smith" };
            int[] ages = { 24, 23, 26 };

            //How to access to elements of an array

            Console.WriteLine("This is before:" + names[0]);

            //How to change the value of an array

            names[0] = "Tapan";
            Console.WriteLine("This is after:" + names[0]);

            //the length property of an array

            Console.WriteLine(names.Length);

            //Looping through an array

            //for loop
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //foreach loop

            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }

            Console.WriteLine("--------------------------------------------------------");
            //1D Array

            int[] numbers = { 1, 2, 3, 6, 8, 10, 12, 15, 16, 15, 23, 26, 28, 35, 36, 38, 34, 50 };
            int countEvennumbers = 0;
            int countOddnumbers = 0;
            int count3and4 = 0;

            Console.WriteLine(Array.IndexOf(numbers, 15));
            Console.WriteLine("--------------------------------------------------------");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Array.Reverse(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //how many numbers are even

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    countEvennumbers++;
                }
                //How many numbers are odd
                if (number % 2 == 1)
                {
                    countOddnumbers++;
                }
                //How many numbers are divisible by 3 and 4 at same time
                if (number % 3 == 0 && number % 4 == 0)
                {
                    count3and4++;
                }
            }
            Console.WriteLine($"There are {countEvennumbers} even numbers, {countOddnumbers} odd numbers and {count3and4} numbers are divisible by 3 and 4.");
            Console.WriteLine("-------------------------------------------------------");

            //2D Array
            //How to create 2D Array
            int[,] nums = { { 1, 2 }, { 2, 3 }, { 3, 4 } }; //3 row and 2 columns

            //How to access elements of 2D aaarray

            Console.WriteLine(nums[0, 1]);

            //Change the value

            nums[0, 1] = 13;
            Console.WriteLine(nums[0, 1]);

            //Length
            Console.WriteLine("Length: " + nums.Length);
            Console.WriteLine(nums.GetLength(0));//print number of rows
            Console.WriteLine(nums.GetLength(1));//print number of columns
            //Looping through 2D Array

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.WriteLine(nums[i, j]);
                }
            }
            Console.WriteLine("------------------------------------------------------");

            //ATM simulation

            string[,] RBC = { { "John", "123", "5000" }, { "Leo", "1234", "50000" }, { "Jane", "1123", "15000" } };
            bool process = true;
            bool login = false;
            int userId = 0;
            while (!login)
            {
                Console.WriteLine("Please Enter your name.");
                string name = Console.ReadLine();

                Console.WriteLine("Please Enter your password.");
                string psw = Console.ReadLine();
                
                //Validate the user

                for (int i = 0; i < RBC.GetLength(0); i++)
                {
                    for (int j = 0; j < RBC.GetLength(1); j++)
                    {
                        if (RBC[i, 0].Equals(name))
                        {
                            if (RBC[i, 1].Equals(psw))
                            {
                                Console.WriteLine("Success");
                                login = true;
                                userId = i;
                                break;
                            }
                        }
                    }
                }
            }
            
            
            while (process)
            {
                
                //If successful,then we can present a few choice.
                if (login)
                {
                    Console.WriteLine("1.Check balance. \n2.Withdraw cash. \n3.Deposit \n4.Exit");
                    Console.WriteLine("Please enter your choice: ");
                    string option = Console.ReadLine();

                    if (option == "1")
                    {
                        //Check balance
                        Console.WriteLine("your balance is: " + RBC[userId, 2]);
                    }
                    else if (option == "2")
                    {
                        //Withdraw money
                        Console.WriteLine("please enter the amount: ");
                        string withdraw = Console.ReadLine();
                        RBC[userId, 2] = Convert.ToString(Convert.ToInt32(RBC[userId, 2]) - Convert.ToInt32(withdraw));
                        Console.WriteLine("Your balance is " + RBC[userId, 2]);
                    }
                    else if (option == "3")
                    {
                        //Deposite Money
                        Console.WriteLine("please enter the amount: ");
                        string deposite = Console.ReadLine();
                        RBC[userId, 2] = Convert.ToString(Convert.ToInt32(RBC[userId, 2]) + Convert.ToInt32(deposite));
                        Console.WriteLine("Your balance is " + RBC[userId, 2]);
                    }
                    else if (option == "4")
                    {
                        //Cancle/ Exit
                        process = false;
                    }
                }
            }
            Console.WriteLine("-----------------------------------------");
            
            
            
            

        }
    }
}
