// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input two numbers");

if (int.TryParse(Console.ReadLine(), out int firstNum))
{
    Console.WriteLine("First Number: " + firstNum);
}
else
{
    Console.WriteLine("Wrong number");
    return;
}

if (int.TryParse(Console.ReadLine(), out int secondNum))
{
    Console.WriteLine("Second Number: " + secondNum);
}
else
{
    Console.WriteLine("Wrong number");
    return;
}

Console.WriteLine("Choose the number of sign\n 1: +; 2: -; 3: /; 4: *; 5: &; 6: |; 7: ^;");

if (int.TryParse(Console.ReadLine(), out int sign) && sign > 0 && sign < 8)
{
    string resultDecimal = null;
    string resultDual = null;
    string resultHexadecimal = null;

    switch (sign)
    {
        case 1:
            Console.WriteLine("Value: {0} + {1} = {2}", firstNum, secondNum, firstNum + secondNum);
            break;
        case 2:
            Console.WriteLine("Value: {0} - {1} = {2}", firstNum, secondNum, firstNum - secondNum);
            break;
        case 3:
            Console.WriteLine("Value: {0} / {1} = {2}", firstNum, secondNum, firstNum / secondNum);
            break;
        case 4:
            Console.WriteLine("Value: {0} * {1} = {2}", firstNum, secondNum, firstNum * secondNum);
            break;
        case 5:
            resultDecimal = Convert.ToString(firstNum & secondNum);
            resultDual = Convert.ToString((firstNum & secondNum), 2);
            resultHexadecimal = Convert.ToString((firstNum & secondNum), 16);

            Console.WriteLine("Value of {0} & {1}:\n decimal: {2}\n dual: {3}\n hexadecimal: {4}", firstNum, secondNum, resultDecimal, resultDual, resultHexadecimal);

            break;
        case 6:
            resultDecimal = Convert.ToString(firstNum & secondNum);
            resultDual = Convert.ToString((firstNum | secondNum), 2);
            resultHexadecimal = Convert.ToString((firstNum | secondNum), 16);

            Console.WriteLine("Value of {0} | {1}:\n decimal: {2}\n dual: {3}\n hexadecimal: {4}", firstNum, secondNum, resultDecimal, resultDual, resultHexadecimal);

            break;
        case 7:
            resultDecimal = Convert.ToString(firstNum & secondNum);
            resultDual = Convert.ToString((firstNum ^ secondNum), 2);
            resultHexadecimal = Convert.ToString((firstNum ^ secondNum), 16);

            Console.WriteLine("Value of {0} ^ {1}:\n decimal: {2}\n dual: {3}\n hexadecimal: {4}", firstNum, secondNum, resultDecimal, resultDual, resultHexadecimal);

            break;
        default:
            Console.WriteLine("Error!!! Wrong sign!!!");
            break;
    }
} else {
    Console.WriteLine("Error!!! Wrong sign!!!");
}
