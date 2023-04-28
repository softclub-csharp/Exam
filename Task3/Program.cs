using Task3;

while (true)
{
    Console.Write("The first number is: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter +,-,*,/ : ");
    string operation = Console.ReadLine();

    Console.Write("The second number is: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    //object
    var calc = new Calculator(num1, num2);
    switch (operation)
    {
        case "+":
            System.Console.WriteLine($"{num1}+{num2}={calc.Add()}");
            break;
        case "-":
            System.Console.WriteLine($"{num1}-{num2}={calc.Subtract()}");
            break;
        case "*":
            System.Console.WriteLine($"{num1}*{num2}={calc.Multiplication()}");
            break;
        case "/":
            System.Console.WriteLine($"{num1}/{num2}={calc.Division()}");
            break;
        default:
            System.Console.WriteLine($"Operation is wrong");
            break;
    }

}