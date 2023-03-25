Console.WriteLine("Введите число a");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
Console.WriteLine("Введите число b");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
Console.WriteLine("Введите число c");
string input3 = Console.ReadLine();
int number3 = int.Parse(input3);
int max;
 if (number1 >= number2)
 {
    if (number3 >= number1)
    {
       Console.WriteLine($"Максимальное число {number3}");
    }
    else
    {
       Console.WriteLine($"Максимальное число {number1}");
    }
 }
 else
 {
    if (number3 >= number2)
    {
       Console.WriteLine($"Максимальное число {number3}");
    }
    else
    {
       Console.WriteLine($"Максимальное число {number2}");
    }
 }
