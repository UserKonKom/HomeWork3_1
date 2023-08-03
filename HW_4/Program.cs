/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int maxNum = 0;
if (num1 > maxNum) maxNum = num1;
if (num2 > maxNum) maxNum = num2;
if (num3 > maxNum) maxNum = num3;
Console.Write("Максимальное значение имеет число " + maxNum);