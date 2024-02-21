//int n = 10;
int[] array = { 2, 5, 6, 3, 7, 9, 3, 1, 18, 21 };
int i = 0;

while (i < array.Length) 
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
