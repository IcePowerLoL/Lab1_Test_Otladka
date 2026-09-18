using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tasks.Rim(2024));
        }
    }

    public static class Tasks
    {
        
        public static int[] Sort(int[] mas)
        {
            if (mas == null)
            {
                throw new ArgumentNullException(nameof(mas), "Массив не может быть null!");
            }
            if (mas.Length <= 1)
            {
                return mas;
            }
            int[] res = (int[])mas.Clone();
            for (int i = 0; i < res.Length - 1; i++)
            {
                for (int j = 0; j < res.Length - i - 1; j++)
                {
                    if (res[j] > res[j + 1])
                    {
                        int temp = res[j];
                        res[j] = res[j + 1];
                        res[j + 1] = temp;
                    }
                }
            }
            return res;
        }

        public static bool Palindrome(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static long Factorial(int x)
        {
            if (x < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(x));
            }
            if (x == 0 || x == 1) return 1;
            return (Factorial(x - 1) * x);
        }

        public static long Fibonacci(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            long a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                long temp = a + b;
                a = b;
                b = temp;
            }
            return a;
        }

        public static int FindSubStr(string str, string a)
        {
            if (str == null || a == null)
            {
                throw new ArgumentNullException("Аргументы не могут быть null");
            }
            return str.IndexOf(a);
        }

        public static bool Prost(int x)
        {
            if (x <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int Reverse(int x)
        {
            long res = 0;

            while (x != 0)
            {
                int temp = x % 10;
                res = res * 10 + temp;
                x /= 10;
            }
            if (res >= int.MinValue && res <= int.MaxValue)
            {
                return (int)res;
            }
            return 0;
        }

        public static string Rim(int x)
        {
            var map = new (int Value, string Symbol)[]
            {
                (1000, "M"),
                (900,  "CM"),
                (500,  "D"),
                (400,  "CD"),
                (100,  "C"),
                (90,   "XC"),
                (50,   "L"),
                (40,   "XL"),
                (10,   "X"),
                (9,    "IX"),
                (5,    "V"),
                (4,    "IV"),
                (1,    "I"),
            };

            var result = new System.Text.StringBuilder();

            foreach (var (value, symbol) in map)
            {
                while (x >= value)
                {
                    result.Append(symbol);
                    x -= value;
                }
            }

            return result.ToString();
        }
    }
}