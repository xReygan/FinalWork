//Задача: Написать программу, которая из имеющегося массива строк формирует новый
//массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный
//массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись
//исключительно массивами.

string[] CreateArray(string input)               //Метод создания входного строкового массива из исходной
{                                                //строки, где в качестве разделителя строк используется
    string[] inputArray = input.Split(",");      //запятая.
    return inputArray;
}
string[] MakeNoMoreThreeChar(string[] array)     //Метод создания результируещего строкового массива, где 
{                                                //длина строк меньше, либо равна 3-ем символам.
    int count = 0;                               //count - счетчик количества строк длиной меньше, либо 
    for (int i = 0; i < array.Length; i++)       //равной 3-ем символам в исходном массиве.
    {
        if (array[i].Length <= 3)                //длина i-ой строки исходного массива.
        {
            count = count + 1;
        }
    }
    string[] outArray = new string[count];       //инициализация результирующего массива длиной count.
    int j = 0;                                   //инициализация j - индексы результирующего массива.
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)                //длина i-ой строки исходного массива.
        {
            outArray[j] = array[i];              //присваиваем значения исходящего массива результирующему.
            j = j + 1;
        }
    }
    return outArray;
}
void PrintArray(string[] array)                  //Метод печати массива.
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != 0)                              //добавка для более красивого вывода массива.
        {
            Console.Write(" ");
        }
        Console.Write($" {array[i]}");
    }
    Console.Write(" ]");
    return;
}
Console.Write("Введите массив строк через запятую: ");
string input = Console.ReadLine();                         //ввод исходной строки.
string[] array = new string[1];                            //инициализация исходного массива.
string[] outArray = new string[1];                         //инициализация результирующего массива.
array = CreateArray(input);                                //вызов Метода создания входящего массива.
outArray = MakeNoMoreThreeChar(array);                     //вызов Метода создания результирующего массива.
Console.Write($"Из массива:  ");
PrintArray(array);                                         //печать заданного массива.
Console.WriteLine();
Console.Write($"получеам -->  ");
PrintArray(outArray);                                      //печать нового сформированного массива.