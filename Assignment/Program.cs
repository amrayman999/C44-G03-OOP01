﻿using Assignment.Enums;
using Demo.Enums;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //foreach (var day in Enum.GetNames(typeof(DayOfWeek)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Question 2
            //bool isParsed;
            //object season;
            //do
            //{
            //    Console.Write("Enter Season Name:");
            //    isParsed = Enum.TryParse(typeof(Season), Console.ReadLine(), true, out season);
            //    if (!isParsed)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid season name (Spring, Summer, Autumn, Winter).");
            //    }

            //} while (!isParsed);
            //Season season1 = (Season)season;
            //switch (season1)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("Spring Range : March to May");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("Summer Range : March to MayJune to August");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("Autumn Range : September to November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("Winter Range : December to February");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown season.");
            //        break;
            //}
            #endregion

            #region Question 4
            //Permission permission = Permission.Read | Permission.Write | Permission.Execute | Permission.Delete;
            //Console.WriteLine($"Permissions: {permission}");
            #endregion

            #region Question 5
            Console.WriteLine("Enter a color (Red, Green, Blue):");
            string input = Console.ReadLine();

            bool isValid = Enum.TryParse(input, true, out Colors selectedColor);

            if (isValid && Enum.IsDefined(typeof(Colors), selectedColor))
            {
                Console.WriteLine($"{selectedColor} is a primary color.");
            }
            else
            {
                Console.WriteLine("Invalid color or not a primary color.");
            }

            #endregion

        }
    }
}
