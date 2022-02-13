using System;
using System.Collections.Generic;
using System.Collections;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Двусторонняя очередь (deque)
    /// </summary>
    /// 
    //Это такое своеобразное расширение очереди и стека, у которого два входа(голова и хвост), и они же одновременно и выходы.То есть строгого правила, кто в каком порядке выходит, тут нету.
    //То есть нам требуются не два, а четыре основных метода:
    //добавление/удаление объекта (голова) addFront(item)/removeFront(),
    //и добавление/удаление объекта (хвост) addTail(item)/removeTail().
    //При этом сама внутренняя структура совмещает очередь и стек.
    //Если мы работаем только с одной стороной Deque (например, только головой),
    //то она функционирует как стек.
    //А если мы помещаем элементы с одной стороны, а берём с другой, то получается очередь.
    //При реализации класса Deque с помощью стандартного списка
    //(не связного, а обычного стандартного в Python, фактически массива)
    //мы получим немного парадоксальный результат в плане эффективности.
    //Проблема здесь в том, что мера сложности нашей реализации сильно зависит от того,
    //что в нашем внутреннем списке мы выберем головой, а что хвостом.
    //Например, addFront(item) может добавлять объект item в хвост списка/массива,
    //что обычно выполняется быстро,
    //а addTail(item) добавляет объект item в начало списка
    //(вставляет в 0-й элемент), что часто требует сдвига всех последующих элементов.
    //Это зависит от внутреннего представления стандартного списка
    //в конкретной реализации вашего языка программирования,
    //но так как он поддерживает возможность индексации(ведёт себя как массив),
    //внутри он наверняка реализован как динамический массив,
    //иначе невозможно обеспечить доступ к элементам по индексу за O(1).
    //А в динамическом массиве при вставке элемента приходится сдвигать все последующие элементы.

    //deq = new Deque()
    //deq.addFront("f1")
    //deq.addTail("t1")
    //deq.addFront("f2")
    //deq.addTail("t2")
    //while (deq.size() > 0)
    //    deq.removeFront()
    //    deq.removeTail()
    //Задания.
    //1. Реализуйте упомянутые выше класс Deque и соответствующие методы.
    //2. Как можно понизить (выровнять) сложность addHead/removeHead и addTail/removeTail,
    //с помощью какого ранее изученного типа данных?
    //3. Напишите функцию, которая с помощью Deque проверяет, является ли некоторая строка палиндромом (читается одинаково слева направо и справа налево).
    //4. Добавьте для каждого из четырёх вышеупомянутых методов тесты: проверяйте изменившуюся длину очереди и наличие или отстутствие в ней добавляемого/удаляемого элемента.
    #region
    //public class Stack<T> //обобщенный класс
    //{
    //    public int count; // количество элементов очереди
    //    private int count1; // количество элементов стэка1
    //    private int count2; // количество элементов стэка2
    //    public List<object> _items1;
    //    public List<object> _items2;

    //    //для инициализации делаем два конструктора
    //    public Stack() //конструктор без параметров 
    //    {
    //        count = 0;
    //        count1 = 0;
    //        count2 = 0;
    //        _items1 = new List<object>(); //для сложности O(1) используем коллекцию/ Сложность: O(1)
    //        _items2 = new List<object>(); //для сложности O(1) используем коллекцию/ Сложность: O(1)
    //        // инициализация внутреннего хранилища стека
    //        //items1 = new T[count1];
    //        //items2 = new T[count2]; 
    //    }
    //    //public int Size() // размер текущего стека
    //    //{
    //    //    return items.Length;
    //    //}

    //    public bool IsEmpty() // пуст ли стек
    //    {
    //        return (count1 == 0 && count2 == 0);
    //    }

    //    public int Count()  // размер очереди
    //    {
    //        if (count1 != 0)
    //            return count1;
    //        else if (count2 != 0)
    //            return count2;
    //        else
    //            return 0;
    //    }
    //    public int Count1  // размер стека1
    //    {
    //        get { return count1; }
    //    }

    //    public int Count2  // размер стека2
    //    {
    //        get { return count2; }
    //    }

    //    public T Pop()
    //    {
    //        T item;

    //        if (_items1.Count == 0)
    //        {
    //            if (count1 != 0)
    //            {
    //                for (int i = 0; i < _items1.Count; i++)
    //                {
    //                    Push2(_items1[--count1]); // если стек пуст перекладываем/переворачиваем
    //                    items1[count1] = default(T);// сбрасываем ссылку
    //                }
    //            }
    //            else
    //                return default(T);
    //        }

    //        else if (count2 == 1)
    //        {
    //            //item = (T)_items1[0];
    //            //_stack.Clear();
    //            //count = default;
    //            //return item;
    //            item = items2[--count2];
    //            Array.Resize(ref items2, 0);

    //            return item;
    //        }
    //        item = items2[count2 - 1];
    //        items2[--count2] = default(T);// сбрасываем ссылку
    //        Array.Resize(ref items2, count2);
    //        return item;
    //    }

    //    public void Push(T val)
    //    {
    //        if (count1 == items1.Length) // переполнен, увеличиваем
    //        {
    //            Array.Resize(ref items1, items1.Length + 1);
    //        }

    //        items1[count1] = val;
    //        count1++;
    //    }

    //    public void Push2(T val)
    //    {
    //        if (count2 == items2.Length) // переполнен, увеличиваем
    //        {
    //            Array.Resize(ref items2, items2.Length + 1);
    //        }
    //        items2[count2] = val;
    //        count2++;
    //    }

    //    public T Peek()
    //    {
    //        if (count1 != 0)
    //            return items1[0];
    //        else if (count2 != 0)
    //            return items2[count2 - 1];
    //        else
    //            return default(T);
    //    }
    //}
    #endregion
    //public class LinkedList<T>
    //{
    //    public LinkedList(T data)
    //    {
    //        Data = data;
    //    }
    //    public T Data { get; set; }
    //    public LinkedList<T> Previous { get; set; }
    //    public LinkedList<T> Next { get; set; }
    //}
    public class Deque<T>
    {
        T[] _items = new T[0];

        // Количество элементов в очереди.
        int _size = 0;

        // Индекс первого (самого старого) элемента.
        int _head = 0;

        // Индекс последнего (самого нового) элемента.
        int _tail = -1;
        public Deque()
        {
            //LinkedList<T> _head = new LinkedList<T>(); // головной/первый элемент
            //LinkedList<T> _tail = new LinkedList<T>(); ; // последний/хвостовой элемент
            //int count;  // количество элементов в списке
            ////Data = data;
            //Deque<T> _items = new Deque<T>();
        }

        private void allocateNewArray(int startingIndex)
        {
            int newLength = (_size == 0) ? 4 : _size * 2;

            T[] newArray = new T[newLength];

            if (_size > 0)
            {
                int targetIndex = startingIndex;

                // Копируем содержимое...
                // Если массив не закольцован, просто копируем элементы.
                // В противном случае, копирует от head до конца,
                // а затем от начала массива до tail.

                // Если tail меньше, чем head, переходим в начало.
                if (_tail < _head)
                {
                    // Копируем _items[head].._items[end] в newArray[0]..newArray[N].
                    for (int index = _head; index < _items.Length; index++)
                    {
                        newArray[targetIndex] = _items[index];
                        targetIndex++;
                    }

                    // Копируем _items[0].._items[tail] в newArray[N+1]..
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
        public T PeekFirst()
        {
            if (_size == 0)
            {
                return default(T); 
                //throw new InvalidOperationException("The deque is empty");
            }

            return _items[_head];
        }
        public T PeekLast()
        {
            if (_size == 0)
            {
                return default(T); 
                //throw new InvalidOperationException("The deque is empty");
            }

            return _items[_tail];
        }
        public int Size() // размер очереди
        {
            return _size;
            //return 0; 
        }
    }

    class CMain
    {
        public static void Main() { }
    }
}