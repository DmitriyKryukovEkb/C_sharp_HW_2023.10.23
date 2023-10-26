// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string ReadString(string msg) // объявление функции
{
    System.Console.WriteLine(msg); // вывод на экран параметра msg функции
    string inputString = Console.ReadLine(); // считывает строку из консоли
    return inputString; // возврат значения
}

List <int> ReadNumbers()
{
    List <int> numbers = new();
    while (true)
    {
        string inputString = ReadString("Введите следующее число, для выхода из цикла введите 'q': ");
        if (inputString == "q") 
        {
            break;
        }
        bool isNumber = int.TryParse(inputString, out int numericValue);
        if (isNumber)
        {
            numbers.Add(numericValue);
        }
    }
    return numbers;
}

void printList(List <int>  inputList)
{   
    Console.Write("<" + inputList[0]);
    for (int i = 1; i < inputList.Count; i++)
    {
        Console.Write(", " + inputList[i]);
    }
    Console.Write("> ");
    // foreach (var item in inputList) // цикл для работы с массивом
    // {
    //     Console.Write(item + ", ");
    // }
}

int positiveCount(List <int> inputList)
{
    int posCount = 0;
    foreach(int item in inputList)
    {
        if (item > 0)
        {
            posCount ++;
        }
    }
return posCount;
}

List <int> firstList = ReadNumbers();
Console.Write("Введенный список: ");
printList(firstList);
Console.WriteLine($"Положительных значений в списке {positiveCount(firstList)}");
