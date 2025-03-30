namespace CalculatorProject.Operations;

public class SinOperation : IOperation
{
    public bool CanHandle(string operationSymbol) => operationSymbol == "sin";

    public double Execute(double[] numbers)
    {
        if (numbers.Length != 1)
            throw new ArgumentException(
                "Trigonometric operations require exactly one number (angle in degrees)."
            );

        double angleInRadians = numbers[0] * (Math.PI / 180);

        return Math.Sin(angleInRadians);
    }
}

public class CosOperation : IOperation
{
    public bool CanHandle(string operationSymbol) => operationSymbol == "cos";

    public double Execute(double[] numbers)
    {
        if (numbers.Length != 1)
            throw new ArgumentException(
                "Trigonometric operations require exactly one number (angle in degrees)."
            );

        double angleInRadians = numbers[0] * (Math.PI / 180);

        return Math.Cos(angleInRadians);
    }
}

public class TanOperation : IOperation
{
    public bool CanHandle(string operationSymbol) => operationSymbol == "tan";

    public double Execute(double[] numbers)
    {
        if (numbers.Length != 1)
            throw new ArgumentException(
                "Trigonometric operations require exactly one number (angle in degrees)."
            );

        double angleInRadians = numbers[0] * (Math.PI / 180);

        return Math.Tan(angleInRadians);
    }
}
