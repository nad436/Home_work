using System.Numerics;
using System.Text;

namespace Practice
{


    public class Program
    {
        public enum MathActions
        {
            Plus = '+',
            Minus = '-',
            Multiply = '*',
            Divide = '/'
        }

        public enum Pizzas
        {
            DetroitStyle = 20,
            ChicagoDeepDish = 23,
            Neapolitan = 18,
            Sicilian = 19
        }
        public enum Beverages
        {
            Cola = 3,
            Tea = 2,
            MilkShake = 4

        }
        public static void Main()
        {
            try
            {
                Console.WriteLine("Choose task: 1 or 2");
                int taskNumber = Convert.ToInt32(Console.ReadLine());
                if (taskNumber == 1)
                {
                    Console.WriteLine("This is calculator\nEnter first number");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter mathematical symbol: +, -, *, /");
                    var mathAction = (MathActions)Convert.ToChar(Console.ReadLine() ?? string.Empty);

                    switch (mathAction)
                    {
                        case MathActions.Plus:
                            Console.WriteLine(firstNumber + secondNumber);
                            break;
                        case MathActions.Minus:
                            Console.WriteLine(firstNumber - secondNumber);
                            break;
                        case MathActions.Multiply:
                            Console.WriteLine(firstNumber * secondNumber);
                            break;
                        case MathActions.Divide:
                            Console.WriteLine(firstNumber / secondNumber);
                            break;
                        default:
                            Console.WriteLine("Something went wrong");
                            break;

                    }
                }



                else if (taskNumber == 2)
                {
                    int P1 = Convert.ToInt32(Pizzas.DetroitStyle);
                    int P2 = Convert.ToInt32(Pizzas.ChicagoDeepDish);
                    int P3 = Convert.ToInt32(Pizzas.Neapolitan);
                    int P4 = Convert.ToInt32(Pizzas.Sicilian);
                    int B1 = Convert.ToInt32(Beverages.Cola);
                    int B2 = Convert.ToInt32(Beverages.Tea);
                    int B3 = Convert.ToInt32(Beverages.MilkShake);

                    Console.WriteLine($"Welcome to pizzeria \"Mamma mia\". Which pizza you'd like to order?" +
                        $"\nPizza\t\t\tCode\tPrice\nDetroit-style\t\tP1\t{P1}\nChicago deep dish\tP2\t{P2}\nNeapolian\t\tP3\t{P3}\nSicilian\t\tP4\t{P4}");
                    string pizzaCode = Convert.ToString(Console.ReadLine());
                    int pizzaOrder = 0;
                    switch (pizzaCode)
                    {
                        case "P1":
                            pizzaOrder = P1;
                            break;
                        case "P2":
                            pizzaOrder = P2;
                            break;
                        case "P3":
                            pizzaOrder = P3;
                            break;
                        case "P4":
                            pizzaOrder = P4;
                            break;
                        default:
                            Console.WriteLine("We don't have this one");
                            break;


                    }

                    Console.WriteLine("How many pizza would you like to order?");
                    int countPizza = Convert.ToInt32(Console.ReadLine());
                    int countPizzaFull = countPizza;
                    if (countPizza % 5 == 0)
                    {
                        int freePizza = countPizza / 5;
                        countPizza = countPizza - freePizza;

                    }
                    else { };

                    Console.WriteLine("Which beverage you'd like to order?");
                    Console.WriteLine($"Beverage\tCode\tPrice\nCola\t\tB1\t{B1}\nTea\t\tB2\t{B2}\nMilkshake\tB3\t{B3}");
                    string beverageCode = Convert.ToString(Console.ReadLine());
                    int beverageOrder = 0;
                    switch (beverageCode)
                    {
                        case "B1":
                            beverageOrder = B1;
                            break;
                        case "B2":
                            beverageOrder = B2;
                            break;
                        case "B3":
                            beverageOrder = B3;
                            break;
                        default:
                            Console.WriteLine("We don't have this one");
                            break;
                    }
                    Console.WriteLine("How many beverages would you like to order?");
                    int countBeverage = Convert.ToInt32(Console.ReadLine());
                    decimal beverageTotal = (decimal)beverageOrder * countBeverage;
                    int pizzaTotal = pizzaOrder * countPizza;
                    decimal total = (decimal)pizzaTotal + beverageTotal;

                    if (total > 50)
                    {
                        decimal discount = total / 100 * 20;
                        total = (decimal)total - discount;
                        Console.WriteLine(total);
                    }
                    else { };

                    if (beverageOrder > 2)
                    {
                        if (countBeverage > 3)
                        {
                            beverageTotal = (decimal)beverageTotal - (beverageTotal / 100 * 15);
                        }
                    }
                    string pizzaName = "";
                    switch (pizzaCode)
                    {
                        case "P1":
                            pizzaName = "Detroit pizza";
                            break;
                        case "P2":
                            pizzaName = "Chicago pizza";
                            break;
                        case "P3":
                            pizzaName = "Neapolian pizza";
                            break;
                        case "P4":
                            pizzaName = "Sicilian pizza";
                            break;
                        default:
                            break;
                    }
                    string beverageName = "";
                    switch (beverageCode)
                    {
                        case "B1":
                            beverageName = "Cola";
                            break;
                        case "B2":
                            beverageName = "Tea";
                            break;
                        case "B3":
                            beverageName = "Milkshake";
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine($"Name\t{pizzaName}\t\t{beverageName}\nAmount\t\t{countPizza}\t\t{countBeverage}\nPrice\t\t{pizzaTotal}\t\t{beverageTotal}\nTotal: {total}");
                }
                else
                {
                    Console.WriteLine($"Why did you enter {taskNumber}?");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");
                Console.WriteLine(ex.Message);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("This is wrong type of data");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("We don`t do that here");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
