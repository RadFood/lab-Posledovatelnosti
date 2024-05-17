using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    public static List<int> Even(List<int> list1)
    {
        return list1.Where(x => x % 2 != 0).ToList();
    }
    public static List<int> Zero(List<int> list1)
    {
        List<int> rez2 = new List<int>();
        int zeros = 0;

        foreach (int n in list1)
        {
            if (n == 0)
            {
                zeros++;
                if (zeros == 2)
                {
                    zeros = 1;
                    continue;
                }
            }
            if (zeros == 1)
            {
                continue;// Пропуск элемента между первым и вторым нулем.
            }
            rez2.Add(n);
        }
        return rez2; // Добавл. элемент n в rez2.
    }
    static void Main()
    {
        Console.WriteLine("Введите числовую последовательность состоящую из 6 членов: ");
        Console.WriteLine("1 член = ");
        int x1 = int.Parse(Console.ReadLine());
        Console.WriteLine("2 член = ");
        int x2 = int.Parse(Console.ReadLine());
        Console.WriteLine("3 член = ");
        int x3 = int.Parse(Console.ReadLine());
        Console.WriteLine("4 член = ");
        int x4 = int.Parse(Console.ReadLine());
        Console.WriteLine("5 член = ");
        int x5 = int.Parse(Console.ReadLine());
        Console.WriteLine("6 член = ");
        int x6 = int.Parse(Console.ReadLine());

        List<int> list1 = new List<int> { x1, x2, x3, x4, x5, x6 };

        var rez1 = Even(list1);
        var rez2 = Zero(list1);
        Console.WriteLine($"Исходная последовательность:" + string.Join(", ", list1));
        Console.WriteLine($"После удаления четных элементов:" + string.Join(", ", rez1));
        Console.WriteLine($"После удаления нулевых элементов:" + string.Join(", ", rez2));

    }
}