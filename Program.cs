// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] rnd = GetArr(15);

//                                                 // Console.WriteLine($"{String.Join(" ~ ", rnd)}");

// int count = 0;
// for (int i = 0; i < rnd.Length; i++)
// {
//     if (rnd[i]%2 == 0)
//     {
//         count += 1;
//     }
// }
// Console.WriteLine($"[{String.Join(", ", rnd)}] -> {count} четных чисел в массиве.");

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



// Задача 37:
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


    int[] rnd = GetArr(8);
    int size = rnd.Length;
    int[] newArr = new int[size];
    int[] ArrSumm = new int[size/2];
    int count = newArr.Length;
    if (size%2 != 0)
    {
        Console.WriteLine("Число нечетное. Введите четное число");
    }
    else
    {
        for (int i = 0; i < rnd.Length; i++)        // Переворот массива
        {
            count -= 1;
            newArr[count] = rnd[i];
        }

        for (int j = 0; j < ArrSumm.Length; j++)    //Суммированмие элементов массивов
        {
            ArrSumm[j] = rnd[j] + newArr[j];
        }

    Console.WriteLine($"[{String.Join(", ", rnd)}] -> [{String.Join(", ", ArrSumm)}]");
    }

    int[] GetArr(int size)                          // Метод заполнения массива случайными числами
    {
    int[] rnd = new int[size];
    for (int i = 0; i < rnd.Length; i++)
    {
    rnd[i] = new Random().Next(15);  
    }
    return rnd;
    }