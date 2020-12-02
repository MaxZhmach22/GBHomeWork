using System;

namespace HomeWork03
{
    //// 1 а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
    ////      Продемонстрировать работу структуры. Жмачинский

    //struct Complex_struck
    //{
    //    public double Im;
    //    public double Re;

    //    public Complex_struck Plus(Complex_struck x)
    //    {
    //        Complex_struck Z;
    //        Z.Im = Im + x.Im;
    //        Z.Re = Re + x.Re;
    //        return Z;
    //    }

    //    public Complex_struck Minus(Complex_struck x)
    //    {
    //        Complex_struck Z;
    //        Z.Im = Im - x.Im;
    //        Z.Re = Re - x.Re;
    //        return Z;
    //    }

    //    public Complex_struck Multi(Complex_struck x) // z1 * z2 = (Re + Im)(x.Re + x.Im) = 1 * 2 + 1 * 2Im + 1Im * 1 + 1I * 2i(2) = 2 + 2Im + 1Im + 1Im + 2i(2) = 2 + (-2) + 4i = 0 + 4i           
    //    {
    //        Complex_struck Z;
    //        Z.Im = Re * x.Im + Im * x.Re;
    //        Z.Re = Re * x.Re - Im * x.Im;
    //        return Z;
    //    }

    //    public string ToString()
    //    {
    //        if (Im > 0)
    //        {
    //          return Re + ("+") + Im + ("i");
    //        }
    //        else
    //        {
    //          return Re + ("") + Im + ("i");
    //        }

    //    }
    //}

    ////  б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса. 
    ////  в) Добавить диалог с использованием switch демонстрирующий работу класса. Жмачинский
    //class Complex_class
    //{
    //    double Re;
    //    double Im;



    //    public Complex_class(double Re, double Im)
    //    {
    //        this.Re = Re;
    //        this.Im = Im;
    //    }

    //    public Complex_class Plus(Complex_class x2)
    //    {
    //        Complex_class x3 = new Complex_class(0,0);
    //        x3.Im = x2.Im + Im;
    //        x3.Re = x3.Re + Re;
    //        return x3;
    //    }

    //    public Complex_class Minus(Complex_class x2)
    //    {
    //        Complex_class x3 = new Complex_class(0,0);
    //        x3.Im = Im - x2.Im;
    //        x3.Re = Re - x2.Re;
    //        return x3;
    //    }

    //    public Complex_class Multi(Complex_class x2)
    //    {
    //        Complex_class x3 = new Complex_class(0,0);
    //        x3.Im = Re * x2.Im + Im * x2.Re;
    //        x3.Re = Re * x2.Re - Im * x2.Im;
    //        return x3;

    //    }

    //    public string ToString()
    //    {
    //        if (Im > 0)
    //        {
    //            return Re + ("+") + Im + ("i");
    //        }
    //        else
    //        {
    //            return Re + ("") + Im + ("i");
    //        }
    //    }




    //}


    ////3.*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, 
    ////  вычитания, умножения и деления дробей.Написать
    ////  программу, демонстрирующую все разработанные элементы класса.
    ////* Добавить свойства типа int для доступа к числителю и знаменателю;
    ////* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    ////**Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    ////*** Добавить упрощение дробей. Жмачинский


    //class Fractions
    //{
    //    int numerator;
    //    int denominator;
    //    double div;

    //    public int Denominator
    //    {
    //        get 
    //        { 
    //            return denominator; 
    //        }

    //        set
    //        {
                
    //            ArgumentException error = new ArgumentException("Знаменатель не может быть равен 0");
    //            if(value == 0)
    //            {
    //                Console.WriteLine(error.Message);
    //                Console.ReadKey();
    //            }
    //            else
    //            {
    //                Denominator = value;
    //            }
              
    //        }
    //    }
        
        

    //    public Fractions()
    //    {
    //        numerator = 0;
    //        denominator = 0;
    //    }

        

        
    //    public Fractions(int a, int b)
    //    {
    //        this.numerator = a;
    //        this.denominator = b;
    //        div = Convert.ToDouble(numerator) / Convert.ToDouble(denominator);
    //    }

    //    public double Div
    //    {
    //        get
    //        {
    //            return div;
    //        }
    //    }

    //    public string ToString()

    //    {
            
    //        return Convert.ToString($"{numerator}/{denominator}");
    //    }

    //    public Fractions Plus(Fractions x)
    //    {
    //        Fractions S = new Fractions();
    //        if (denominator == x.denominator)
    //        {
    //           S.numerator = numerator + x.numerator;
    //           S.denominator = x.denominator;
    //           return S;
    //        }
    //        else
    //        {
    //            S.numerator = numerator * x.denominator + x.numerator * denominator;
    //            S.denominator = denominator * x.denominator;
    //            return S;
    //        }

    //    }
    //    public Fractions Minus(Fractions x)
    //    {
    //        Fractions S = new Fractions();
    //        var NOK = 2;
    //        if (denominator == x.denominator)
    //        {
    //            S.numerator = numerator - x.numerator;
    //            S.denominator = x.denominator;
    //            return S;
    //        }
    //        else
    //        {
    //            for (int i = 2; !(i % denominator == 0 && i % x.denominator == 0); i++)
    //            {
    //                NOK ++;
    //            }

    //            S.numerator = NOK / denominator * numerator - NOK / x.denominator * x.numerator;
    //            S.denominator = NOK;
    //            return S;
    //        }

    //    }
         
    //    public Fractions Multi(Fractions x)
    //    {
    //        Fractions S = new Fractions();
    //        S.numerator = numerator * x.numerator;
    //        S.denominator = denominator * x.denominator;
    //        return S;
    //    }

    //    public Fractions Division(Fractions x)
    //    {
    //        Fractions S = new Fractions();
    //        S.numerator = numerator * x.denominator;
    //        S.denominator = denominator * x.numerator;
    //        return S;
    //    }

    //    public Fractions SimpleFraction()
    //    {
    //        Fractions S = new Fractions();
    //        var NOK = 2;
    //        for (int i = 2; !(denominator % i == 0 && numerator % i == 0); i++)
    //        {
    //            NOK++;
    //        }
    //        S.numerator = numerator / NOK ;
    //        S.denominator = denominator / NOK;
            
    //        return S;
    //    }

    //}



    class Program
    {
        static void Main(string[] args)
        {
            //// 1 а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
            ////      Продемонстрировать работу структуры. Жмачинский
            //Complex_struck complex_x;
            //complex_x.Im = 1;
            //complex_x.Re = 1;

            //Complex_struck complex_y;
            //complex_y.Im = 2;
            //complex_y.Re = 2;

            //Console.WriteLine("Результат работы структуры Complex_struck");
            //var result = complex_x.Plus(complex_y); 
            //Console.WriteLine($"Результат сложения: {result.ToString()}");
            //result = complex_x.Minus(complex_y);
            //Console.WriteLine($"Результат вычитания: {result.ToString()}");
            //result = complex_x.Multi(complex_y);
            //Console.WriteLine($"Произведение: {result.ToString()}");
            //Console.ReadKey(); 


            ////  б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса. 
            ////  в) Добавить диалог с использованием switch демонстрирующий работу класса. Жмачинский
            //string yesNo;
            //Complex_class complex_class_x1 = new Complex_class(1,1);
            //Complex_class complex_class_x2 = new Complex_class(2,2);
            //Complex_class result = new Complex_class(0,0);
            //do
            //{
            //    Console.Write("Для демонстрации работы класса \"Комплексные числа\" введите интересующую Вас операцию\n(Сумма ; Вычитание ; Произведение) : ");
            //    string userChoice = Console.ReadLine();
            //    userChoice = userChoice.ToLower();

            //    switch (userChoice)
            //    {
            //        case "сумма":
            //            result = complex_class_x1.Plus(complex_class_x2);
            //            Console.WriteLine(result.ToString());
            //            break;
            //        case "вычитание":
            //            result = complex_class_x1.Minus(complex_class_x2);
            //            Console.WriteLine(result.ToString());
            //            break;
            //        case "произведение":
            //            result = complex_class_x1.Multi(complex_class_x2);
            //            Console.WriteLine(result.ToString());
            //            break;

            //        default:
            //            if (userChoice == null)
            //            Console.WriteLine("Вы ничего не ввели");
            //            break;
            //    }
            //    Console.WriteLine("Повторить? (Да/Нет)");
            //    yesNo = Console.ReadLine();
            //    yesNo = yesNo.ToLower();

            //} while (yesNo == "да" || yesNo == "lf" ? true : false);
            //Console.WriteLine("До свидания!");
            //Console.ReadKey();

            ////2.а) С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).
            ////     Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму
            ////     вывести на экран, используя tryParse. Жмачинский

            //int userNumb, sum;
            //string checkValue, oddNumb;
            //checkValue = oddNumb = "";
            //sum = 0;
            //Console.Write("Введите число: ");
            //do
            //{
            //    bool f = int.TryParse(Console.ReadLine(), out userNumb);
            //    if(f == false)
            //    {
            //        Console.WriteLine("Вы ввели не число, попробуйте еще раз.");
            //        continue;
            //    }
            //    else if(userNumb % 2 != 0 && userNumb >0)
            //    {
            //        oddNumb += Convert.ToString(userNumb + "; ");
            //        sum += userNumb;
            //    }

            //    checkValue += Convert.ToString(userNumb + " ");
            //} while (!(checkValue.Contains("0")));

            //Console.WriteLine($"Нечетные положительные числа:\n{oddNumb}\nСумма нечетных положительных чисел: {sum}");
            //Console.ReadKey();

            //// 3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, 
            ////  вычитания, умножения и деления дробей.Написать
            ////  программу, демонстрирующую все разработанные элементы класса.
            ////* Добавить свойства типа int для доступа к числителю и знаменателю;
            ////* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
            ////**Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
            ////*** Добавить упрощение дробей. Жмачинский

            //Fractions drob = new Fractions(2, 6);
            //Fractions drob2 = new Fractions(3, 6);
            //Fractions drob3 = new Fractions(8, 10);
            //Console.WriteLine("Работа класса \"Дроби\"\n");
            //var result = drob.Plus(drob2);
            //Console.WriteLine($"Сумма дробей с одинаковыми знаменателями:\n {drob.ToString()} + {drob2.ToString()} = {result.ToString()}\n");
            //result = drob.Plus(drob3);
            //Console.WriteLine($"Сумма дробей с разными знаменателями:\n {drob.ToString()} + {drob3.ToString()} = {result.ToString()}\n");
            //result = drob.Minus(drob2);
            //Console.WriteLine($"Вычитание дробей с одинаковыми знаменателями:\n {drob.ToString()} - {drob2.ToString()} = {result.ToString()}\n");
            //result = drob3.Minus(drob);
            //Console.WriteLine($"Вычитание дробей с разными знаменателями:\n {drob3.ToString()} - {drob.ToString()} = {result.ToString()}\n");
            //result = drob.Multi(drob3);
            //Console.WriteLine($"Произведение дробей:\n {drob.ToString()} * {drob3.ToString()} = {result.ToString()}\n");
            //result = drob.Division(drob3);
            //Console.WriteLine($"Разность дробей:\n {drob.ToString()} / {drob3.ToString()} = {result.ToString()}\n");
            //result = result.SimpleFraction();
            //Console.WriteLine($"Разность дробей с её упрощенной записью:\n {result.ToString()}\n");
            
            //Console.WriteLine($"Результат деления самой дроби :{drob3.Div}");


            //Console.WriteLine($"\nОбработка исключения: \"drob.Denominator = 0\" ");
            //drob.Denominator = 0;
           
            //Console.ReadKey();

            

        }
    }
}
