using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node<T>
    {
        public T value; //значение
        public Node<T> next, prev; //предыдущий/следюущий

        public Node(T _value) //конструктор нода
        {
            value = _value;
            next = null;
            prev = null;
        }
    }

    public class OrderedList<T>
    {
        public Node<T> head, tail;
        private bool _ascending;

        public OrderedList(bool asc) //конструктор с непустым аргументом
        {
            head = null;
            tail = null;
            _ascending = asc; //по возрастанию или по убыванию должны храниться элементы в массиве
        }

        public int Compare(T v1, T v2)
        {
            int result = 0;
            if (typeof(T) == typeof(String))
            {
                // версия для лексикографического сравнения строк
                String.Compare(v1.ToString(), v2.ToString());  
            }
            else
            {
                // универсальное сравнение
            }

            return result;
            // -1 если v1 < v2
            // 0 если v1 == v2
            // +1 если v1 > v2
        }

        public void Add(T value)
        {
            // автоматическая вставка value 
            // в нужную позицию
        }

        public Node<T> Find(T val)
        {
            return null; // здесь будет ваш код
        }

        public void Delete(T val)
        {
            // здесь будет ваш код
        }

        public void Clear(bool asc)
        {
            _ascending = asc;
            // здесь будет ваш код
        }

        public int Count()
        {
            return 0; // здесь будет ваш код подсчёта количества элементов в списке
        }

        List<Node<T>> GetAll() // выдать все элементы упорядоченного 
                               // списка в виде стандартного списка
        {
            List<Node<T>> r = new List<Node<T>>();
            Node<T> node = head;
            while (node != null)
            {
                r.Add(node);
                node = node.next;
            }
            return r;
        }
    }

    class CMain
    {
        public static void Main() { }
    }
}