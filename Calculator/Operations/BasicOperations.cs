namespace CalculatorProject.Operations;

public class AdditionOperation : IOperation
{
    public bool CanHandle(string operation) => operation == "+";

    public double Execute(double[] numbers)
    {
        if (numbers.Length != 2)
            throw new ArgumentException("Need 2 numbers");

        return numbers[0] + numbers[1];
    }
}

public class SubtractionOperation : IOperation
{
    public bool CanHandle(string operationSymbol) => operationSymbol == "-";

    public double Execute(double[] numbers)
    {
        if (numbers.Length != 2)
            throw new ArgumentException("Need 2 numbers");

        return numbers[0] - numbers[1];
    }
}

public class MultiplicationOperation : IOperation
{
    public bool CanHandle(string operationSymbol) => operationSymbol == "*";

    public double Execute(double[] numbers)
    {
        if (numbers.Length != 2)
            throw new ArgumentException("Need 2 numbers");

        return numbers[0] * numbers[1];
    }
}

public class DivisionOperation : IOperation
{
    public bool CanHandle(string operationSymbol) => operationSymbol == "/";

    public double Execute(double[] numbers)
    {
        if (numbers.Length != 2)
            throw new ArgumentException("Need 2 numbers");

        if (numbers[1] == 0)
            throw new DivideByZeroException("Cannot divide by zero");

        return numbers[0] / numbers[1];
    }
}
