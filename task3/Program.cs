// 3. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите 1-ое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2-ое число: ");
int number2 = int.Parse(Console.ReadLine()!);

int remainder = number1 % number2;

if(remainder == 0)
    Console.WriteLine("Кратно!");
else
    Console.WriteLine($"Не кратно! Остаток {remainder}");
