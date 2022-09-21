using System;
using Business.Triangles;
using Business.Human;
using Business.PokeApi;
using System.Collections.Generic;
using Business.Models;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool isFistTime = true;

                // Diff. ways to declare strings
                string repeat = "Do you want to see another method? Y - N";
                string restart = "Y";
                string welcome = "Choose the method you want to initialize" + "\r\n" +
                    "-----------------------------------------";
                string main = @"1. Simplestatements
2. Complexstatements
3. Demoifelse
4. Demoswitch
5. Loops
6. Overloadedmethods
7. Overloadedconstructors
8. Inherenting
9. Get a Pokemon based on one color
Enter the number:
";

                Console.WriteLine(welcome);
                Console.WriteLine(main);

                do
                {
                    if (!isFistTime)
                    {
                        Console.WriteLine("Select another number");
                    }
                    string chosennum = Console.ReadLine();
                    isFistTime = false;
                    switch (chosennum)
                    {
                        case "1":
                            Simplestatements();
                            Console.WriteLine(repeat);
                            restart = Console.ReadLine().ToUpper();
                            break;
                        case "2":
                            Complexstatements();
                            Console.WriteLine(repeat);
                            restart = Console.ReadLine().ToUpper();
                            break;
                        case "3":
                            Demoifelse();
                            Console.WriteLine(repeat);
                            restart = Console.ReadLine().ToUpper();
                            break;
                        case "4":
                            Demoswitch();
                            Console.WriteLine(repeat);
                            restart = Console.ReadLine().ToUpper();
                            break;
                        case "5":
                            Loops();
                            Console.WriteLine(repeat);
                            restart = Console.ReadLine().ToUpper();
                            break;
                        case "6":
                            Console.WriteLine(Multiplication(3.44, 4.77));
                            Console.WriteLine(repeat);
                            restart = Console.ReadLine().ToUpper();
                            break;
                        case "7":
                            Triangle isoscelestriangle = new Triangle();
                            Triangle equilateraltriangle = new Triangle(2);
                            Console.WriteLine(isoscelestriangle.GetTriangle());
                            Console.WriteLine(equilateraltriangle.GetTriangle());
                            Console.WriteLine(repeat);
                            restart = Console.ReadLine().ToUpper();
                            break;
                        case "8":
                            GetStats();
                            Console.WriteLine(repeat);
                            restart = Console.ReadLine().ToUpper();
                            break;
                        case "9":
                            Console.WriteLine("Write a color:" + "\r\n" +
                                @"1. black
2. blue
3. brown
4. gray
5. green
6. pink
7. purple
8. red
9. white
10. yellow
");
                            string color = Console.ReadLine().ToLower();
                            List<string> pokemon = PokeApi.GetPokemon(color).Result;
                            Console.WriteLine(string.Join(", ", pokemon));
                            Console.ReadKey();
                            Console.WriteLine(repeat);
                            restart = Console.ReadLine().ToUpper();
                            break;
                        default:
                            Console.WriteLine("You haven't choose one of the options");
                            Console.WriteLine(repeat);
                            restart = Console.ReadLine().ToUpper();
                            break;
                    }

                } while (restart == "Y");

                Console.WriteLine("End of the program");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                Console.ReadKey();
            }
        }

        //Simple statements
        static void Simplestatements()
        {
            //just an example of simple statements declaranding variables y values to those variables

            string name;
            int age;
            double favoritenum;
            double strength;

            name = "Joaquin";
            age = 147;
            favoritenum = 999.999;
            strength = 10000;

            Console.WriteLine("His name is " + name + ", his age is " + age + ", his favorite number is " + favoritenum + " and his level of power is: " + strength);
            Console.WriteLine("Here ends the method Simplestatements");
        }

        //Complex statements
        static void Complexstatements()
        {
            Console.WriteLine("The example of a complex statement with a loop for: ");

            for (int count = 0; count <= 21; count += 3)
            {
                Console.WriteLine(count);
            }
            Console.WriteLine("Here ends the method complexstatements");
        }

        //Demo If Else conditions
        static void Demoifelse()
        {
            Console.WriteLine("We have two numbers, 1 and 5, we will see if they are the equals or not with if-else");

            int a = 1;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine("1 and 5 are equals");
            }
            else if (a < b)
            {
                Console.WriteLine("1 is less than 5");
            }
            else
            {
                Console.WriteLine("1 is greater than 5");
            }
            Console.WriteLine("Here ends the method Demoifelse");
        }

        //Demo Switch
        static void Demoswitch()
        {
            Console.WriteLine("Pick a number that you like the most: 2, 6 u 8 ");
            string numerofav = Console.ReadLine();

            switch (numerofav)
            {
                case "2":
                    Console.WriteLine("Good choice");
                    break;

                case "6":
                    Console.WriteLine("Good choise");
                    break;

                case "8":
                    Console.WriteLine("Not so good choice");
                    break;

                default:
                    Console.WriteLine("Bad choice");
                    break;
            }
            Console.WriteLine("Here ends the method Demoswitch");
        }

        //Demo do-while loop
        static void Loops()
        {
            Console.WriteLine("This is a loop do-while with an input: ");

            //Input
            Console.WriteLine("Enter a number");
            string num = Console.ReadLine();
            int num2 = Int32.Parse(num);

            do
            {
                Console.WriteLine(num2);
                num2 += 3;
            }
            while (num2 <= 30);
            Console.ReadLine();
            Console.WriteLine("Here ends the method loops");

        }

        //Demo overloaded methods
        static double Multiplication(double num1, double num2) => num1 * num2;

        //Here is an example of overloaded methods
        static double Multiplication(double num1, double num2, double num3) => num1 * num2 * num3;

        public static void GetStats()
        {
            Console.WriteLine("Choose the kind of hero you want to play!" + "\r\n" +
                   "-----------------------------------------" + "\r\n" +
                   @"1. A simple Human
2. Archer
3. Assassin
4. Knight
5. Wizard
6. Corrupted Wizard
Enter the number:");

            string heroType = Console.ReadLine();
            int heroType2 = Int32.Parse(heroType);

            Stats stats = new Stats();

            switch (heroType2)
            {
                case 1:
                    stats.Vitality = 100;
                    stats.Strength = 10;
                    stats.Defense = 10;
                    Human desc = new Human();
                    desc.GetDescription();
                    break;
                case 2:
                    Archer hero = new Archer();
                    stats = hero.GetHeroStats();
                    Archer desc1 = new Archer();
                    desc1.GetDescription();
                    break;
                case 3:
                    Assassin hero2 = new Assassin();
                    stats = hero2.GetHeroStats();
                    Assassin desc2 = new Assassin();
                    desc2.GetDescription();
                    break;
                case 4:
                    Knight hero3 = new Knight();
                    stats = hero3.GetHeroStats();
                    Knight desc3 = new Knight();
                    desc3.GetDescription();
                    break;
                case 5:
                    Wizard hero4 = new Wizard();
                    stats = hero4.GetHeroStats();
                    Wizard desc4 = new Wizard();
                    desc4.GetDescription();
                    break;
                case 6:
                    CorruptedWizard hero5 = new CorruptedWizard();
                    stats = hero5.GetHeroStats();
                    CorruptedWizard desc5 = new CorruptedWizard();
                    desc5.GetDescription();
                    break;
                default:
                    Console.WriteLine("No hero selected");
                    break;
            }

            Console.WriteLine("\r\nThe stats of the hero:" + "\r\n" +
                "----------------------" + "\r\n" +
                "Vitality: " + stats.Vitality + "\r\n" +
                "Strength: " + stats.Strength + "\r\n" +
                "Defense: " + stats.Defense + "\r\n");
        }
        
    }
}