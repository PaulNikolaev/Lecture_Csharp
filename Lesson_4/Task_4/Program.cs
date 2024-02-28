// Считать с консоли строку, состоящую из цифр и
// латинских букв. Сформировать массив, состоящий
// из цифр этой строки.

Console.Clear();


int GetLettersFromString(string s) // Функция создания числа из строки
{
    string letters = "";
    int num = 0;
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == false)
        {
            letters = letters + e;
        }
    }
    num = Convert.ToInt32(letters);
    return num;
}


int[] CreateArrayOfNumber(int number)  // Функция создания массива из числа
{
    int i = 1;
    int n = 0;
    int variable = number;

    while (variable != 0)
    {
        variable = variable / 10;
        i *= 10;
        n++;
    }

    int[] arr = new int[n];
    for (int e = 0; e < arr.Length; e++)
    {
        i = i / 10;
        variable = number / i;
        number = number % i;
        arr[e] = variable;
    }
    return arr;
}

void ShowArray(int[] array)  // Функция вывода массива
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

string str = Console.ReadLine();
int result = GetLettersFromString(str);
// Console.WriteLine(result);
int [] array = CreateArrayOfNumber(result);
ShowArray(array);


