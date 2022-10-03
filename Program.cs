/* Задача:
Написать программу, которая из имеюшегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
с клавиатуры. либо задать на старте выполнения алгоритма. При решении не 
рекомендуется пользоваться коллекциями. лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

var Log = (string text) => Console.WriteLine(text);
var ArrayToString = (string[] array) => "[" + String.Join(", ", array.Select(e => $"\"{e}\"")) + "]";

string[] test1 = { "hello", "2", "world", ":-)" };
string[] test2 = { "1234", "1567", "-2", "computer science" };
string[] test3 = { "Russia", "Denmark", "Kazan" };

int max_length = 3;


string[] result1 = FilterStrings(test1, max_length);
string[] result2 = FilterStrings(test2, max_length);
string[] result3 = FilterStrings(test3, max_length);

Log($"Test 1:\n{ArrayToString(test1)} -> {ArrayToString(result1)}\n");
Log($"Test 2:\n{ArrayToString(test2)} -> {ArrayToString(result2)}\n");
Log($"Test 3:\n{ArrayToString(test3)} -> {ArrayToString(result3)}\n");


string[] FilterStrings(string[] array, int max_length)
{
    string[] result = new string[0];
    int len = array.Length;

    for (int i = 0; i < len; i++)
    {
        string str = array[i];
        int str_length = str.Length;

        if (str_length <= max_length)
        {
            result = PushString(result, str);
        }
    }

    return result;
}

string[] PushString(string[] array, string str)
{
    int len = array.Length;
    string[] result = new string[len + 1];

    for (int i = 0; i < len; i++)
    {
        result[i] = array[i];
    }

    result[len] = str;
    return result;
}