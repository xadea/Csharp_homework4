// программа, которая принимает на вход число
// и выдаёт сумму цифр в числе

Console.Clear();

Console.WriteLine("Input number");
double digit = Convert.ToInt32(Console.ReadLine());
double count = 0;
while (digit > 0)
{
    count = count + digit % 10;
    digit = (digit - digit % 10)/10;
}
Console.WriteLine("Sum of all number's digits is " + count);
