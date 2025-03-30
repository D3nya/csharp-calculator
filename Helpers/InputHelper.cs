namespace CalculatorProject.Helpers;

public static class InputHelper
{
    public static (string Operation, double[] Numbers, bool IsExit) GetInput()
    {
        while (true)
        {
            Console.Write(
                "Enter operation (+, -, *, /, ^, sqrt, sin, cos, tan) or 'exit' to quit: "
            );
            var op = Console.ReadLine()?.Trim().ToLower();

            if (op == "exit")
                return ("", [], true);

            if (
                op != "+"
                && op != "-"
                && op != "*"
                && op != "/"
                && op != "^"
                && op != "sqrt"
                && op != "sin"
                && op != "cos"
                && op != "tan"
            )
            {
                Console.WriteLine(
                    "Invalid operation. Please enter one of the following: +, -, *, /, ^, sqrt, sin, cos, tan, or 'exit'."
                );
                continue;
            }

            Console.Write("Enter numbers (space separated): ");
            var inputNumbers = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputNumbers))
            {
                Console.WriteLine("You must enter at least one number.");
                continue;
            }

            try
            {
                var numbers = inputNumbers
                    .Split(' ')
                    .Where(n => !string.IsNullOrWhiteSpace(n))
                    .Select(n => double.Parse(n))
                    .ToArray();

                if (numbers.Length == 0)
                {
                    Console.WriteLine("No valid numbers were entered. Please try again.");
                    continue;
                }

                return (op, numbers, false);
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    "Invalid number format. Please enter valid numbers separated by spaces."
                );
            }
        }
    }
}
