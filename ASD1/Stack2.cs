using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Стэк
    /// </summary>
    /// Задание №2
    /// Переделайте реализацию стека так, чтобы она работала не с хвостом списка как с верхушкой стека, а с его головой -- на основе подходящей структуры данных, 
    /// которая бы сохраняла сложность O(1).
    
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

            T ret = items[0];

            //сдвигаем
            for (int i = 0; i < count - 1; i++)
                items[i] = items[i + 1];
            
            items[count - 1] = default(T); // сбрасываем ссылку
            count--;
            return ret;
        }

        public void Push(T val)
        {
            if (count == items.Length)
            {
                if (IsEmpty)
                    Array.Resize(ref items, items.Length + 4);
                else
                    Array.Resize(ref items, items.Length * 2);
            }
            //сдвигаем
            for (int i = count - 1; i >= 0; i--)
                items[i + 1] = items[i];

            items[0] = val;
            count++;
        }

        public T Peek()
        {
            // ваш код
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                return default(T); 
            return items[0];
        }
    }
}
