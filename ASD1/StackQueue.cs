using System;
using System.Collections.Generic;
using System.Collections;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Очередь
    /// </summary>
    const Stack = require('./Stack');
    public class Stack<T> //обобщенный класс
    {
        public T[] items1; //элементы любого типа T
        public T[] items2; //элементы любого типа T
        public int count; // количество элементов

        //для инициализации делаем два конструктора
        public Stack() //конструктор без параметров 
        {
            count = 0;
            // инициализация внутреннего хранилища стека
            items1 = new T[count]; 
            items2 = new T[count]; 
        }
        public bool IsEmpty // пуст ли стек
        {
            get { return count == 0; }
        }

        public int Count  // размер стека
        {
            get { return count; }
        }

        public int Size_items1() 
        {
            return this.storage1.size() + this.storage2.size();
            return items1.Length;
        }

        public int Size_items2() 
        {
            return items2.Length;
        }

        public T Pop()
        {
            T item;
            // если стек пуст, выбрасываем null
            if (IsEmpty)
                return default(T);
            if (items.Count() == 1)
            {
                item = items[--count];
                Array.Resize(ref items, 0);

                return item;
                //items[count] = default(T);
            }
            item = items[--count];
            items[count] = default(T);// сбрасываем ссылку
            Array.Resize(ref items, count);
            return item;
        }

        public T Dequeue()
        {
            if (Size_items2() == 0)
            {
                for (int i = Size_items1(); i > 0; i--)
                    Push(Pop());
            }

            return Pop();
        }


        public void Push(T val)
        {
            this.storage1.push(item);
            // если стек заполнен, увеличиваем
            if (count == items1.Length)
            {
                Array.Resize(ref items1, items1.Length + 1);
            }
            items1[count] = val;
            count++;
        }

        public T Peek_items1()
        {
            if (IsEmpty)
                return default(T); 
            return items1[count - 1];
        }
        public T Peek_items2()
        {
            if (IsEmpty)
                return default(T);
            return items2[count - 1];
        }
    }
    class CMain
    {
        public static void Main() { }
    }
}

