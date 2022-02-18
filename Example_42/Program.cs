// 42.Определить сколько чисел больше 0 введено с клавиатуры

Console.Write("Введите колличество чисел: ");
int volume = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < volume; i++)
    
    {
        Console.Write($"Введите число {i + 1}: ");
        int x = int.Parse(Console.ReadLine());
        if (x > 0) count++;
    }

Console.WriteLine($"С клавиатуры введено {count} чисел больше ноля");