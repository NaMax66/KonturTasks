using System;

namespace ConsoleApp1
{
    class Program

    {
        static void Main(string[] args)
        {
            SecodTask obj = new SecodTask();

            Console.WriteLine("Введите число");

            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Перевернутое число:");
            Console.WriteLine(obj.Reverse(i));

        }

    }

    //Expr1.Как поменять местами значения двух переменных? 
    //Можно ли это сделать без ещё одной временной переменной.Стоит ли так делать?

    class FirstTask
    {
        public void ChangeValues(int x, int y)
        {
            x = x + y;
            y = y - x;
            y = -y;
            x = x - y;

            Console.WriteLine("x = {0}\n" +
                "y = {1}", x, y);
        }
    }

    //Expr2.Задается натуральное трехзначное число(гарантируется, что трехзначное).
    //Развернуть его, т.е.получить трехзначное число, записанное теми же цифрами в обратном порядке.
    class SecodTask
    {
        public int Reverse(int number)
        {
            String sNumber = number.ToString();
            char[] arr = sNumber.ToCharArray();
            Array.Reverse(arr);

            sNumber = new string(arr);

            return int.Parse(sNumber);
            
        }


    }
}
