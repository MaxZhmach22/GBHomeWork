using System;
using System.Collections.Generic;
using MyArrayLib;
using System.IO;



namespace HomeWork04
{
    // 4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
    //    Создайте структуру Account, содержащую Login и Password. 
    //    Жмачинский.

    struct Account
    {
        public string path;

        public Account(string path)
        {
            this.path = path;
        }

        
        public string[] Autiorization(string path)
        {
            string[] userArray = new string[2];
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    for (int i = 0; i < userArray.Length; i++)
                    {
                        userArray[i] = sr.ReadLine();
                    }
                    sr.Close();
                }

            }
            catch (Exception exc) //  в)**Добавьте обработку ситуации отсутствия файла на диске. 
            {

                Console.WriteLine(exc.Message);

            }
            return userArray;
        }

        public bool Compare(string[] a)
        {
            string login = "root";
            string password = "GeekBrains";
            if (a[0] == login && a[1] == password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        class Program
        {

            static void Main(string[] args)
            {
                //1.Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
                //значения от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать
                //программу, позволяющую найти и вывести количество пар элементов массива, в которых только
                //одно число делится на 3.В данной задаче под парой подразумевается два подряд идущих
                //элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
                //Жмачинский

                Console.WriteLine("//1.Задание \n");
                int[] array1 = new int[20];
                int couples = 0;
                Random rnd1 = new Random();
                Console.WriteLine("Элементы в массиве:");
                for (int i = 0; i < array1.Length; i++) //Заполняем массив случайными числами в диапазоне -10000 до 10001
                {
                    array1[i] = rnd1.Next(-10000, 10001);
                    Console.Write($"{array1[i]}; ");
                }

                Console.WriteLine("\n\nКоличество пар в массиве, в которых только одно из чисел делится на 3:");
                for (int i = 0; i < array1.Length - 1; i++)
                {
                    if (array1[i] % 3 == 0 && array1[i + 1] % 3 != 0) //Выполняем проверку пошагово для элемента i и i + 1, если один элемент делится на 3 а другой не делится то увеличиваем couples на 1.
                    {
                        Console.WriteLine($"Пара элементов: {array1[i]} и {array1[i + 1]}");
                        couples += 1;
                    }

                }
                Console.WriteLine($"\nВсего пар: {couples}\n");
                Console.WriteLine("________________________________________\n");




                // 2. Реализуйте задачу 1 в виде статического класса StaticClass;
                //  а) Класс должен содержать статический метод, который принимает на вход массив и решает
                //  задачу 1;
                //  б) *Добавьте статический метод для считывания массива из текстового файла.Метод должен
                //  возвращать массив целых чисел;
                //  в)**Добавьте обработку ситуации отсутствия файла на диске. 
                //  Жмачинский

                Console.WriteLine("//2.Задание. Реализовали задачу 1 с помощью статического класса \n");
                int[] array2 = new int[20];
                Random rnd2 = new Random();
                Console.WriteLine("Элементы в массиве:");
                for (int i = 0; i < array2.Length; i++) //Заполняем массив случайными числами в диапазоне -10000 до 10001
                {
                    array2[i] = rnd2.Next(-10000, 10001);
                    Console.Write($"{array2[i]}; ");
                }
                Console.WriteLine($"\n\nКоличество пар в массиве, в которых только одно из чисел делится на 3: {StaticClass.Couples(array2)}\n"); // Использовали метод из статического класса

                Console.WriteLine(" //б)* и в)**\n");
                int[] arrayFromtxt = StaticClass.ArrayReader(@"C:\Users\Max\Desktop\GeekBrains\C#\HomeWorkAnketa\HomeWork04\Array.txt");
                Console.WriteLine("Создали массив с числами из файла Array.txt\n");
                for (int i = 0; i < arrayFromtxt.Length; i++)
                {
                    Console.Write($"{arrayFromtxt[i]}; ");
                }
                Console.WriteLine("\n________________________________________\n");




                //3а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий
                //массив определенного размера и заполняющий массив числами от начального значения с
                //заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод
                //Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый
                //массив, остается без изменений), метод Multi, умножающий каждый элемент массива на
                //определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
                //б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу
                //библиотеки
                //е) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)


                Console.WriteLine("//3.Задание \n");
                ArrayClass init = new ArrayClass(10, -5, 1);
                Console.WriteLine("Массив:");
                for (int i = 0; i < init.array.Length; i++)
                {
                    Console.Write($"{init.array[i]} ");
                }
                Console.WriteLine("\n\nCумма элементов массива: " + init.Sum);

                int[] inverse = init.Inverse();
                Console.WriteLine("\nИнверсированный массив:");
                for (int i = 0; i < inverse.Length; i++)
                {
                    Console.Write($"{inverse[i]} ");
                }
                init.Multi(10);
                Console.WriteLine($"\n\nМетод Multi(10):\n{init.String()}");
                Console.WriteLine($"\nМаксимальноче число массива:\n{init.MaxCount}");




                //Демонстрация библиотеки
                Console.WriteLine("\n//3 б)**\n");

                Console.WriteLine("Создание массива с использованием библиотеки:");
                ArrayClassLib arraylib = new ArrayClassLib(-3, 10);
                Console.WriteLine(arraylib.String());
                Console.WriteLine("\nCумма элементов массива: " + arraylib.Sum);

                int[] inverseLib = arraylib.Inverse();
                Console.WriteLine("\nИнверсированный массив:");
                for (int i = 0; i < inverse.Length; i++)
                {
                    Console.Write($"{inverseLib[i]} ");
                }

                arraylib.Multi(10);
                Console.WriteLine($"\n\nМетод Multi(10):\n{arraylib.String()}");
                Console.WriteLine($"\nМаксимальное число массива:\n{arraylib.MaxCount}");




                //Подсчет количества вхождений элементов в массив.

                Console.WriteLine("\n//3 е)***\n");
                ArrayClassLib rndArray = new ArrayClassLib(10, -5, 10);
                Console.WriteLine("Подсчет повторяющихся элементов в массиве из случайных чисел с помощью Dictionary<int,int>:\n");
                Console.WriteLine("Массив из случаныйх чисел:");
                Console.WriteLine(rndArray.String());
                rndArray.SortArray(rndArray.array);

                
                Dictionary<int,int> repeats = rndArray.Elements(rndArray.array);
                foreach (KeyValuePair<int, int> keyValue in repeats)
                {
                    Console.WriteLine("Элемент: " + keyValue.Key + " число повторений: " + keyValue.Value);
                }

                Console.WriteLine("\n________________________________________\n");


                // 4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
                //    Создайте структуру Account, содержащую Login и Password. 
                //    Жмачинский.

                Console.WriteLine("\n//4. Задача\n");
                Account user = new Account(@"C:\Users\Max\Desktop\GeekBrains\C#\HomeWorkAnketa\HomeWork04\LoginPassword.txt");
                string[] txt = user.Autiorization(user.path);
                Console.WriteLine("Элементы массива txt взятые из файла:\n");
                for (int i = 0; i < txt.Length; i++)
                {
                    Console.WriteLine(txt[i]);
                }
                if(user.Compare(txt) == true)
                {
                    Console.WriteLine("\nВы ввели верный логин и пароль.");
                }
                else
                {
                    Console.WriteLine("\nЛогин или пароль неверный.");
                }
                

                Console.ReadKey();
            }
        }
    }
}
