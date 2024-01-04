using GradingSystem;
using System;
using System.Collections.Generic;
namespace GradingSystem_v2
{
    public static class Menu
    {
        public static void MenuOption()
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------------------\n1. Exam Grading\n2. Multiple Results\n3. Exit   \n\nInput the number of the menu you wish to select \n--------------------------------------------------\n");
                int menuSelection = Convert.ToInt32(Console.ReadLine());

                if (menuSelection == 1)
                {
                    Console.WriteLine("\nPlease input your Exam Result: ");
                    int examResult = Convert.ToInt32(Console.ReadLine());
                    GradeRating.RateGrade(examResult);
                    Console.ReadLine();
                }
                else if (menuSelection == 2)
                {
                    MultipleGrades.ProcessMultiple();
                }
                else if (menuSelection == 3)
                {
                    Console.WriteLine("\nThanks for using this Grading System!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\nYou have entered an incorrect menu option! Please select from the menu options below: \n");
                    Menu.MenuOption();
                }
            }
        }
    }
}
