namespace CalculatorProject.Operations;

public class PowerOperation : IOperation
{
    public bool CanHandle(string operationSymbol) => operationSymbol == "^";

    public double Execute(double[] numbers)
    {
        if (numbers.Length != 2)
            throw new InvalidOperationException(
                "Power operation requires exactly two numbers: base and exponent."
            );

        return Math.Pow(numbers[0], numbers[1]);
    }
}
