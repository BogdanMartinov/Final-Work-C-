// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


string[] ResultArray(string[] array)
{
    int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }
    int index = 0;
    string[] resultArray = new string[count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                resultArray[index] = array[i];
                index++;
            }
        }
        return resultArray;
}


void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " "); 
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Введите элементы массива (через запятую):");
string input = Console.ReadLine();
string[] inputArray = input.Split(',');
PrintArray(ResultArray(inputArray));
