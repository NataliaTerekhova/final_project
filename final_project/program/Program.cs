/* Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.  */

string[] stringArray;
Console.WriteLine("Введите массив строк через пробел");
string str = Console.ReadLine();
stringArray = str.Split(' ');
GetNewStringArray(stringArray);

void GetNewStringArray(string[] str)
{
    string[] result = new string[str.Length];
    int count = 0;
    foreach (var value in str)
    {
        if (value.Length < 4)
        {
            result[count] = value;
            count++;
        }
    }
    PrintArray(result);
}


void PrintArray(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write($"{str[i]} ");
    }
    Console.WriteLine();
}

