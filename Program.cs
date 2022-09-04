// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateArray(int size){
//     int[] array = new int[size];
//     for (int i=0; i < size; i++){
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }


// void ShowArray(int[] array){
//     Console.Write("[ ");
//     for(int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }

// int Func(int[] array){
//     int sum = 0;
//     for(int i=0; i < array.Length; i++){
//         if(array[i] % 2 == 0) sum++;
//     }
//     return sum;
// }

// Console.Write("Enter the size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// ShowArray(array);
// int sum = Func(array);
// Console.WriteLine();
// Console.WriteLine(sum);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i=0; i < size; i++){
//         array[i] = new Random().Next(min,max);
//     }
//     return array;
// }


// void ShowArray(int[] array){
//     Console.Write("[ ");
//     for(int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }

// int Func(int[] array){
//     int sum = 0;
//     for(int i=0; i < array.Length; i++){
//         if(i % 2 != 0) sum += array[i];;
//     }
//     return sum;
// }

// Console.Write("Enter the size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size, min, max);
// ShowArray(array);
// Console.WriteLine();
// int sum = Func(array);
// Console.WriteLine(sum);


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


// int[] CreateArray(int size){
//     int[] array = new int[size];
//     for (int i=0; i < size; i++){
//         array[i] = new Random().Next();
//     }
//     return array;
// }


// void ShowArray(int[] array){
//     Console.Write("[ ");
//     for(int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }

// int Min(int[] array){
//     int min = array[0];
//     for(int i=0; i < array.Length; i++){
//         if(array[i] < min) min = array[i];
//     }
//     return min;
// }

// int Max(int[] array){
//      int max = array[0];
//     for(int i=0; i < array.Length; i++){
//         if(array[i] > max) max = array[i];
//     }
//     return max;
// }

// Console.Write("Enter the size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// ShowArray(array);
// int min = Min(array);
// int max = Max(array);
// Console.WriteLine();
// Console.WriteLine(min);
// Console.WriteLine(max);
// int sum = max - min;
// Console.WriteLine(sum);

