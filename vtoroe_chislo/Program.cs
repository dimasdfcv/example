
//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзанчное число:");
int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;
if (Length == 3) {
	int digit = ( Value/10 ) % 10;
	Console.WriteLine("Второе число: " + digit);
} else {
	Console.WriteLine("Вы ввели не трехначное число");
}
