// Задача 66: Задайте значения m и n. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от m до n.
// m = 1; n = 15 -> 120
// m = 4; n = 8. -> 30


int SumRec(int m, int n)
{
    if (n == m) return n;
    return n + SumRec(m, n - 1);

}


Console.Clear();
Console.WriteLine("Введите целое число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число n(должно быть больше числа m): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных элементов от m до n: {SumRec(m, n)}");

