// See https://aka.ms/new-console-template for more information
namespace QuizMasterChallenge {

internal class QuizMasterChallenge {

public static void Main(String[] args)
        {
            try
            {
                startQuiz();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error {e.Message}");
            }
            finally
            {
                Console.WriteLine("\nThank you for completing the quiz!");
            }
        }
        public static void startQuiz()
        {
            List<String> questions = new List<String>() {
    "What is the smallest country in the world?",
    "Who wrote the famous play 'Hamlet'?",
    "What is the chemical symbol for gold?",
    "Which continent is known as the 'Land Down Under'?",
    "What is the highest mountain in the world?",
};
            List<String> answers = new List<String>() {
    "Vatican City",
    "William Shakespeare",
    "Au",
    "Australia",
    "Mount Everest",

};
            double score = 0;
            int i;
            for (i = 0; i < questions.Count; i++)
            {
                Console.WriteLine((i + 1) + "-" + questions[i]);
                bool isAnswer = false;
                while (!isAnswer)
                {
                    string read = Console.ReadLine().ToLower();
                    if (read == answers[i].ToLower())
                    {
                        score++;
                        isAnswer = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ResetColor();
                    }
                    else
                    {
                        isAnswer = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong Answer!\n");
                        Console.ResetColor();
                    }
                }
            }
            Console.WriteLine("Your Score is : " + score + "/5");
            Console.WriteLine("Your Percentage is : " + ((score / 5) * 100) + "%");
        }
}
}
