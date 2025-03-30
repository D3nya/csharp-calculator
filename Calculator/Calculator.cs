using CalculatorProject.Helpers;
using CalculatorProject.Operations;

namespace CalculatorProject;

public class Calculator
{
    private readonly List<IOperation> _operations;

    public Calculator()
    {
        _operations =
        [
            new AdditionOperation(),
            new SubtractionOperation(),
            new MultiplicationOperation(),
            new DivisionOperation(),
            new PowerOperation(),
            new SqrtOperation(),
            new SinOperation(),
            new CosOperation(),
            new TanOperation(),
        ];
    }

    public void Run()
    {
        while (true)
        {
            var (operationSymbol, numbers, isExit) = InputHelper.GetInput();
            if (isExit)
                break;

            try
            {
                var operation = _operations.FirstOrDefault(op => op.CanHandle(operationSymbol));

                if (operation == null)
                {
                    Console.WriteLine($"Error: Unknown operation '{operationSymbol}'");
                    continue;
                }

                var result = operation.Execute(numbers);

                Console.WriteLine($"Result: {result}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
