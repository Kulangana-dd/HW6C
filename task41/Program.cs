/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/


void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write("Введите числo: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}

void PrintArray(int[] finalArray)
{
    int count = finalArray.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{finalArray[position]} ");
        position++;
    }
}


int NumbersOverZero(int[] currentArray)
{
    int result = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] > 0)
        {
            result = result + 1;
        }
    }
    return result;
}


Console.Write("Сколько чисел вы хотите ввести: ");
int value = Convert.ToInt32(Console.ReadLine());
int[] array = new int[value];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int result = NumbersOverZero(array);
Console.WriteLine($"Количество чисел больше 0 равно {result}");
