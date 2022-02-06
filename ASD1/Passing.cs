using System;
using System.Collections.Generic;
using System.Collections;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Стэк
    /// </summary>
    public class Stack<T> //обобщенный класс
    {
        public T[] items; //элементы любого типа T
        public int count; // количество элементов

        //для инициализации делаем два конструктора
        public Stack() //конструктор без параметров 
        {
            count = 0;
            // инициализация внутреннего хранилища стека
            items = new T[count]; //длина 10
        }

        public Stack(int length) //конструктор с параметрами
        {
            items = new T[length]; //длину можем сами установить
        }

        public bool IsEmpty // пуст ли стек
        {
            get { return count == 0; }
        }

        public int Count  // размер стека
        {
            get { return count; }
        }

        public int Size() // размер текущего стека
        {
            return items.Length;
        }

        public T Pop()
        {
            T item;
            // если стек пуст, выбрасываем null
            if (IsEmpty)
                return default(T);
            if (items.Count() == 1)
            {
                item = items[--count];
                Array.Resize(ref items, 0);

                return item;
            }
            item = items[--count];
            items[count] = default(T);// сбрасываем ссылку
            Array.Resize(ref items, count);
            return item;
        }

        public void Push(T val)
        {
            // если стек заполнен, увеличиваем
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length + 1);
            }
            items[count] = val;
            count++;
        }

        public T Peek()
        {
            // если стек пуст, выбрасываем null
            if (IsEmpty)
                return default(T); // null, если стек пустой
            return items[count - 1];
        }
        ///4. Напишите функцию, которая получает на вход строку, состоящую из открывающих и закрывающих скобок(например, "(()((())()))" или "(()()(()") 
        ///и, используя только стек и оператор цикла, определите, сбалансированы ли скобки в этой строке.
        ///Сбалансированной считается последовательность, в которой каждой открывающей обязательно соответствует закрывающая, 
        ///а каждой закрывающей -- открывающая скобки, то есть последовательности "())(" , "))((" или "((())" будут несбалансированы.

        public bool Brackets(string text)
        {
            char[] characters = text.ToCharArray();
            int counter = 0;

            Stack<string> stack3 = new(text.Length);

            for (int i = 0; i < text.Length; i++)
            {
                if (characters[i] == '(')
                    stack3.Push(characters[i].ToString());
                else
                    stack3.Pop();
            }
            if (stack3.Count != 0)
                return false;
            else
                return true;
        }
    }
    class CMain
    {
        public static void Main() { }
    }
}

