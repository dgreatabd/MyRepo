char[] stringArray = ['&', '9', 'a', 'b', 'c'];

stringArray[0] = '*';

foreach (char c in stringArray)
{
  Console.WriteLine(c);
}

CalculatorInput();

void CalculatorInput()
{
  try
  {
    Console.Write("Enter first number: ");
    double firstNumber = double.Parse(Console.ReadLine()!);

    Console.Write("Enter operator type (+, -, *, /, %): ");
    string operation = Console.ReadLine()!;

    Console.Write("Enter second number: ");
    double secondNumber = double.Parse(Console.ReadLine()!);

    double result = CalculatorEngine(firstNumber, secondNumber, operation);

    Console.WriteLine($"Result of {firstNumber} {operation} {secondNumber} is: {result}");
  }
  catch(FormatException ex)
  {
    Console.WriteLine("Format error: {0}", ex.Message);
  }
  catch(DivideByZeroException ex)
  {
    Console.WriteLine("Division error: {0}", ex.Message);
  }
  catch(InvalidOperationException ex)
  {
    Console.WriteLine("Invalid operation: {0}", ex.Message);
  }
  catch (Exception)
  {
    Console.WriteLine("An error occured");
  }
}

double CalculatorEngine(double numberArg1, double numberArg2, string operatorArg)
{
  double result;

  switch (operatorArg)
  {
    case "+":
      result = numberArg1 + numberArg2;
      break;
    case "-":
      result = numberArg1 - numberArg2;
      break;
    case "*":
      result = numberArg1 * numberArg2;
      break;
    case "/":
      result = numberArg1 / numberArg2;
      break;
    case "%":
      result = numberArg1 % numberArg2;
      break;
    default:
      throw new InvalidOperationException("Operator not recognized!");
  }

  return result;
}
