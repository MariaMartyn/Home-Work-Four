// Задача 25. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
/*
int NumberPow (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    result = result * a;
    return result;
}
Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number {a} to power {b} is {NumberPow(a, b)}");
*/


// Задача 27. Напишите программу, которая принимат на вход число и выдает сумму цифр в числе.
/*
int SumNumber(int num)
{
    int result = 0;
    int s = num;
    int b;
        while (s > 0)
        {
         b = s %10;
         s= s / 10;
         result = result + b;
        }
    return result;
}

Console.WriteLine("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of digit {num} is {SumNumber(num)}");
*/


// Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран
/* 
int [] CreateArray ()
{
 Console.Write("Input size of massive: ");
 int size = Convert.ToInt32(Console.ReadLine());
 int[] newArr = new int[size];
    for (int i = 0; i <= newArr.Length-1; i++)
 {
    Console.WriteLine($"Input element of massive with index {i}: ");
    newArr[i] = Convert.ToInt32(Console.ReadLine());;
 }
    return newArr;
}

void PrintArray(int[] arr)
{
   for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + ", ");  
      
}

int[] newArr = CreateArray();
PrintArray(newArr);
*/