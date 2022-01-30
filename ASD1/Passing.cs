using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class DynArray<T>
    {
        /// <summary>
        /// Поле-указатель на блок памяти нужной ёмкости
        /// </summary>
        public T[] array;
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
            if ((index < 0 || index > count) || count == 0) //проверка корректности индекса в рамках границ
                throw new ArgumentOutOfRangeException("Выход за пределы массива или пустой");//генерациz соответствующего исключения, если обращение некорректно
            return array[index];
        }
        /// <summary>
        /// Метод добавления нового элемента в конец массива,
        /// </summary>
        /// <param name="itm"></param>
        public void Append(T itm)
        {
            //длина массива превышает размер буфера: увеличение буфера выполняем, когда он весь полностью заполнен, и выполняется попытка добавления.
            if (count > capacity)
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
            if (index < 0 || index > count )//&& !(count == 0 && index == 0)) || (index == 0 && count != 0))
                throw new ArgumentOutOfRangeException("Выход за пределы массива или пустой");

            if (count == capacity)
                MakeArray(2 * capacity); //задаем блок памяти

            if (index == count)
                Append(itm);
                //array[index] = itm;
            else //if (index != 0)
            {
                GetItem(index); //проверяем в нужном ли диапазоне номер позиции index
                                // сдвигаем все элементы вправо до нужного индекса
                for (int i = count - 1; i >= index; i--)
                    array[i + 1] = array[i];
                array[index] = itm;
                count++;
            }
        }
        /// <summary>
        /// Метод, который удаляет объект из i-й позиции, 
        /// при необходимости выполняя сжатие буфера.
        /// Если индекс i лежит вне допустимых границ, генерируйте исключение.
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            if (index == 0 && count == 0)
                return;

            if (index < 0 || index > count - 1)// || count == 0)
                throw new ArgumentOutOfRangeException("Выход за пределы массива или пустой");



            if (index != count - 1)
            {
                //сдвигаем влево
                for (int i = index; i < count; i++)
                    array[i] = array[i + 1];
            }
            //удаляем
            else
                array[count - 1] = default(T);
            count--;

            //сокращаем буфер
            if (count != 0)
            {
                if ((int)count < (int)capacity / 2)//Сокращение буфера выполняем, когда его заполненность после операции удаления станет строго меньше, чем заданный процент (50%) заполнения.
                    capacity = capacity / 1.5 < 16 ? capacity = 16 : capacity = (int)(capacity / (decimal)1.5);
            }
        }
    }
}

