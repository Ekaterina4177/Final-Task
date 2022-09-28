/* Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

Console.Clear();
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[length];
Console.WriteLine("Полученный массив: ");
for (int i = 0; i < length; i++)
{
    arr[i] = new Random().Next(10, 3000);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
for (int i = 0; i < length; i++)
{
    if (arr[i] <= 999)
    {
        Console.Write($"{arr[i]} ");
    }
    else
    {
        arr[i] = arr[i];
    }
}