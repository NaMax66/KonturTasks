using System;

namespace ConsoleApp1
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите время\n");
           int time = int.Parse(Console.ReadLine());
           Console.WriteLine(ThirdTask.GetDegree(time));
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
    //Expr3.Задано время Н часов(ровно). Вычислить угол в градусах между часовой и минутной стрелками.
    //Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов.Не использовать циклы.
   static class ThirdTask
    {
        static readonly int oneDegree = 30; //180 градусов это 6 часов на аналоговых часах
        public static String GetDegree(int time)
        {
            int degrees = 0;
            //todo разделить время time на два возможных случая и добавить исключения в 6 часов и 12 часов.
            if (time > 12)
            {
                time %= 12;
            }
            if (time > 6)
            {
                degrees = (12 - time) * oneDegree;
            }
            else degrees = time * oneDegree;

            return degrees.ToString() + "°";
        }


    }

    //Expr4.Найти количество чисел меньших N, которые имеют простые делители X или Y.
    class fourth
    {
    }



    //Expr5.Найти количество високосных лет на отрезке[a, b] не используя циклы.
    class fifth
    {

    }
        
    //Expr6.Посчитать расстояние от точки до прямой, заданной двумя разными точками.
    class sixth
    {

    }
    //Expr7.Найти вектор, параллельный прямой.Перпендикулярный прямой.
    //Прямая задана коэффициентами уравнения прямой.
    class seventh
    {

    }

    //Expr8.Дана прямая L и точка A. Найти точку пересечения прямой L с перпендикулярной ей прямой P, 
    //проходящей через точку A. Можете считать, что прямая задана либо двумя точками, 
    //либо коэффициентами уравнения прямой — как вам удобнее.
    class eighth
    {

    }
}
