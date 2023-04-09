// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

for (int i = 1; i < num; i++)
{
    int result = i * i * i;
    Console.Write($"{result}, ");
}
Console.Write($"{num*num*num}");
