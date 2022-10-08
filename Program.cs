// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.Write("Какое количество цифр вы хотите ввести: ");
int size = int.Parse(Console.ReadLine()!);  //количество чисел
Console.WriteLine($"Количество чисел больще ноля = {SortNumbers(size)}");

int SortNumbers(int nowSize){   // Введение и обработка введёных с консоли чисел
    int count = 0;  //количество чисел больше 0
    for(int i = 1; i <= nowSize; i++){
        Console.Write($"{i} число = ");
        int numbers = int.Parse(Console.ReadLine()!);
        if (numbers > 0) count++;
    }
    return count;
}