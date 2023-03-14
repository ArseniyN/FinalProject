// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Clear();
string[] array1 = new string[5] {"234", "Minsk", "Denmark", "2", "qwerty"}; // зададим два массива
string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;                                      
    for (int a = 0; a < array1.Length; a++)
    {
    if(array1[a].Length <= 3)                       // Проверяем соответсвие условию задачи
        {
        array2[count] = array1[a];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int a = 0; a < array.Length; a++)
    {
        Console.Write($"{array[a]} ");
    }
    Console.WriteLine();
}
SecondArray(array1, array2);
PrintArray(array2);