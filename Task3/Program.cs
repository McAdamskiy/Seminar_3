using System;

class Program
{
    static void Main()
    {
        double[] a = [2.3, 4.6, 4.9, 9.8, 5.2, 1.1, 13.6];
        Array.Sort(a);
        Console.WriteLine(a[6] - a[0]);
    }
}