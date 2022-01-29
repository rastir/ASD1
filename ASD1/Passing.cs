using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Динамические массивы
    /// </summary>
    public class DynArray<T>
    {
        /// <summary>
        /// Поле-указатель на блок памяти нужной ёмкости
        /// </summary>
        public T[] array; //array хранит массив фиксированной длины с объектами некоторого базового типа, к которому приводятся все остальные типы
        /// <summary>
        /// Поле - текущее количество элементов в массиве
        /// </summary>
        public int count;
        /// <summary>
        /// Поле - текущая ёмкость буфера (исходно 16 единиц)
        /// </summary>
        public int capacity;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public DynArray()
        {
            count = 0;
            array = new T[count];
            MakeArray(16);
        }
        /// <summary>
        /// Метод формирования блока памяти заданного размера
        /// </summary>
        /// <param name="new_capacity"></param>
        public void MakeArray(int new_capacity)
        {
            if (new_capacity < count)
                throw new ArgumentOutOfRangeException("Выход за пределы массива или пустой");

            Array.Resize(ref array, new_capacity);
            capacity = new_capacity;
        }
        /// <summary>
        /// Метод получения объекта по его индексу: 
        /// В этот метод встроим проверку корректности индекса в рамках границ, 
        /// и генерацию соответствующего исключения, если обращение некорректно;
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetItem(int index)
        {
            if ((index <= 0 || index > count) || count == 0) //проверка корректности индекса в рамках границ
                throw new ArgumentOutOfRangeException("Выход за пределы массива или пустой");//генерациz соответствующего исключения, если обращение некорректно
            return array[index - 1];
        }
        /// <summary>
        /// Метод добавления нового элемента в конец массива,
        /// </summary>
        /// <param name="itm"></param>
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
        /// <summary>
        /// Метод, который вставляет в i-ю позицию объект item, 
        /// сдвигая вперёд все последующие элементы. 
        /// Учтите, что новая длина массива может превысить размер буфера.
        /// Важно, единственное исключение: для метода Insert() 
        /// параметр i может принимать значение, равное длине рабочего массива count, 
        /// в таком случае добавление происходит в его хвост.
        /// Если индекс i лежит вне допустимых границ, генерируйте исключение.
        /// </summary>
        /// <param name="itm"></param>
        /// <param name="index"></param>
        public void Insert(T itm, int index)
        {
            if (array.Length != capacity)
                Array.Resize(ref array, capacity);

            if (count == capacity)
                Resize(2 * capacity);

            if (index <= 0 || (index > count && !(count == 0 && index == 1)))
                throw new ArgumentOutOfRangeException("Выход за пределы массива или пустой");

            if (index == count || (count == 0 && index == 1))
            {
                Append(itm);
                return;
            }
            GetItem(index); //проверяем в нужном ли диапазоне номер позиции index
            // сдвигаем все элементы вправо до нужного индекса
            for (int i = count - 1; i >= index - 1; i--)
                array[i + 1] = array[i];
            array[index - 1] = itm;
            count++;
        }
        /// <summary>
        /// Метод, который удаляет объект из i-й позиции, 
        /// при необходимости выполняя сжатие буфера.
        /// Если индекс i лежит вне допустимых границ, генерируйте исключение.
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            if ((index < 0 || index > count) || count == 0)
                throw new ArgumentOutOfRangeException("Выход за пределы массива или пустой");
            
            //сдвигаем
            for (int i = index; i < count; i++)
                array[i - 1] = array[i];
            count--;

            if (count != 0)
            {
                if ((int)capacity / count < (int)capacity / 2)
                    _ = capacity / 1.5 < 16 ? capacity = 16 : (capacity = (int)(capacity / (decimal)1.5));
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

