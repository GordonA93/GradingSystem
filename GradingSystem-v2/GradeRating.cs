namespace GradingSystem_v2
{
    public static class GradeRating
    {
        public static void RateGrade(int examResult)
        {
            if (examResult >= 0 && examResult <= 44)
            {
                Console.WriteLine($"\n{examResult} - Your grade is Grade F\n");
                Menu.MenuOption();
            }
            else if (examResult >= 45 && examResult <= 59)
            {
                Console.WriteLine($"\n{examResult} - Your grade is Grade D\n");
                Menu.MenuOption();
            }
            else if (examResult >= 60 && examResult <= 74)
            {
                Console.WriteLine($"\n{examResult} - Your grade is Grade C\n");
                Menu.MenuOption();
            }
            else if (examResult >= 75 && examResult <= 89)
            {
                Console.WriteLine($"\n{examResult} - Your grade is Grade B\n");
                Menu.MenuOption();
            }
            else if (examResult >= 90 && examResult <= 100)
            {
                Console.WriteLine($"\n{examResult} - Your grade is Grade A\n");
                Menu.MenuOption();
            }
            else
            {
                Console.WriteLine("\nYou have entered an incorrect number!");
                Environment.Exit(0);
            }
        }
        public static void RateMultipleGrades(int multiExamResults)
        {
            if (multiExamResults >= 0 && multiExamResults <= 44)
            {
                Console.WriteLine($"\n{multiExamResults} - Your grade is Grade F\n--------------------------------------------------");
            }
            else if (multiExamResults >= 45 && multiExamResults <= 59)
            {
                Console.WriteLine($"\n{multiExamResults} - Your grade is Grade D\n--------------------------------------------------");
            }
            else if (multiExamResults >= 60 && multiExamResults <= 74)
            {
                Console.WriteLine($"\n{multiExamResults} - Your grade is Grade C\n--------------------------------------------------");
            }
            else if (multiExamResults >= 75 && multiExamResults <= 89)
            {
                Console.WriteLine($"\n{multiExamResults} - Your grade is Grade B\n--------------------------------------------------");
            }
            else if (multiExamResults >= 90 && multiExamResults <= 100)
            {
                Console.WriteLine($"\n{multiExamResults} - Your grade is Grade A\n--------------------------------------------------");
            }
            else
            {
                Console.WriteLine("\nYou have entered an incorrect number!");
                Environment.Exit(0);
            }
        }
    }
}
