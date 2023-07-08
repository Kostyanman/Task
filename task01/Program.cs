Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == number1 * number1)

{
    Console.WriteLine($"Да, число {number2} является квадратом числа {number1}");
}
else
{
    Console.WriteLine($"Нет, число {number2} Не является квадратом числа {number1}");
}