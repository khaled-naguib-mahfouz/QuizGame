using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to the quiz!");

        // Arrays of questions and answers
        string[] questions = new string[]
        {
            "What is the capital of France?",
            "What is 2 + 2?",
            "What is the color of the sky on a clear day?"
        };

        string[] answers = new string[]
        {
            "Paris",
            "4",
            "Blue"
        };

        // Print instruction message
        Console.WriteLine("Answer the following questions:");

        // Variable to hold the score
        int score = 0;

        // Loop through the questions
        for (int i = 0; i < questions.Length; i++)
        {
            // Get user input and validate it
            string userInput = GetValidInput(questions[i]);

            // Compare the answer and update the score
            if (CheckAnswer(userInput, answers[i]))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
        }

        // Print the final score
        Console.WriteLine($"Your score is: {score}/{questions.Length}");
    }

    // Method to get valid user input
    static string GetValidInput(string question)
    {
        string input = string.Empty;
        bool validInput = false;

        while (!validInput)
        {
            Console.WriteLine(question);
            input = Console.ReadLine();

            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new Exception("Input cannot be empty. Please try again.");
                }

                validInput = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        return input;
    }

    // Method to check if the answer is correct
    static bool CheckAnswer(string userInput, string correctAnswer)
    {
        return userInput.Trim().Equals(correctAnswer, StringComparison.OrdinalIgnoreCase);
    }
}
