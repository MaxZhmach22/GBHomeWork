using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace HomeWorkAnketa
{


    //2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения,  которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в него передается 
    //   массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов 
    //   массива входит в этот текст.Здесь требуется использовать класс Dictionary. Жмачинский

    public static class Message
    {

        public static string WordsLength(string str, int n) // а) Метод показывает все слова длинна которых равна n;
        {
            string result = ""; 
            foreach(char ch in str) // Делаем проверку на знак пунктуации, если true то заменяем.
            {
                if(Char.IsPunctuation(ch))
                {
                    str = str.Replace(ch, (char) 32);
                }
            }
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].Length == n)
                {
                    result += words[i] + " ";
                }
            }
            return result;
        }

        public static string WordsTrimBySymbol(string str, char n) // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(n))
                {
                    str = str.Replace(words[i], "");
                }
            }
            return str;
        }

        public static string TheBiggestWord(string str) //в) Найти самое длинное слово сообщения.
        {
            string result = string.Empty;
            foreach (char ch in str) // Делаем проверку на знак пунктуации, если true то заменяем.
            {
                if (Char.IsPunctuation(ch))
                {
                    str = str.Replace(ch, (char)32);
                }
            }
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length -1; i++) //Сортируем пузырьком.
            {
                if (words[i].Length > words[i + 1].Length)
                {
                    string a = words[i];
                    words[i] = words[i + 1];
                    words[i + 1] = a;
                    result = a;
                }
            }
            return result;
        }

        public static string ConcatLargestWords(string str)
        {
            StringBuilder sb = new StringBuilder();
            int maxLength = 0;
            
            foreach (char ch in str) // Делаем проверку на знак пунктуации, если true то заменяем.
            {
                if (Char.IsPunctuation(ch))
                {
                    str = str.Replace(ch, (char)32);
                }
            }
            string[] words = str.Split(' ');
            string strLength = str.Replace(" ", "");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length>maxLength)
                {
                    maxLength = words[i].Length; //Нашли самое длинное слово в массиве строк.
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > (strLength.Length/words.Length)) // Нашли среднее количество символов в слове в исходной строке.
                {
                    sb.Append(words[i] + " ");
                }
            }
            return sb.ToString();





        } //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

        public static string TxtReader(string path) // Метод чтения текста из файла.
        {
            string txt = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    do
                    {
                        txt += sr.ReadLine();
                    } while (!(sr.ReadLine() == null));
                    sr.Close();
                }

            }
            catch (Exception exc) 
            {

                Console.WriteLine(exc.Message);

            }
            return txt;
        }


        public static Dictionary<string,int> Analyzer(string[] words, string txt)
        {
            int count = 1;
            string result = "";
            foreach (char ch in txt) // Делаем проверку на знак пунктуации, если true то заменяем.
            {
                if (Char.IsPunctuation(ch))
                {
                    txt = txt.Replace(ch, (char)32);
                }
            }
            txt = txt.ToLower();
            string[] txtArray = txt.Split(' ');
            for (int i = 0; i < words.Length; i++) // Сделаем перебор двух массивов, и если есть совпадения, то записиваем их в новую строку. 
            {
                for (int j = 0; j < txtArray.Length; j++)
                {
                    if(words[i].ToLower() == txtArray[j])
                    {
                        result += words[i] + " ";
                    }
                }
            }
            string[] resultArray = result.Split(' '); // Создаем массив из полученных совпадений, а так как он уже отсортирован мы делаем небольшую проверку на следующий элемент массива и если надо обнуляем счетчик.  
            Dictionary<string, int> list = new Dictionary<string, int>(resultArray.Length);
            for (int i = 0; i < resultArray.Length - 1; i++)
            {
                if (resultArray[i] == resultArray[i + 1])
                {
                    count++;
                }
                else
                {
                    list.Add(resultArray[i], count);
                    count = 1;
                }
            }
            return list;
        } //Метод, который производит частотный анализ текста. (BRUTE FORCE через создание массива) 

        public static Dictionary<string, int> AnalyzerRegex(string[] words, string txt) //Метод анализа совпадений через Regex.
        {
            Dictionary<string, int> list = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                Regex analyzer = new Regex(words[i]);
                MatchCollection match = analyzer.Matches(txt);
                list.Add(words[i], match.Count);

            }

            return list;
        }


        public static bool Anagrams(string a, string b) // 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
                                                        //  Например:  badc являются перестановкой abcd.
                           
        {
            int sumA, sumB; // Мы знаем что от перемены мест слагаемых сумма не меняется, поэтому в каком бы порядке символы не стояли сумма их порядковых номеров в таблице ASCII будет одинакова.
            sumA = sumB = 0;
            a = a.Replace(" ", "");
            b = b.Replace(" ", "");
            a = a.ToLower();
            b = b.ToLower();
            char[] chA = a.ToCharArray();
            char[] chB = b.ToCharArray();
            for (int i = 0; i < chA.Length; i++)
            {
                sumA += (int) chA[i];
                sumB += (int) chB[i];
            }
            if(sumA == sumB)
            {
                return true;
            }
            return false;
        }
    }
}
