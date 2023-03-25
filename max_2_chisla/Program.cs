Console.WriteLine("Введите число a");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
Console.WriteLine("Введите число b");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

if (number1>number2)
{
    Console.WriteLine($"Максимальное число {number1}");
}
else
{
    Console.WriteLine($"Максимальное число {number2}");
}