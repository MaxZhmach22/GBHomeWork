using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork04
{
    public class ArrayClass
    {
        //3а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий
        //массив определенного размера и заполняющий массив числами от начального значения с
        //заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод
        //Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый
        //массив, остается без изменений), метод Multi, умножающий каждый элемент массива на
        //определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
        //б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу
        //библиотеки
        //е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
        //Жмачинский

        public int[] array;
        public int[] inverseArray;

        public ArrayClass (int size, int minValue, int iteration)
        {
            array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = minValue;
                minValue += iteration;
            }
        } //Конструктор с параметрами

        public int Sum 
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }
        } //Свойство, показывающее сумму эллементов массива

        public int[] Inverse()
        {
            inverseArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 0)
                {
                    inverseArray[i] = Math.Abs(array[i]);
                }
                else 
                {
                    inverseArray[i] = -array[i];
                }

            }
            return inverseArray;
        } //Метод, который делает инверсию элементов массива и возвращает их в новый массив.

        public void Multi(int multi) //Метод умножающий на определенное число все эллементы массива.
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * multi;
            }
        }

        public string String() //Метод возвращающий строку
        {
            string str = "";
            for (int i = 0; i < array.Length; i++)
            {
                str += Convert.ToString(array[i]) + " ";
            }
            return str;

        }

        public int MaxCount
        {
            get
            {
                int max = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                        max = array[i];
                }
                return max;
            }
        } //Свойство возвращающее масимальное значение в массиве.
    }
}
