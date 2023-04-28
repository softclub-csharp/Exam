namespace Task3;

public class Calculator
{
    private int _firstNumber;
    private int _secondNumber;
    public Calculator(int firstNumber, int secondNumber)
    {
        _firstNumber = firstNumber;
        _secondNumber = secondNumber;
    }

    public int Add()
    {
        return _firstNumber + _secondNumber;
    }

    public int Subtract()
    {
        return _firstNumber - _secondNumber;
    }

    public int Multiplication()
    {
        return _firstNumber * _secondNumber;
    }

    public double Division()
    {
        return _firstNumber / (double)_secondNumber;
    }

}
