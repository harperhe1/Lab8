using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {

        static int promptUserAndReadInteger()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number 1-19");
                    int num = int.Parse(Console.ReadLine());

                    if (num > 0 && num < 20)
                    {
                        return num;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                catch (FormatException)//catching if they don't put in a number
                {
                    Console.WriteLine("That is invalid data. Please try again (enter number 1-19)");
                }
                catch (IndexOutOfRangeException)//catching if they don't put in a number between 1-19
                {
                    Console.WriteLine("That is invalid data. (enter a number 1-19) ");
                }
            }
        }
        static void Main(string[] args)
        {
            string doAgain;
            bool cont = true;
            while (cont)//need while if they want to continue the whole way thru the program
            {

                Console.WriteLine("Welcome to our C# class" + (" "));

                string[] students = new string[] { "Andrea", "Anthony", "Brian", "Camille", "Clayton", "Damacious", "David", "Evan", "Heather", "Jacky", "Johnathan", "Katie", "Levi", "Mauricio", "Nicholas", "Rudy", "SeanO", "Steve", "Ty" };
                string[] hometowns = new string[] { "Akron", "Ann Arbor", "Boston", "Carson", "Cleveland", "Detroit", "Dayton", "Edwardsburg", "Houston", "Jackson", "Jacksonville", "Kent", "Lansing", "Mason", "New Mexico", "Rochester", "Salem", "San Diego", "Tampa" };
                string[] favoriteFood = new string[] { "apples", "apricots", "bagels", "cake", "carrots", "doritos", "dim sum", "eggs", "ham", "jerky", "jelly beans", "kale", "lettuce", "meat", "noodles", "roast beef", "salami", "salmon", "tater tots" };

                int userInput = promptUserAndReadInteger(); //method to store user inputs
                string numericalStudent = students[userInput - 1];
                Console.WriteLine("Student " + userInput + " is " + numericalStudent);
                Console.WriteLine("What would you like to know about " + numericalStudent + "? (enter hometown or favorite food)");
                string choices = Console.ReadLine().ToLower();
                bool repeat = true;


                while (repeat)//need while so they will either put in hometown or favorite food
                {


                    if (choices == "hometown" || choices == "hometowns")
                    {
                        Console.WriteLine(numericalStudent + " is from " + hometowns[userInput - 1]);
                        repeat = false;

                    }

                    else if (choices == "favorite food")
                    {
                        Console.WriteLine(numericalStudent + " loves " + favoriteFood[userInput - 1]);
                        repeat = false;
                    }

                    else
                    {
                        Console.WriteLine("That data does not exist. Please try again.(enter hometown or favorite food):");
                        choices = Console.ReadLine();
                        repeat = true;

                    }
                }
                bool cont2 = true;
                while (cont2)//need while to see if they want to continue
                {
                    Console.WriteLine("Continue?(y/n)");
                    doAgain = Console.ReadLine().ToLower();
                    if (doAgain == "y")
                    {
                        cont2 = false;
                    }
                    else if (doAgain == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        cont2 = false;
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again!");
                    }
                    
                }

            }
            Console.ReadLine();
        }
    }
}


