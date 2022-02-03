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
        public int count;
        public int n;//= 10;

        //для инициализации делаем два конструктора
        public Stack() //конструктор без параметров 
        {
            // инициализация внутреннего хранилища стека
            items = new T[n]; //длина 10
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

        public int Size()
        {
            return items.Length;
        }

        public T Pop()
        {
            // если стек пуст, выбрасываем null
            if (IsEmpty)
                return default(T);
                //throw new InvalidOperationException("Стек пуст");
            T item = items[--count];
            items[count] = default(T); // сбрасываем ссылку
            return item;
        }

        public void Push(T val)
        {
            // ваш код
            // если стек заполнен, выбрасываем null
            if (count == items.Length)
                throw new InvalidOperationException("Переполнение стека");
            items[count++] = val;
        }

        public T Peek()
        {
            // ваш код
            if (IsEmpty)
                return default(T); // null, если стек пустой
            return items[count - 1];
        }
    }
}

