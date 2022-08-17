// цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B

Console.Clear();

int PowerRase(int arg1, int arg2)
{
    if (arg2 < 0) arg2 = arg2 * (-1);
    int result = 1; 
    for (int i = 1; i <= arg2; i++)
    {
        result = result*arg1;
    }
    return result;
}

int Input()
{
    Console.Write("Input number ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int factor = Input();
int exponent = Input();
int degree = PowerRase(factor, exponent);
Console.WriteLine($"{factor} to the power of {Math.Abs(exponent)} equals {degree}");
