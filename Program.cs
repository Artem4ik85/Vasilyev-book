using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задачу для запуска:");
        Console.WriteLine("1 - Задача 1: Приветствие");
        Console.WriteLine("2 - Задача 2: Сумма чисел");
        Console.WriteLine("3 - Задача 3: Проверка чётности");
        Console.Write("Введите номер задачи: ");
        
        string choice = Console.ReadLine();
        
        switch (choice)
        {
            case "1":
                Task1();
                break;
            case "2":
                Task2();
                break;
            case "3":
                Task3();
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
        
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
     
    static void Task1()
    {
        Console.WriteLine("\n=== Задача 1: Приветствие ===");
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}!");
    }
    
    static void Task2()
    {
        Console.WriteLine("\n=== Задача 2: Сумма чисел ===");
        int a = 5;
        int b = 10;
        int sum = a + b;
        Console.WriteLine($"Сумма {a} и {b} равна: {sum}");
    }
    
    static void Task3()
    {
        Console.WriteLine("\n=== Задача 3: Проверка чётности ===");
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number % 2 == 0)
            Console.WriteLine($"Число {number} чётное.");
        else
            Console.WriteLine($"Число {number} нечётное.");
    }
}