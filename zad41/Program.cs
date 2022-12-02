// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Какое количество чисел будем вводить?:");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = new int[m];
Console.WriteLine("Введите числа:");
for (int i = 0; i < array.Length; i++) array[i] = Convert.ToInt32(Console.ReadLine());
foreach (var i in array)
{
    if (i > 0) count++;
}
Console.WriteLine($"Количество чисел больше нуля: {count}");
