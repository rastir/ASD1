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
            items = new T[count]; 
        }

        public Stack(int length) //конструктор с параметрами
        {
            items = new T[length];//длину можем сами установить
        }
        // пуст ли стек
        public bool IsEmpty
        {
            get { return count == 0; }
        }

        // размер стека
        public int Count
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
            if (val == null)
                return;
            // если стек заполнен, выбрасываем null
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
            // ваш код
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                return default(T); // null, если стек пустой
            return items[count - 1];
        }
    }
}

