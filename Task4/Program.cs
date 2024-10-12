using System;

class Program
{
    static void Main()
    {

        Console.Write("Введите натуральное число (1-100000): ");
        int number = int.Parse(Console.ReadLine());

        if (number < 1 || number > 100000)
        {
            Console.WriteLine("Число должно быть в диапазоне от 1 до 100000.");
            return;
        }

        int[] digitArray = NumberToDigitArray(number);

        Console.WriteLine("Массив цифр: " + string.Join(", ", digitArray));
    }

    static int[] NumberToDigitArray(int n)
    {
        char[] digits = n.ToString().ToCharArray();
        int[] digitArray = new int[digits.Length];

        for (int i = 0; i < digits.Length; i++)
        {
            digitArray[i] = (int)(digits[i] - '0');
        }
        return digitArray;
    }
}