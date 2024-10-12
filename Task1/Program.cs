using System;
using System.Runtime.CompilerServices;

class Program
{

    static void Main()
    {
        int[] a = [10, 20, 30, 40, 50, 60, 70, 80, 90, 99];
        for (int i = 0; i < 10; i ++)
        {
            if(a[i] > 20 && a[i] < 90) 
            {
                Console.Write(a[i]);
                Console.Write(", ");
            }
        }

    }
}
