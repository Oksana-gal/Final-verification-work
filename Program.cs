/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
string[] inputArray = new string[4] {"Hello", "2", "world", ":-)"};
string[] outputArray = new string[inputArray.Length];

SecondArrayWithIF(inputArray, outputArray);
PrintArray(outputArray);

void SecondArrayWithIF(string[] inputArray, string[] outputArray)
{
    int outputIndex = 0;
    for (int inputIndex = 0; inputIndex < inputArray.Length; inputIndex++)
    {
        if(inputArray[inputIndex].Length <= 3)
        {
            outputArray[outputIndex] = inputArray[inputIndex];
            outputIndex++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}