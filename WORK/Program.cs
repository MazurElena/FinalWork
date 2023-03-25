// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами

// Метод генерирующий массив
string [] GetNewArray(string [] arry, int count)
{   
    string [] result= new string [0];
    for (int index = 0; index < arry.Length; index++)
    {
        if (arry[index].Length<=count)
        {
            result = result.Concat(new string[] { arry[index] }).ToArray();
        }
    }
    return result;    
}
// Метод выводящий на печать массив
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]} "+" ");
    }
    Console.WriteLine(array[array.Length-1]+"]");
}
// Метод поиска элементов массива < или = 3 символов
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
string[] array1 = new string[8] {"657", "14", "hello", "world", "-5", "Russia", "yes", ";-)"};
string[] array2 = GetNewArray(array1, 3);

SecondArrayWithIF(array1, array2);
PrintArray(array2);