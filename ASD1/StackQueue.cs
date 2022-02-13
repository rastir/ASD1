//using System;
//using System.Collections.Generic;
//using System.Collections;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Очередь: задание №4 "реализовать очередь с помощью двух стеков"
    /// </summary>
    public class Stack<T> //обобщенный класс
    {
        public int count; // количество элементов очереди
        private int count1; // количество элементов стэка1
        private int count2; // количество элементов стэка2
        public List<object> _items1;
        public List<object> _items2;

        //для инициализации делаем два конструктора
        public Stack() //конструктор без параметров 
        {
            count = 0;
            count1 = 0;
            count2 = 0;
            _items1 = new List<object>(); //для сложности O(1) используем коллекцию/ Сложность: O(1)
            _items2 = new List<object>(); //для сложности O(1) используем коллекцию/ Сложность: O(1)
            // инициализация внутреннего хранилища стека
            //items1 = new T[count1];
            //items2 = new T[count2]; 
        }
        //public int Size() // размер текущего стека
        //{
        //    return items.Length;
        //}

        public bool IsEmpty () // пуст ли стек
        {
            return (count1 == 0 && count2 ==0);
        }

        public int Count()  // размер очереди
        {
            if (count1 != 0)
                return count1;
            else if (count2 != 0)
                return count2;
            else 
                return 0;
        }
        public int Count1  // размер стека1
        {
            get { return count1; }
        }

        public int Count2  // размер стека2
        {
            get { return count2; }
        }

        public T Pop()
        {
            T item;

            if (_items1.Count == 0)  
            {
                if (count1 != 0)
                {
                    for (int i = 0; i < _items1.Count; i++)
                    {
                        Push2(_items1[--count1]); // если стек пуст перекладываем/переворачиваем
                        items1[count1] = default(T);// сбрасываем ссылку
                    }
                }
                else 
                    return default(T);
            }

            else if (count2 == 1)
            {
                //item = (T)_items1[0];
                //_stack.Clear();
                //count = default;
                //return item;
                item = items2[--count2];
                Array.Resize(ref items2, 0);

                return item;
            }
            item = items2[count2 - 1];
            items2[--count2] = default(T);// сбрасываем ссылку
            Array.Resize(ref items2, count2);
            return item;
        }

        public void Push(T val)
        {
            if (count1 == items1.Length) // переполнен, увеличиваем
            {
                Array.Resize(ref items1, items1.Length + 1);
            }

            items1[count1] = val;
            count1++;
        }

        public void Push2(T val)
        {
            if (count2 == items2.Length) // переполнен, увеличиваем
            {
                Array.Resize(ref items2, items2.Length + 1);
            }
            items2[count2] = val;
            count2++;
        }

        public T Peek()
        {
            if (count1 != 0)
                return items1[0];
            else if (count2 != 0)
                return items2[count2 - 1];
            else
                return default(T);
        }
    }
    class CMain
    {
        public static void Main() { }
    }
}