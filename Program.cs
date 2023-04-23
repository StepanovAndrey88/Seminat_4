// Задача 25: Напишите цикл, который принимает на вход
// два числа (А и В) и возводит число А в натуральную степень В.
// Пример:
// 3,5 -> 243 (35)
// 2,4 -> 16

Console.WriteLine("Введите целое число А");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число В");
int num2 = Convert.ToInt32(Console.ReadLine());

double d=Math.Pow((num1),num2);
d=Math.Round(d,2);
Console.WriteLine(d);

 
// Задача 27: Напишите программу, 
// которая принимает на вход число и 
// выдает сумму цифр в числе.
// Пример:
// 452->11
// 82->10
// 9012->12

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(num > 0)
{
    sum+= num % 10;
    num/= 10;
}
Console.WriteLine(sum);

 
// Задача 29: Напишите программу, 
// которая задает массив из 8 элементов и выводит их на экран.
// Пример:
// 1,2,5,7,19->[1,2,5,7,19]
// 6,1,33->[6,1,33]

int[] numArr = new int[8];
for(int i=0;i<numArr.Length;i++)
{
    numArr[i] = new Random().Next(0,100);
}
Console.WriteLine(String.Join(",",numArr));


