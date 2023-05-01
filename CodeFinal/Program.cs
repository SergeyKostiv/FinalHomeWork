// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

/*Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] words(string[] array)
{

    string[] NewWords = new string[11];

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            NewWords[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref NewWords, count);
    return NewWords;
}

void Print(string[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
}

// string[] NewArray = { "hello", "2", "world", ":-)"};  
// string[] NewArray = { "1234", "1567", "-2", "computer science"};
string[] NewArray = { "Russia", "Denmark", "Kazan" };

Print(words(NewArray));

