// 2. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int array = new Random().Next(0, 100);

int digit1 = array / 10;
int digit2 = array % 10;

Console.WriteLine (array);
Console.Write ("Наибольшее число: ");

if (digit1 > digit2) 
    Console.WriteLine(digit1); 

else
    Console.WriteLine(digit2);
