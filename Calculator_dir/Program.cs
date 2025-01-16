using System;
using System.Collections.Generic;

namespace Calculator_dir
{
    public partial class Calculator
    {
        public int first_num { get; set; }

        public int second_num { get; set; }


        public Calculator(int firstNum, int secondNum)
        {
            first_num = firstNum;
            second_num = secondNum;
        }

        // Перегруженный конструктор для сортировки
        public Calculator(int a, int b, int c)
        {
            SortNumbers(ref a, ref b, ref c);
            Console.WriteLine($"Отсортированные числа: {a}, {b}, {c}");
        }

        
        public void Add()
        {
            Console.WriteLine(first_num + second_num);
        }


        public void Subtract()
        {
            Console.WriteLine(first_num - second_num);
        }

        public void Multiply()
        {
            Console.WriteLine(first_num * second_num);
        }

        public void Divide()
        {
            if (second_num == 0)
            {
                Console.WriteLine("Деление на ноль невозможно!");
            }
            else
            {
                Console.WriteLine(first_num / second_num);
            }
        }

        // Сортировка чисел ref
        public void SortNumbers(ref int a, ref int b, ref int c)
        {
            if (a > b) { (a, b) = (b, a); }
            if (b > c) { (b, c) = (c, b); }
            if (a > b) { (a, b) = (b, a); }
        }
        
        public void DivideWithRemainder(out int result, out int remainder)
        {
            if (second_num == 0)
            {
                Console.WriteLine("Деление на ноль невозможно!");
                result = 0; 
                remainder = 0;
            }
            else
            {
                result = first_num / second_num;
                remainder = first_num % second_num;
            }
        }
        
        public int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static void Main(string[] args)
        {

            Calculator calculator1 = new Calculator(15, 25);
            calculator1.Add();
            Console.WriteLine();


            Calculator calculator2 = new Calculator(15, 25);
            calculator2.Subtract();
            Console.WriteLine();

            Calculator calculator3 = new Calculator(15, 25);
            calculator3.Multiply();
            Console.WriteLine();

            Calculator calculator4 = new Calculator(15, 25);
            calculator4.Divide();
            Console.WriteLine();

            int num1 = 10;
            int num2 = 5;
            int num3 = 15;
            
            Calculator calculator5 = new Calculator(num1, num2, num3);

            Console.WriteLine();
            
            
            Calculator calculator6 = new Calculator(17, 5);
            calculator6.DivideWithRemainder(out int res, out int rem);
            Console.WriteLine($"Результат деления: {res}, Остаток: {rem}");

            Console.WriteLine();


            Calculator calculator7 = new Calculator(5, 0);
            calculator7.DivideWithRemainder(out int res2, out int rem2);
            Console.WriteLine($"Результат деления: {res2}, Остаток: {rem2}");
            
            Console.WriteLine();
            
            Calculator calculator8 = new Calculator(3, 5);
            
            int sum1 = calculator8.Sum(15, 21, 63, 44, 56);
            Console.WriteLine($"Сумма: {sum1}");
            
            Console.WriteLine();

            int sum2 = calculator8.Sum(); // вызов без параметров
            Console.WriteLine($"Сумма: {sum2}");
            
            Console.WriteLine();

            int sum3 = calculator8.Sum(10, 20, 30);
            Console.WriteLine($"Сумма: {sum3}");
        }
    }
}
