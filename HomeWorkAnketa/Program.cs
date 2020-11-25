using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAnketa
{
    class Program
    {
        static double distance()
        {
            Console.Write("x1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return r;
        }

        static void Print(string msg, int x, int y)
        {
           
            Console.SetCursorPosition(x,y);
            Console.WriteLine(msg);
        }
        
        static void Print(string msg,  ConsoleColor colortext, ConsoleColor colorconsole)
        {
            Console.ForegroundColor = colortext;
            Console.BackgroundColor = colorconsole;
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {

            //Console.WriteLine("Вас приветсвует программа «Анкета» \n");
            //Console.WriteLine("Введите пожалуйста ваши данные \n(для дробных числел используйте запятую):\n");

            //Console.Write("Имя: ");
            //string name = Console.ReadLine();
            //Console.Write("Фамилия: ");
            //string surname = Console.ReadLine();
            //Console.Write("Возраст: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Рост: ");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Вес (кг): ");
            //double weigth = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Тел. номер: ");
            //long number;
            //if (long.TryParse(Console.ReadLine().TrimStart('+', '7', '8'), out number));


            ////1.а Вывод данных склеиванием
            //Console.WriteLine("\nВаши данные: \n\n" + "Имя:\t\t" + name + "\n" + "Фамилия:\t" + surname + "\n" + "Возраст:\t" + age + "\n" + "Рост (см):\t" + height + "\n" + "Вес (кг):\t" + weigth + "\n" + "Тел.номер:\t+7" + number);

            ////1.б Вывод данных форматированием
            //string output = String.Format("\nВаши данные: \n\nИмя:\t\t{0}\nФамилия:\t{1}\nВозраст:\t{2}\nРост (см:мм):\t{3:N}\nВес (кг:гр):\t{4:N3}\nТел. номер:\t{5:+7 (###) ###-##-##}", name, surname, age, height, weigth, number);
            //Console.WriteLine(output);

            ////1.в Вывод данных интерполяцией
            //output = String.Format($"\nВаши данные: \n\nИмя:\t\t{name}\nФамилия:\t{surname}\nВозраст:\t{age}\nРост (см:мм):\t{height:N}\nВес (кг:гр):\t{weigth:N3}\nТел. номер:\t{number:+7 (###) ###-##-##}");
            //Console.WriteLine(output);

            ////2. Подсчет индекса массы тела
            //double i = weigth / ((height / 100) * (height / 100));
            //int indexMass = Convert.ToInt32(i);
            //Console.WriteLine("\nИндекс массы тела: " + indexMass);



            ////3.а Подсчет расстояния между точками

            //Console.WriteLine("Программа подсчета расстояния между двумя точками. \n\nВведите координаты:\n");

            //double r = distance(); // Метод 
            //string result = String.Format($"{r:F2}");
            //Console.Write(result);
            //Console.ReadKey();


            ////4.а Программа по обмену значениями двух переменных с помощью третьей 
            ///
            //Console.WriteLine("Вас приветсвует программа по обмену значениями переменных a и b");
            //Console.Write("Введите значение для переменной а: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Теперь введите значение для переменной b: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int t;
            //t = a;
            //a = b;
            //b = t;
            //Console.WriteLine("a = " + a + "\n" + "b = " + b);
            //Console.ReadKey();

            ////4.б Программа по обмену значениями двух переменных без третьей переменной
            ///
            //Console.WriteLine("Вас приветсвует программа по обмену значениями переменных a и b с помощью метода");
            //Console.Write("Введите значение для переменной а: ");
            //int a1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Теперь введите значение для переменной b: ");
            //int b1 = Convert.ToInt32(Console.ReadLine());

            //a1 = a1 + b1;
            //b1 = a1 - b1;
            //a1 = a1 - b1;

            //Console.WriteLine("a = " + a1 + "\n" + "b = " + b1);
            //Console.ReadKey();

            ////5.a.б.в
            
            //String fio, city;
            //fio = "Максим Жмачиснкий";
            //city = "Санкт-Петербург";
            //Console.WriteLine(fio + " " + "\n" + city);
            //Print(fio, ConsoleColor.Red, ConsoleColor.Yellow);
            //Print(city, ConsoleColor.Green, ConsoleColor.Yellow);
            //Print($"{fio} {city}", 50, 15);
            //Console.ReadKey();









        }
    }
}
