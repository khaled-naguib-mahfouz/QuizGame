# Console Quiz Application

This is a simple console application written in C# that asks the user three questions, validates their answers, and calculates their score.

## Features

- Asks the user three predefined questions.
- Validates that the user's input is not empty.
- Compares the user's answers to the correct answers.
- Informs the user if their answer is correct or incorrect after each question.
- Calculates and displays the final score.

## How to Run

1. Clone or download this repository.
2. Open the project in your preferred C# development environment (e.g., Visual Studio).
3. Build the solution.
4. Run the application.

## Code Explanation

### Main Program

The `Main` method does the following:
1. Prints a welcome message.
2. Initializes arrays for questions and answers.
3. Loops through each question, gets the user's input, and checks the answer.
4. Prints whether each answer is correct or not.
5. Calculates and prints the final score.

### Methods

- `GetValidInput(string question)`: Asks the user the given question, ensures the input is not empty, and returns the valid input.
- `CheckAnswer(string userInput, string correctAnswer)`: Compares the user's input to the correct answer and returns `true` if they match, `false` otherwise.

### Example

Here is an example of how the program interacts with the user:

