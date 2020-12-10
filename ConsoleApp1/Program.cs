using System;

namespace ConsoleApp1
{
    struct Anketa // Структура анкета
    {
        public string FIO;
        public int age;
        public string hobbies;

        public Anketa(string FIO, int age, string hobbies) // В структуре отсутсвует конструктор по умолчанию, поэтому делаем свой, в который добавляем поля(переменные FIO,age,hobbies)
        {
            this.FIO = FIO;
            this.age = age;
            this.hobbies = hobbies;
        }

        public static void CorrectData(Anketa person) //Метод проверябщий корректность данных. В параметры метода мы передаем экземпляр структуры
        {
            if (string.IsNullOrEmpty(person.FIO) || string.IsNullOrEmpty(person.hobbies)) 
            {
                Console.WriteLine("Данные в анкете не корректны. FIO или hobbies пустые\n");
            }
            else if(person.age <= 0)
            {
                Console.WriteLine("Данные в анкете не корректны. Возраст не может быть отрицательным\n");
            }
            else
            {
                Console.WriteLine("Данные в анкете корректны\n");
            }
        }  
    }

    class Program
    {
        static void Main(string[] args)
        {
            Anketa human1 = new Anketa("Иванов Иван Иванович", -54, "Рыбалка, охота и.т.д"); // Создаем экземпляр структуры в который добавляем данные
            Anketa.CorrectData(human1); //Отправляем в метод на проверку, возвращаем 
         
            Anketa[] man = new Anketa[20]; //Создаем массив экземпляров структуры из 20 анкет, но все они будут идентичны так как внутри конструктора одинаковая информация.  

            for (int i = 0; i < man.Length; i++)
            {
                man[i] = new Anketa("Иванов Иван Иванович", -54, "Рыбалка, охота и.т.д");
                Console.WriteLine($"Человек{i + 1}: {man[i].FIO} {man[i].age} {man[i].hobbies}"); // Выводим на экран.
            }

            Console.ReadKey();
            
        }
    }
}
