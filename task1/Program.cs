// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Length = Prompt ("Введите количество элементов: ");
int[] array = GetArray(Length);
PrintArray(array);
int count = Search(array);


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}  

void PrintArray(int[] arr)
{
    int count = Search(arr);
    Console.WriteLine($"Количество чисел больше 0 - {count}");
    for (int i = 0; i < arr.Length; i++)
    Console.WriteLine();
}

int[] GetArray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = Prompt($"Введите {i +1}-й элемент");
    }
    return array;
}

int Search (int[] array)
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i]>0)
    {
        count++;
    }
    }
    return count;
}