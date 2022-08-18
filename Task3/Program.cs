// программa, которая задаёт массив из N элементов 
// и выводит их на экран

Console.Clear();

int[] bigarray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
    Console.Write("Input number ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void Display(int[] array)
{
    Console.Write("[ ");

    for (int j = 0; j<array.Length-1; j++)
        {
            Console.Write(array[j] + ", ");
        }

    Console.Write( array[array.Length-1] + " ]");
}

Console.Write("How many numbers in your array? ");
int length = Convert.ToInt32(Console.ReadLine());
int[] userarray = new int [length];

bigarray(userarray);
Display(userarray);