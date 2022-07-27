/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29*/

public class Test
{
        public static int recursion(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        } 
        else if (n == 0 && m > 0)
        {
            return recursion(m - 1, 1);
        } 
        else
        {
            return recursion(m - 1, recursion(m, n - 1));
        }
    }
              public static void Main()
    {
       
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine(recursion(m, n));
    }
}

