using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork04
{
    static class StaticClass
    {
        // 2. Реализуйте задачу 1 в виде статического класса StaticClass;
        //  а) Класс должен содержать статический метод, который принимает на вход массив и решает
        //  задачу 1;
        //  б) *Добавьте статический метод для считывания массива из текстового файла.Метод должен
        //  возвращать массив целых чисел;
        //  в)**Добавьте обработку ситуации отсутствия файла на диске. 
        //  Жмачинский


        static public int Couples(int[] x)
        {
            int couples = 0;
            for (int i = 0; i < x.Length - 1; i++)
            {
                if (x[i] % 3 == 0 && x[i + 1] % 3 != 0) //Выполняем проверку пошагово для элемента i и i + 1, если один элемент делится на 3 а другой не делится то увеличиваем couples на 1.
                {
                    couples += 1;
                }
            }
            return couples;
        }

        static private int ReadlineCount(string path) // 2.б) Метод подсчета количства строк в файле для определения будущей длинны массива
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                string line;
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                }
                sr.Close();
                return count;

            }
            catch (Exception exc) //   в)**Добавьте обработку ситуации отсутствия файла на диске. 
            {
                
                Console.WriteLine(exc.Message);
            }
            return 0;
        }

        static public int[] ArrayReader(string path) // 2.б) Метод записи в массив значений из файла.
        {
            int[] array = new int[ReadlineCount(path)];
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        int n = int.Parse(sr.ReadLine());
                        array[i] = n;
                    }
                    sr.Close();
                }

            }
            catch (Exception exc) //  в)**Добавьте обработку ситуации отсутствия файла на диске. 
            {
                
                Console.WriteLine(exc.Message);
                
            }
            return array;
        }


    }
}
