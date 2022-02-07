using System;
using System.Collections.Generic;
using System.Collections;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Очереди
    /// </summary>
    public class Queue<T>
    {
        public T[] items; //элементы любого типа T
        public int count; // количество элементов
        public Queue()
        {
            // инициализация внутреннего хранилища очереди
            count = 0;
            items = new T[count]; 
        }

        public bool IsEmpty // пуста ли очередь
        {
            get { return count == 0; }
        }

        public void Enqueue(T item) // вставка в хвост очереди
        {
            // если стек заполнен, увеличиваем
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length + 1);
            }
            //сдвигаем вправо
            if (count != 0)
            {
                for (int i = items.Length - 1; i > 0; i--)
                    items[i] = items[i - 1];
            }
            
            items[0] = item;
            count++;
        }

        public T Dequeue() //вернуть из головы очереди
        {
            T item;

            if (Size() == 0)
                return default(T);

            if (items.Length == 1)
            {
                item = items[--count];
                Array.Resize(ref items, 0);

                return item;
            }

            item = items[--count];
            Array.Resize(ref items, count);
            return item;
        }

        public int Size()
        {
            return items.Length;
        }
    }
}