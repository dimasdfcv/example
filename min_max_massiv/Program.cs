// Напишите программу, которая приниматет на вход длину массива, 
// минимальное значение массива и максимальное значение массива, 
// создаёт массив с заданными параметрами и выводит значения на экран
// 5, 1, 19 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}