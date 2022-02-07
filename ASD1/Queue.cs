using System;
using System.Collections.Generic;
using System.Collections;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Очереди
    /// </summary>
    #region Теория
    //Очереди потому и называются очереди, что они работают как очереди: вход(добавление) происходит в хвост очереди, а выход(удаление) -- из её головы.
    //FIFO, first-in first-out -- первым пришёл, первым вышел
    //Очередь очевидно моделируется стандартным в большинстве языков типом данных "список" (или динамический массив), который вы возможно уже задействовали в занятии по стеку, если мы можем добавлять в него элементы в конкретную позицию, в частности, в нулевую -- принимаем её за условный хвост.А удаление из головы(принимаем её за последний элемент) происходит удалением этого последнего элемента.
    #endregion
    #region Задания.
    //    1. В классе Queue нам понадобятся три метода: size() (количество элементов в очереди), enqueue(item) -- добавить элемент в хвост очереди, и dequeue(), которая возвращает элемент из головы очереди, удаляя его.

    //qu = new Queue()
    //qu.enqueue(1)
    //qu.enqueue(2)
    //qu.enqueue(3)
    //while (qu.size() > 0)
    //    qu.dequeue()
    //2. Оцените меру сложности для операций enqueue() (добавление) и dequeue() (удаление) в данной реализации.

    //3. Напишите функцию, которая "вращает" очередь по кругу на N элементов.

    //4. Попробуйте реализовать очередь с помощью двух стеков.
    #endregion

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

    class CMain
    {
        public static void Main() { }
    }
}

