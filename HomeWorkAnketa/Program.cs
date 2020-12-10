using System;
using HomeWorkAnketa;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;

namespace HomeWork05
{
    class Program
    {
        public static string LoginLength(string x) // a) Выполним первую проверку на длину логина.
        {
            do 
            {
                if (x.Length < 2)
                {
                    Console.WriteLine("Ваш логин меньше 2 символов, введите логин заного:");
                    x = Console.ReadLine();
                }
                else if (x.Length > 10)
                {
                    Console.WriteLine("Ваш логин больше 10 символов, введите логин заного:");
                    x = Console.ReadLine();
                }
            }
            while (x.Length < 2 || x.Length > 10);
            return x;
        }

        public static string LoginCheck(string x)  // a) Проверяем корректность логина.
        {
            string low = x.ToLower();
            char[] loginCh = low.ToCharArray();
            for (int i = 0; i < loginCh.Length; i++)
            {
                if (char.IsNumber(loginCh[0])) return "Первый символ это цифра, неправильный логин.";
                else if ((loginCh[i] >= 48 && loginCh[i] <= 57) || (loginCh[i] >= 97 && loginCh[i] <= 122)) // Проверка на диапазон символов в Unicode.
                {
                    continue;
                }
                else return "Не прошел проверку, так как еще содержит другие символы";
               
            }
            return "Проверку прошел.";
        } 

        public static bool LoginCheckRegex(string x) // б) **Проверяем корректность данных с помощью регулярных выражений
        
        {
            Regex checkReg = new Regex(@"[^\d][A-Za-z0-9]{1,9}");
            return checkReg.IsMatch(x);
        }

        public static void Print(string x) //Метод очистки консоли и написания номера задачи
        {
            Console.Clear();
            Console.WriteLine("_____________________________________________\n\n" + x + "\n\n");
        }

        static void Main()
        {
            //1.Создать программу, которая будет проверять корректность ввода логина.
            //    Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского
            //    алфавита или цифры, при этом цифра не может быть первой:
            //а) без использования регулярных выражений;
            //б) **с использованием регулярных выражений.
            //    Жмачинский
            
            Print("1. Создать программу, которая будет проверять корректность ввода логина.");
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();

            //Проверяем длину логина методом LoginLength
            string login1 = LoginLength(login);

            //Проверяем корректность данных и возвращаем строку либо с ошибкой либо с удачной проверкой.
            login1 = LoginCheck(login);
            Console.WriteLine("\n" + login1);

            //Проверяем корректность данных с помощью регулярных выражений
            bool checkLogin = LoginCheckRegex(login);
            Console.WriteLine(checkLogin);
            Console.ReadKey();

            //_________________________________________________________________________________________________//
                 
            // 2.  Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            //  а) Вывести только те слова сообщения,  которые содержат не более n букв.
            //  б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            //  в) Найти самое длинное слово сообщения.
            //  г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            //  д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается 
            //     массив слов и текст, в качестве результата метод возвращает 
            //     сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary. Жмачинский

            Print("2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста");
            string before = "Эта классическая книга представляет собой всеобъемлющий источник сведений о языке программирования C# и о связанной с ним инфраструктуре.";
            Console.WriteLine($"Демонстрация исходной строки: {before}\n");
            string after = Message.WordsLength(before, 3);
            Console.WriteLine($"Демонстрация метода WordsLength: {after}\n"); // а)
            after = Message.WordsTrimBySymbol(before, 'е');
            Console.WriteLine($"Демонстрация метода WordsTrimBySymbol: {after}\n"); // б)
            after = Message.TheBiggestWord(before);
            Console.WriteLine($"Демонстрация метода TheBiggestWord: {after}\n");  // в)
            after = Message.ConcatLargestWords(before);
            Console.WriteLine($"Демонстрация метода ConcatLargestWords: {after}\n");  // г)

            string txt = Message.TxtReader(@"C:\Users\Max\Desktop\GeekBrains\C#\HomeWorkAnketa\HomeWorkAnketa\TextAnalyzer.txt"); // Д)***
            string[] strArray = new string[] {
                "было", "очень", "Бильбо", "Фродо",
                "Сумникс", "Когда", "девять", "он", "вдруг",
                "как", "снег", "откуда", "сокровищах",
                "тридевять", "земель"
            };

            var list = Message.Analyzer(strArray, txt);//Метод (BRUTE FORCE), проверяющий совпадения через создание массива.
            Console.WriteLine("Метод Analyzer:\n");
            foreach (KeyValuePair<string, int> keyValue in list)
            {
                Console.WriteLine("Слово: \"" + keyValue.Key + "\" повторяется в тексте " + keyValue.Value + " раз.");
            }
            Console.WriteLine();

            var listRegex = Message.AnalyzerRegex(strArray, txt); //Метод анализа совпадений через Regex.
            Console.WriteLine("Метод AnalyzerRegex:\n");
            foreach (KeyValuePair<string, int> keyValue in listRegex)
            {
                Console.WriteLine("Слово: \"" + keyValue.Key + "\" повторяется в тексте " + keyValue.Value + " раз.");
            }
            Console.ReadKey();

            //_________________________________________________________________________________________________//

            // 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            //    Например: badc являются перестановкой abcd. Жмачинский
            Print("3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.");
            Console.WriteLine(Message.Anagrams("Gfgf44", "fGFg33"));  //не является
            Console.WriteLine(Message.Anagrams("KjHgFd", "DfGhJk"));  //  является
            Console.ReadKey();

            //_________________________________________________________________________________________________//
            
            //4. *Задача ЕГЭ. Требуется написать как можно более эффективную программу, которая будет выводить на экран
            //                фамилии и имена трёх худших по среднему баллу учеников.Если среди остальных есть ученики,
            //                набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена. Жмачинский
            Print("4. Задача ЕГЭ.");
            StreamReader sr = new StreamReader(@"C:\Users\Max\Desktop\GeekBrains\C#\HomeWorkAnketa\HomeWorkAnketa\TextFile1.txt");
            int n = int.Parse(sr.ReadLine()); //Узнаём длину массива из первой строчки .txt 
            string[] line = new string[n];
            int[] middle = new int[n];
            for (int i = 0; i < line.Length; i++) line[i] = sr.ReadLine(); // Заполняем массив учениками

            Regex reg = new Regex(@"([А-Яа-я]{1,20}\s[A-Яа-я]{1,15})\s(\d)\s(\d)\s(\d)"); // Сделали паттерн поиска оценок и фио
            Dictionary<string, int> students = new Dictionary<string, int>(); //Создали словарь для учеников и среднего балла.
            for (int i = 0; i < line.Length; i++)
            {
                Match match = reg.Match(line[i]);
                line[i] = match.Groups[1].ToString();
                middle[i] = (int.Parse(match.Groups[2].ToString()) + int.Parse(match.Groups[3].ToString()) + int.Parse(match.Groups[4].ToString())) / 3; // нашли средний бал по паттерну
                students.Add(line[i], middle[i]); //Добавили в словарь всех студентов вместе со средним баллом
            }
            Array.Sort(middle); // Нашли самый низкий средний бал путем сортировки.
            foreach(KeyValuePair<string,int> pair in students)
            {
                if(pair.Value == middle[0]) Console.WriteLine(pair.Key); // Выводим в консоль самый имена с самым низким средним баллом. 
            }
            Console.ReadKey();
        }
    }
}
