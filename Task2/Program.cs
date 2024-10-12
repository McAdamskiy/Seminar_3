using System;

class Program
{
    static void Main()
    {
        int n = 0;
        int[] a = [7, 9, 8, 43, 66, 66, 84, 68, 95, 72];
        for(int i = 0; i < 10; i ++)
        {
            if(a[i] % 2 == 0)
            {
                n ++;
            }
        }
        System.Console.WriteLine(n);
    }
}