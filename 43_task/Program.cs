// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2    ->     0 = k1 * x - k2 * x + b1 - b2 - > b2 - b1 = (k1 - k2) x - > x = (b2 - b1) / (k1 - k2)  
// y = k1 * (b1 - b2) / (k1 - k2) + b1

string ReadString(string msg) // объявление функции
{
    System.Console.WriteLine(msg); // вывод на экран параметра msg функции
    string inputString = Console.ReadLine(); // считывает строку из консоли
    return inputString; // возврат значения
}

int ReadInt(string msg) // объявление функции
{
    int number = int.Parse(ReadString(msg)); // преобразует строку в число
    return number; // возврат значения
}

bool ReadAnswear(string msg)
{   
    bool result = false;
    bool correctAnswear = false;
    while (!correctAnswear)
    {
        string answear = ReadString($"{msg} Ответьте Y/N: ");
        if (answear.ToUpper() == "Y")
        {
            result = true;
            correctAnswear = true;
        }
        else if (answear.ToUpper() == "N")
        {
            result = false; 
            correctAnswear = true;
        }
        else
        {
            System.Console.WriteLine("Некорректный ответ. Попробуйте еще раз. ");
        }

    }
    return result;
}

(double, double) IntersectionStraightLines(double k1, double k2, double b1, double b2)
{
    double x = x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    return (x, y);
}

int b1 = 2; 
int k1 = 5; 
int b2 = 4; 
int k2 = 9;
if (ReadAnswear("Хотите ввести коэффициенты вручную?")) 
{
    k1 = ReadInt("Введите значение k1: ");
    k2 = ReadInt("Введите значение k2: ");
    b1 = ReadInt("Введите значение b1: ");
    b2 = ReadInt("Введите значение b2: ");
}

(double x, double y) = IntersectionStraightLines(k1, k2, b1, b2);

System.Console.WriteLine($"Точка пересечения прямых y = {k1}x + {b1} и y = {k2}x + {b2} находится в точке ({x}; {y})");