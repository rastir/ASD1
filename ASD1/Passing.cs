using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

  class Deque<T>
  {
        public T[] items1; //элементы любого типа T
        public T[] items2; //элементы любого типа T
        public int count; // количество элементов очереди
        private int count1; // количество элементов стэка1
        private int count2; // количество элементов стэка2
    public Deque()
    {
     // инициализация внутреннего хранилища
    }

    public void AddFront(T item)
    {
     // добавление в голову
    }

    public void AddTail(T item)
    {
     // добавление в хвост
    }

    public T RemoveFront()
    {
     // удаление из головы
     return default(T);
    }

    public T RemoveTail()
    {
     // удаление из хвоста
     return default(T);
    }
        
    public int Size()
    {
     return 0; // размер очереди
    }
  }
}
