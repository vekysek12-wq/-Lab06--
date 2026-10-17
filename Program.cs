// Console.WriteLine("Hello, World!");

// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }

// for (int i = 1; i <= 50; i+=2)
// {
//     Console.WriteLine(i);
// }


// int sum = 0;
// int count = 0;
// for (int i = 1; i <= 100; i++) {
//     if (i % 3 == 0)
//     {
//         sum += i;
//     }
//     if (i % 7 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Чисел, кратных 3: {sum}");
// Console.WriteLine($"количество чисел, которые делятся на 7: {count}");


// int num = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// int b = 0;

// while (num != 0)
// {
//     if (num > 0)
//     {
//         a++;
//     }
//     if (num < 0)
//     {
//         b++;
//     }
//    num = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"+{a}");
// Console.WriteLine($"-{b}");


// for (int i = 0; i < 3; i++)
// {
//     Console.Write("Введите пароль: ");
//     string? password = Console.ReadLine();

//     if (password == "qwerty")
//     {
//         Console.WriteLine("Доступ разрешен");
//         return;
//     }
// }

// Console.WriteLine("Доступ запрещен");


// int num1 = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i<11; i++)
// {
//     Console.WriteLine($"{num1} x {i} = {num1 * i}");
// }


// for (int i = 1; i <= 30; i++)
// {
//     if (i % 10 == 0 && i > 20)
//     {
//         break;
//     }

//     if (i % 3 == 0)
//     {
//         continue;
//     }

//     Console.WriteLine(i);
// }

int secret = 42;
int attempts = 5;
bool guessed = false;

for (int i = 1; i <= attempts; i++)
{
    Console.Write($"Попытка {i}/{attempts}. Введите число: ");
    int guess = int.Parse(Console.ReadLine()!);

    if (guess == secret)
    {
        Console.WriteLine($"Победа! Попыток: {i}");
        guessed = true;
        break;
    }
    else if (guess < secret)
    {
        Console.WriteLine("Больше");
    }
    else
    {
        Console.WriteLine("Меньше");
    }
}

if (!guessed)
{
    Console.WriteLine($"Вы проиграли, число было {secret}");
}

