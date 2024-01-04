namespace GradingSystem_v2
{
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
