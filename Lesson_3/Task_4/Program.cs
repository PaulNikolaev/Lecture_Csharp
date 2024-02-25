void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //arr[i] = i + 1;
        Random rnd = new Random();
        arr[i] = rnd.Next(1, 100);
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int GetSumOfElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int GetProductOfElements(int[] arr)
{
    int product = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        product = product * arr[i];
    }
    return product;
}

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[n];
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.WriteLine(sum);
Console.WriteLine(product);