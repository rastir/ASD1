using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Двусторонняя очередь (deque)
    /// </summary>
    /// 
	T[] _items = new T[0];

	int _size = 0; // Количество элементов в очереди. 
	int _head = 0; // Индекс первого по поряфдку (самого старого) элемента.
	int _tail = -1; // Индекс последнего (нового) элемента.
	
    public class Deque<T>
    {
        public Deque()
        {
			// инициализация внутреннего хранилища
        }

        public void AddFront(T item) // добавление в голову
        {
            //LinkedList<T> node = new LinkedList<T>(data);
            //LinkedList<T> temp = head;
            //node.Next = temp;
            //head = node;
            //if (count == 0)
            //    tail = head;
            //else
            //    temp.Previous = node;
            //count++;
            // Проверим, необходимо ли увеличение массива:
            if (_items.Length == _size)
            {
                allocateNewArray(1);
            }

            // Так как массив не заполнен и _head больше 0,
            // мы знаем, что есть место в начале массива.
            if (_head > 0)
            {
                _head--;
            }
            else
            {
                // В противном случае мы должны закольцеваться.
                _head = _items.Length - 1;
            }

            _items[_head] = item;


            _size++;

            if (_size == 1)
            {
                // Если мы добавили первый элемент в пустую
                // очередь, он же будет и последним, поэтому
                // нужно обновить и _tail.
                _tail = _head;
            }
        }

        public void AddTail(T item) // добавление в хвост
        {
            // Проверим, необходимо ли увеличение массива:
            if (_items.Length == _size)
            {
                allocateNewArray(0);
            }

            // Теперь, когда у нас есть подходящий массив,
            // если _tail в конце массива, нам надо перейти в начало.
            if (_tail == _items.Length - 1)
            {
                _tail = 0;
            }
            else
            {
                _tail++;
            }

            _items[_tail] = item;
            _size++;

            if (_size == 1)
            {
                // Если мы добавили последний элемент в пустую
                // очередь, он же будет и первым, поэтому
                // нужно обновить и _head.
                _head = _tail;
            }
        }

        public T RemoveFront() // удаление из головы
        {
            if (_size == 0)
            {
                return default(T); 
                //throw new InvalidOperationException("The deque is empty");
            }

            T value = _items[_head];

            if (_head == _items.Length - 1)
            {
                // Если head установлен на последнем индексе,
                // переходим к началу массива.
                _head = 0;
            }
            else
            {
                // Переходим к следующему элементу.
                _head++;
            }

            _size--;

            return value;
            //return default(T);
        }

        public T RemoveTail() // удаление из хвоста
        {
            if (_size == 0)
            {
                return default(T); 
                //throw new InvalidOperationException("The deque is empty");
            }

            T value = _items[_tail];

            if (_tail == 0)
            {
                // Если tail установлен на начало массива, переходим к концу.
                _tail = _items.Length - 1;
            }
            else
            {
                // Переходим к предыдущему элементу.
                _tail--;
            }

            _size--;

            return value;
            //return default(T);
        }
		
		 private void allocateNewArray(int startingIndex)
        {
            int newLength = (_size == 0) ? 4 : _size * 2;

            T[] newArray = new T[newLength];

            if (_size > 0)
            {
                int targetIndex = startingIndex;

                // Если tail меньше, чем head, переходим сначала.
                if (_tail < _head)
                {
                    // Копируем 
                    for (int index = _head; index < _items.Length; index++)
                    {
                        newArray[targetIndex] = _items[index];
                        targetIndex++;
                    }

                    // Копируем 
                    for (int index = 0; index <= _tail; index++)
                    {
                        newArray[targetIndex] = _items[index];
                        targetIndex++;
                    }
                }
                else
                {
                    // Копируем _items[head].._items[tail] в newArray[0]..newArray[N]
                    for (int index = _head; index <= _tail; index++)
                    {
                        newArray[targetIndex] = _items[index];
                        targetIndex++;
                    }
                }

                _head = startingIndex;
                _tail = targetIndex - 1;
            }
            else
            {
                // Массив пуст.
                _head = 0;
                _tail = -1;
            }

            _items = newArray;
        }
		
        public T PeekFirst()
        {
            if (_size == 0)
            {
                return default(T); 
            }

            return _items[_head];
        }
		
        public T PeekLast()
        {
            if (_size == 0)
            {
                return default(T); 
            }

            return _items[_tail];
        }
        public int Size() // размер очереди
        {
            return _size;
            //return 0; 
        }
    }
}