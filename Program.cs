// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] rnd = GetArr(15);

// Console.WriteLine($"{String.Join(" ~ ", rnd)}");

// int count = 0;
// for (int i = 0; i < rnd.Length; i++)
// {
//     if (rnd[i]%2 == 0)
//     {
//         count += 1;
//     }
// }
// Console.WriteLine($"В массиве {count} чётных цифр(ы).");

//         int[] GetArr(int size)
//         {
//             int[] rnd = new int[size];
//             for (int i = 0; i < rnd.Length; i++)
//             {
//                 rnd[i] = new Random().Next(100,1000);
//             }
//             return rnd;
//         }

// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] rnd = arr(8);
                                                        // Console.WriteLine($"{String.Join(" ~ ", rnd)}");

int sum = 0;
for (int i = 1; i < rnd.Length; i += 2)
{
        sum += rnd[i];
}
Console.WriteLine($"[{String.Join(", ", rnd)}] -> {sum}");

int[] arr(int size)
{   int[] rnd = new int[size];
    for (int i = 0; i < rnd.Length; i++)
    {
        rnd[i] = new Random().Next(15);
    }
    return rnd;
}

// Задача 37:
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
