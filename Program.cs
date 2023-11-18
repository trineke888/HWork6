// ﻿// Задача №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// // сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // -1, -7, 567, 89, 223-> 3


// Console.Write("Введите числа через запятую: ");
// int[] numbers = StringToNum(Console.ReadLine()!); //пользовательский ввод
// PrintArray(numbers); //выводим массив
// int quan = 0;
// for (int i = 0; i < numbers.Length; i++) // ищем числа в массиве больше нуля
// {
//     if (numbers[i] > 0)
//     {
//         quan++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"количество значений больше 0 = {quan}"); //выводим результат


// int[] StringToNum(string input)  // вводим числа
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//         {
//             count++;
//         }
//     }

//     int[] numbers = new int [count];  //создаем массив из введенных чисел
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ',')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         numbers[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return numbers;
// }


// void PrintArray(int[] array)  //выводим массив
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }


// ﻿// №43 Напишите программу, которая найдёт точку пересечения двух прямых, 
// // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// // задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)



// double[,] coordinate = new double[2, 2];    //создаем массивы
// double[] crossPoint = new double[2];

// void Inputcoordinate()      //пользовательский ввод координат
// {
//   for (int i = 0; i < coordinate.GetLength(0); i++)
//   {
//     Console.Write($"Введите координаты {i+1}-го уравнения (y = k * x + b):\n");
//     for (int j = 0; j < coordinate.GetLength(1); j++)
//     {
//       if(j==0) Console.Write($"Введите координату k: ");
//       else Console.Write($"Введите координату b: ");
//       coordinate[i,j] = Convert.ToInt32(Console.ReadLine());
//     }
//   }
// }

// double[] SearchCrossPoint(double[,] coordinate) //нахождение точки пересечения
// {
//   crossPoint[0] = (coordinate[1,1] - coordinate[0,1]) / (coordinate[0,0] - coordinate[1,0]);
//   crossPoint[1] = crossPoint[0] * coordinate[0,0] + coordinate[0,1];
//   return crossPoint;
// }

// void OutputСoordinate(double[,] coordinate)     //вывод результата
// {
//   if (coordinate[0,0] == coordinate[1,0] && coordinate[0,1] == coordinate[1,1]) 
//   {
//     Console.Write($"\nПрямые совпадают");
//   }
//   else if (coordinate[0,0] == coordinate[1,0] && coordinate[0,1] != coordinate[1,1]) 
//   {
//     Console.Write($"\nПрямые параллельны");
//   }
//   else 
//   {
//     SearchCrossPoint(coordinate);
//     Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
//   }
// }

// Inputcoordinate();
// OutputСoordinate(coordinate);