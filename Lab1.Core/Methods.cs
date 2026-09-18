using System;
using System.Text;

namespace Lab1.Core
{
    public static class Methods
    {
        // 1.1 Сортировка массива (быстрая сортировка)
        public static int[] SortArray(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int[] result = (int[])array.Clone();
            QuickSort(result, 0, result.Length - 1);
            return result;
        }

        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right) return;

            int pivot = arr[(left + right) / 2];
            int i = left, j = right;

            while (i <= j)
            {
                while (arr[i] < pivot) i++;
                while (arr[j] > pivot) j--;

                if (i <= j)
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                    i++;
                    j--;
                }
            }

            QuickSort(arr, left, j);
            QuickSort(arr, i, right);
        }

        // 1.2 Проверка на палиндром
        public static bool IsPalindrome(string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));

            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        // 1.3 Факториал
        public static long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Число не может быть отрицательным", nameof(n));
            if (n > 20)
                throw new ArgumentOutOfRangeException(nameof(n), "Слишком большое число, переполнение long");

            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;

            return result;
        }

        // 1.4 Число Фибоначчи
        public static long Fibonacci(int position)
        {
            if (position < 0)
                throw new ArgumentException("Позиция не может быть отрицательной", nameof(position));
            if (position > 92)
                throw new ArgumentOutOfRangeException(nameof(position), "Переполнение long");

            if (position == 0) return 0;
            if (position == 1) return 1;

            long a = 0, b = 1;
            for (int i = 2; i <= position; i++)
            {
                long temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        // 1.5 Поиск подстроки
        public static int FindSubstring(string text, string substring)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));
            if (substring == null)
                throw new ArgumentNullException(nameof(substring));

            if (substring.Length == 0) return 0;
            if (substring.Length > text.Length) return -1;

            for (int i = 0; i <= text.Length - substring.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < substring.Length; j++)
                {
                    if (text[i + j] != substring[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found) return i;
            }
            return -1;
        }

        // 1.6 Проверка на простое число
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; (long)i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // 1.7 Реверс цифр 32-битного числа
        public static int ReverseInteger(int x)
        {
            long result = 0;
            int sign = x < 0 ? -1 : 1;
            long absX = Math.Abs((long)x);

            while (absX > 0)
            {
                result = result * 10 + absX % 10;
                absX /= 10;

                if (result > int.MaxValue)
                    return 0;
            }

            return (int)(result * sign);
        }

        // 1.8 Римская система счисления
        public static string ToRoman(int number)
        {
            if (number < 1 || number > 3999)
                throw new ArgumentOutOfRangeException(nameof(number),
                    "Число должно быть в диапазоне от 1 до 3999");

            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            var sb = new StringBuilder();
            for (int i = 0; i < values.Length; i++)
            {
                while (number >= values[i])
                {
                    sb.Append(symbols[i]);
                    number -= values[i];
                }
            }
            return sb.ToString();
        }
    }
}