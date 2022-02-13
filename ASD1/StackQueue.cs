using System;
using System.Collections.Generic;
using System.Collections;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Очередь: задание №4 "реализовать очередь с помощью двух стеков"
    /// Массивы, плохо подходят для стеков, используем список.
    /// </summary>
    public class Stack<T> //обобщенный класс
    {
        public List<T> _items1;
        public List<T> _items2;

        public Stack() //конструктор без параметров 
        {
             _items1 = new List<T>(); //для сложности O(1) используем список/ Сложность: O(1)
            _items2 = new List<T>(); //для сложности O(1) используем список/ Сложность: O(1)
        }
        public bool IsEmpty () // пуст ли стек
        {
            return _items1.Count == 0 && _items2.Count == 0;
        }

        public T Pop()
        {
            T item;

            if (_items2.Count == 0)  
            {
                if (_items1.Count != 0)
                {
                    for (int i = _items1.Count; i > 0; i--)
                    {
                        Push2(_items1.Last()); // если стек пуст перекладываем/переворачиваем
                        _items1.RemoveAt(_items1.Count - 1);
                    }
                }
                else 
                    return default(T);
            }

            else if (_items2.Count == 1)
            {
                item = _items2.Last();
                _items2.Clear();

                return item;
            }
            item = _items2.Last();
            _items2.RemoveAt(_items2.Count - 1);

            return item;
        }

        public void Push(T val)
        {
            _items1.Add(val);
        }

        public void Push2(T val)
        {
            _items2.Add(val);
        }

        public T Peek()
        {
            if (_items1.Count != 0)
                return _items1.First();
            else if (_items2.Count != 0)
                return _items2.Last();
            else
                return default(T);
        }

        public int Count()  // размер очереди
        {
            //return _items1.Count != 0 ? _items2.Count != 0 : 0;
            if (_items1.Count != 0)
                return _items1.Count;
            else if (_items2.Count != 0)
                return _items2.Count;
            else
                return 0;
        }
    }
    class CMain
    {
        public static void Main() { }
    }
}