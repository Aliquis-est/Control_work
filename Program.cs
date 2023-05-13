// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] CreateArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i += 1)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i += 1)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

string[] ThreeSymbolArray(string[] array)
{
    int a = 0;
    int b = 0;

    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i].Length <= 3) a += 1;
    }

    string[] arrayResult = new string[a];
    for (int i = 0; i < array.Length; i += 1)
     {
        if (array[i].Length <= 3)
        {
            arrayResult[b] = array[i];
            b += 1;
        }
    }
    return arrayResult;
}


string[] myArray = CreateArray();
Console.WriteLine();
Console.WriteLine("Созданный массив:");
ShowArray(myArray);
Console.WriteLine();
string[] finalArray = ThreeSymbolArray(myArray);
Console.WriteLine("Итоговый массив:");
ShowArray(finalArray);