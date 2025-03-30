namespace CalculatorProject.Operations;

public interface IOperation
{
    bool CanHandle(string operation);
    double Execute(double[] numbers);
}
