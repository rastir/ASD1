using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class DynArray<T>
    {

        public T[] array; //array хранит массив фиксированной длины с объектами некоторого базового типа, к которому приводятся все остальные типы

        public int count;

        public int capacity;

        public DynArray()
        {
            count = 0;
            array = new T[count];
            MakeArray(16);
        }

        public void MakeArray(int new_capacity) 
        {
            if (new_capacity < count)
                throw new ArgumentOutOfRangeException("Выход за пределы массива или пустой");

            Array.Resize(ref array, new_capacity);
            capacity = new_capacity;
        }

        public T GetItem(int index)
        {
            if ((index < 0 || index > count) || count == 0) //проверка корректности индекса в рамках границ
                throw new ArgumentOutOfRangeException("Выход за пределы массива или пустой");//генерациz соответствующего исключения, если обращение некорректно
            return array[index - 1];
        }

        public void Append(T itm)
        {
            ////длина массива превышает размер буфера
            ////Увеличение буфера выполняем, когда он весь полностью заполнен, и выполняется попытка добавления.
            if (count >= capacity)
            {
                while (count > capacity) //не верим тому кто формирует массив и передает заведомо некорректные сведения
                    MakeArray(2 * capacity); //увеличиваем размер буфера в два раза
            }

            if (count == capacity)
            {
                int newCapacity = capacity * 2;

                var newArray = new T[newCapacity];
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                capacity *= 2;
            }
            array[count] = itm;
            count++;
        }

        public void Insert(T itm, int index)
        {
            if (count == capacity)
                Resize(2 * capacity);

            if ((index < 0 || index >= count) || count == 0)
                throw new ArgumentOutOfRangeException("Выход за пределы массива или пустой");

            if (count == array.Length)
            {
                Append(itm);
                return;
            }
            GetItem(index); //проверяем в нужном ли диапазоне номер позиции index
            // сдвигаем все элементы вправо до нужного индекса
            for (int i = count - 1; i >= index; i--)
                array[i + 1] = array[i];
            array[index] = itm;
            count++;
        }

        public void Remove(int index)
        {
            if ((index < 0 || index > count) || count == 0)
                throw new ArgumentOutOfRangeException("Выход за пределы массива или пустой");

            for (int i = index + 1; i < count; i++)
                array[i - 1] = array[i];
            count--;

            if (count != 0)
            {
                if ((int)capacity / count < (int)capacity / 2)
                    capacity = capacity / 1.5 < 16 ? capacity = 16 : (capacity = (int)(capacity / (decimal)1.5));
            }
            array[count] = default(T);
        }

        public void Resize(int new_capacity)
        {
            Array.Resize(ref array, new_capacity);

            MakeArray(new_capacity); //задаем блок памяти

            capacity = new_capacity;
        }
    }
}

