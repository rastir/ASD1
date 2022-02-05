using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Стэк
    /// </summary>
    public class Stack<T> //обобщенный класс
    {
        public T[] items; //элементы любого типа T
        public int count; // количество элементов

        //для инициализации делаем два конструктора
        public Stack() //конструктор без параметров 
        {
            count = 0;
            // инициализация внутреннего хранилища стека
            items = new T[count]; //длина 10
        }

        public Stack(int length) //конструктор с параметрами
        {
            items = new T[length]; //длину можем сами установить
        }

        public bool IsEmpty // пуст ли стек
        {
            get { return count == 0; }
        }

        public int Count  // размер стека
        {
            get { return count; }
        }

        public int Size() // размер текущего стека
        {
            return items.Length;
        }

        public T Pop()
        {
            // если стек пуст, выбрасываем null
            if (IsEmpty)
                return default(T);
            T item = items[--count];
            items[count] = default(T); // сбрасываем ссылку
            return item;
        }

        public void Push(T val)
        {
            // если стек заполнен, увеличиваем
            if (count == items.Length)
            {
                if (IsEmpty)
                    Array.Resize(ref items, items.Length + 2);
                else
                    Array.Resize(ref items, items.Length * 2);
            }
            items[count] = val;
            count++;
        }

        public T Peek()
        {
            // если стек пуст, выбрасываем null
            if (IsEmpty)
                return default(T); // null, если стек пустой
            return items[count - 1];
        }
    }
}

