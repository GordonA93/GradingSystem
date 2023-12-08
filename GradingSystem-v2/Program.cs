namespace GradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grading System. \n-------------------------------------\n \nPlease select from the menu options below: \n");
            Menu.MenuOption();
        }
    }
    class Menu
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
    class GradeRating
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
    class MultipleGrades
    {
        public static void ProcessMultiple()
        {
            List<int> resultList = new List<int>();
            Console.WriteLine("\nInput your first exam result, press enter to get your grade and input another result. Once you have entered all of your exam results, press x to calculate the average grade \n-------------------------------------\n");
            while (true)
            {
                Console.WriteLine("\nEnter your Exam Results (or to calculate your average, press x):  \n");
                string userInput = Console.ReadLine()!;         
                
                if (string.Equals(userInput, "x"))
                {
                    double averageResult = resultList.Average();
                    int gradeAverage = Convert.ToInt32(averageResult);
                    Console.WriteLine($"\nYour average is: {gradeAverage}");
                    GradeRating.RateGrade(gradeAverage);
                    break;
                }
                else
                {
                    int conversion = Convert.ToInt32(userInput);
                    resultList.Add(conversion);
                    GradeRating.RateMultipleGrades(conversion);
                }
            }
        }
    }
}