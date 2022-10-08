// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

// Console.Write("Какое количество цифр вы хотите ввести: ");
// int size = int.Parse(Console.ReadLine()!);  //количество чисел
// Console.WriteLine($"Количество чисел больще ноля = {SortNumbers(size)}");

int SortNumbers(int nowSize){   // Введение и обработка введёных с консоли чисел
    int count = 0;  //количество чисел больше 0
    for(int i = 1; i <= nowSize; i++){
        Console.Write($"{i} число = ");
        int numbers = int.Parse(Console.ReadLine()!);
        if (numbers > 0) count++;
    }
    return count;
}

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задайте точку b1:");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте точку b2:");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте точку k1:");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте точку k2:");
double k2 = double.Parse(Console.ReadLine()!);

double Point0 = (b2-b1)/(k1-k2);

double Point1 = (k1*(b2-b1))/(k1-k2)+b1;
Console.WriteLine($"Координаты пересечения:({Point0}; {Point1})");

