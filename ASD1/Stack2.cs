using System;
using System.Collections;
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
        public List<object> _stack; 

        //для инициализации делаем два конструктора
        public Stack() //конструктор без параметров 
        {
            count = 0;
            _stack = new List<object>(); //для сложности O(1) используем коллекцию/ Сложность: O(1)
        }

        public bool IsEmpty         // пуст ли стек
        {
            get { return count == 0; }
        }

        public int Count         // размер стека
        {
            get { return count; }
        }

        public int Size() // размер текущего стека
        {
            return _stack.Count;
        }

        public T Pop()
        {
            if (IsEmpty)             // если стек пуст, выбрасываем null
                return default(T);

            else if (count == 1)             // если стек c одним значением, очищаем
            {
                T item = (T)_stack[0];
                _stack.Clear();
                count = default;
                return item;
            }
            else
            {
                T item = (T)_stack[0];
                _stack.RemoveAt(0);
                count--;
                return item;
            }
        }

        public void Push(T val)
        {
            _stack.Insert(0, val);
            count++;
        }

        public T Peek()
        {
            // если стек пуст, выбрасываем null
            if (IsEmpty)
                return default(T);
            T item = (T)_stack[0];
            return item;
        }
    }
    class CMain
    {
        public static void Main() { }
    }
}
