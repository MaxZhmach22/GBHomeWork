using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        //// 1.Написать метод, возвращающий минимальное из трёх чисел. Жмачинский

        //static int Minint(int a, int b, int c)
        //{
        //    int min;
        //    if (a < b && a < c)
        //    {
        //        min = a;
        //    }
        //    else
        //    {
        //        if (b < c)
        //        {
        //            min = b;
        //        }
        //        else
        //        {
        //            min = c;
        //        }
        //    }
        //    return min;
        //}

        //// 2. Метод подсчета количества цифр числа. Жмачинский
        ///
        //static long NumbersCount(long a)
        //{
        //    a = Math.Abs(a);
        //    string str = a.ToString();
        //    return str.Length;
        //}


        //// 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, 
        ////    и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать
        ////    программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
        ////    С помощью цикла do while ограничить ввод пароля тремя попытками. Жмачинский
        ///
        //public static bool CompareUserAnsw(string userlogin, string userpassword)
        //{
        //    string login, password;
        //    login = "root";
        //    password = "GeekBrains";
        //    if (userpassword == password && userlogin == login)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}

        ////6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        ////    Хорошим называется число, которое делится на сумму своих цифр. 
        ////    Реализовать подсчет времени выполнения программы, используя структуру DateTime. Жмачинский

        //static long RecursivSum(long a)
        //{
        //    if (a == 0)
        //    {
        //        return 0;
        //    }
        //    else return RecursivSum(a / 10) + a % 10;
        //}

        //// 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
        ////    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b. Жмачинский

        //static public int recOutput(int a, int b)
        //{
        //    if (a == 0 && b == 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        Console.Write(b+" ");
        //        return recOutput(a, b - 1);
        //    }

        //}

        //static public int recSum(int a, int b)
        //{
        //    int sum = 0;
        //    if (a == 0 && b == 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {

        //        return recSum(a, b - 1) + sum + b;
        //    }

        //}


        static void Main(string[] args)
        {
            //// Написать метод, возвращающий минимальное из трёх чисел. Жмачинский
            //int a, b, c;
            //Console.Write("Введите первое число: ");
            //bool f = int.TryParse(Console.ReadLine(), out a);
            //Console.Write("Введите второе число: ");
            //bool k = int.TryParse(Console.ReadLine(), out b);
            //Console.Write("Введите третье число: ");
            //bool u = int.TryParse(Console.ReadLine(), out c);
            //Console.WriteLine(Minint(a,b,c));
            //Console.ReadLine();


            //// 2. Метод подсчета количества цифр числа. Жмачинский
            //long a;
            //Console.Write("Введите число: ");
            //bool f = long.TryParse(Console.ReadLine(), out a);
            //Console.WriteLine($"Количество цифра в введенном числе: {NumbersCount(a)}");
            //Console.ReadLine();



            //// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел. Жмачинский
            ///
            //string imputstr = "";
            //long imputint;
            //long sum = 0;
            //Console.WriteLine("Введите числа с клавитуры: ");
            //while (true)
            //{

            //    string numbers = Console.ReadLine();
            //    if (Convert.ToInt32(numbers) == 0)
            //    {
            //        imputstr += numbers;
            //        break;
            //    }
            //    else if (Convert.ToInt32(numbers) < 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        imputstr += numbers;
            //    } 
            //}

            //imputint = Convert.ToInt32(imputstr);

            //for (int i = 0; i < imputstr.Length; i++)
            //{
            //    if ((imputint % 10) % 2 != 0)
            //    {
            //        sum += imputint % 10;
            //        imputint /= 10;
            //    }
            //    else
            //    {
            //        imputint /= 10;
            //    }
            //}
            //Console.WriteLine($"Сумма нечетных положительных чисел: {sum}");
            //Console.ReadKey();

            //// 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, 
            ////    и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать
            ////    программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
            ////    С помощью цикла do while ограничить ввод пароля тремя попытками. Жмачинский

            //string userlogin, userpassword;
            //int maxtrycount = 3;
            //do
            //{
            //    Console.Write("Введите логин: "); userlogin = Console.ReadLine();
            //    Console.Write("Введите пароль: "); userpassword = Console.ReadLine();
            //    if (CompareUserAnsw(userlogin, userpassword) == true)
            //    {
            //        Console.WriteLine("Вы успешно авторизованы!");
            //        Console.ReadKey();
            //        break;
            //    }
            //    else
            //    {
            //        maxtrycount = maxtrycount - 1;
            //        if(maxtrycount == 0)
            //        {
            //            Console.WriteLine("У вас закончились попытки.");
            //            Console.ReadKey();
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Неправильный логин или пароль. У вас осталось {maxtrycount}");
            //        }
            //    }

            //} while (maxtrycount != 0);

            ////5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
            ////      нужно ли человеку похудеть, набрать вес или все в норме. 
            ////   б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса. Жмачинский

            //double h, m, hightValue, lowValue, BMI, BMIkg;
            //Console.Write("Введите ваш рост в см : "); h = Convert.ToDouble(Console.ReadLine()) / 100;
            //Console.Write("Введите ваш вес в кг : "); m = Convert.ToDouble(Console.ReadLine());
            //BMI = m / (h * h);
            //BMIkg = m / BMI;
            //hightValue = 24.99;
            //lowValue = 18.5;
            //double x = BMI > 24.99 ? hightValue : lowValue;
            //double toChangeMass = BMIkg * (BMI - x);
            //if (BMI >= lowValue && BMI <= hightValue)
            //{
            //    Console.WriteLine("Ваш вес в норме!");
            //}
            //else if (BMI >= 25 && BMI <= 30)
            //{
            //    Console.WriteLine($"У вас избыточная масса тела (предожирение), вам необходимо сбросить {toChangeMass:F2} кг.");
            //}
            //else if (BMI >= 30 && BMI <= 35)
            //{
            //    Console.WriteLine($"У вас ожирение первой степени, вам необходимо сбросить {toChangeMass:F2} кг.");
            //}
            //else if (BMI >= 35 && BMI <= 40)
            //{
            //    Console.WriteLine($"У вас ожирение второй степени, вам необходимо сбросить {toChangeMass:F2} кг.");
            //}
            //else if (BMI>40)
            //{
            //    Console.WriteLine($"У вас ожирение третей степени, вам необходимо сбросить {toChangeMass:F2} кг.");
            //}
            //else if (BMI < lowValue)
            //{
            //    Console.WriteLine($"У вас деостаточная масса тела, вам необходимо набрать {-1 * toChangeMass:F2} кг.");
            //}
            //else
            //{
            //    Console.WriteLine($"У вас выраженный дефицит массы тела, вам необходимо набрать {-1 * toChangeMass:F2} кг.");
            //}

            //Console.ReadKey();

            ////6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            ////    Хорошим называется число, которое делится на сумму своих цифр. 
            ////    Реализовать подсчет времени выполнения программы, используя структуру DateTime. Жмачинский

            //int goodvalue = 0;
            //DateTime d1 = DateTime.Now;
            //for (int i = 1; i < 1000000000; i++)
            //{
            //    string numb = i.ToString();

            //        if(numb.Length == 1)
            //        {
            //        goodvalue++;  
            //        }
            //        else if (numb.Length > 1 && i % RecursivSum(i) == 0)
            //        {
            //            goodvalue++;
            //        }


            //}
            //Console.WriteLine($"{goodvalue}");
            //Console.WriteLine($"Время выполнения задачи: {DateTime.Now - d1}"); // 61574509 чисел. Время выполнения задачи: 00:04:47.5360024
            //Console.ReadKey();


            //// 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
            ////    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b. Жмачинский

            //int a, b;
            //Console.Write("Введите число а: "); bool f  = int.TryParse(Console.ReadLine(), out a);
            //Console.Write("Введите число b: "); bool u = int.TryParse(Console.ReadLine(), out b);

            //Console.WriteLine(recOutput(a,b));
            //Console.WriteLine(recSum(a, b));
            //Console.ReadKey();


        }


    }
}
