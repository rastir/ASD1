using System;
using System.Collections.Generic;
using System.Collections;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Двусторонняя очередь (deque) на основе Linkedlist
    /// </summary>
    /// 
    public class Deque<T>
    {
        LinkedList<T> _items;

        public int _size;

        public Deque()
        {
            _items = new LinkedList<T>();
            _size = 0;
        }

        public void AddFront(T item) // добавление в голову
        {
            _items.AddFirst(item);
            _size++;
        }

        public void AddTail(T item) // добавление в хвост
        {
            _items.AddLast(item);
            _size++;
        }

        public T RemoveFront() // удаление из головы
        {
            if (_size == 0)
            {
                return default(T); 
            }

            T value = _items.First.Value;
            _items.RemoveFirst();
            _size--;

            return value;
        }

        public T RemoveTail() // удаление из хвоста
        {
            if (_size == 0)
            {
                return default(T); 
            }

            T value = _items.Last.Value;
            _items.RemoveLast();
            _size--;

            return value;
        }
        public T PeekFirst()
        {
            if (_size == 0)
            {
                return default(T); 
            }

            return _items.First.Value;
        }
        public T PeekLast()
        {
            if (_size == 0)
            {
                return default(T); 
            }

            return _items.Last.Value;
        }
        public int Size() // размер очереди
        {
            return _size;
        }

        /// <summary>
        ///2. Как можно понизить (выровнять) сложность addHead/removeHead и addTail/removeTail, с помощью какого ранее изученного типа данных?
        /// </summary>
		/// Использовать очередь.
        /// 

        /// <summary>
        /// 3. Напишите функцию, которая с помощью Deque проверяет, является ли некоторая строка палиндромом (читается одинаково слева направо и справа налево).
        /// </summary>
        public bool IsPalindrome(string word)
        {
            if (word.Length <= 1)
                return true;

            Deque<char> chardeque = new Deque<char>();
            
            for (int i = 0; i < word.Length; i++)
            {
                chardeque.AddTail(word[i]);
            }

            bool stillEqual = true;
            for (int i = chardeque.Size(); i > 1; i--)
            {
                if (chardeque.Size() == 1) 
                    break;
                if (chardeque.RemoveFront() != chardeque.RemoveTail())
                {
                    stillEqual = false;
                    break;
                }
            }

            return stillEqual;
        }
    }
}