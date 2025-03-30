namespace CalculatorProject.Operations;

public class SqrtOperation : IOperation
{
    public bool CanHandle(string operationSymbol) => operationSymbol == "sqrt";

    public double Execute(double[] numbers)
    {
        if (numbers.Length != 1)
            throw new InvalidOperationException(
                "Square root operation requires exactly one number."
            );

        if (numbers[0] < 0)
            throw new InvalidOperationException(
                "Cannot calculate the square root of a negative number."
            );

        return Math.Sqrt(numbers[0]);
    }
}
