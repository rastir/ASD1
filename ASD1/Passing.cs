using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Двусторонняя очередь (deque)
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
    }
}