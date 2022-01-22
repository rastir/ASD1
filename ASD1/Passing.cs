using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Двунаправленный связанный список
    /// </summary>
    public class Node
    {
        public int value; //Класс Node является обобщенным, поэтому может хранить данные любого типа. Для хранения данных предназначено свойство value.
        public Node next, prev; //Для ссылки на следующий узел определено свойство Next.
        public Node(int _value)
        {
            value = _value;
            next = null;
            prev = null;
        }
    }
    public class LinkedList2 //2хсвязный список
    {
        public Node head; // головной/первый элемент
        public Node tail; // последний/хвостовой элемент
        public Node prev;

        public LinkedList2() //конструктор класса, инициализируем 
        {
            head = null; //поле head - указатель на узел-голову списка 
            tail = null; //поле tail -- это указатель на завершающий узел.
        }

        public void AddInTail(Node _item) //доабвление нового узла в конец списка
        {
            if (head == null)
            {
                head = _item;
                head.next = null;
                head.prev = null;
            }
            else
            {
                tail.next = _item;
                _item.prev = tail;
            }
            tail = _item;
        }
        /// <summary>
        /// 1. Метод поиска первого узла по его значению.
        /// </summary>
        /// <param name="_value"></param>
        /// <returns></returns>
        public Node Find(int _value)
        {
            Node? node = head;
            while (node != null)
            {
                if (node.value == _value)
                    return node;
                node = node.next;
            }
            return null;

        }
        /// <summary>
        /// 2. Метод поиска всех узлов по конкретному значению (возвращается список/массив найденных узлов).
        /// </summary>
        /// <param name="_value"></param>
        /// <returns></returns>
        public List<Node> FindAll(int _value) //поиск всех значений по заданному значению
        {
            List<Node> nodes = new List<Node>();

            var current = head;
            while (current != null)
            {
                if (current.value == _value)
                    nodes.Add(current);
                current = current.next;
            }
            return nodes;
        }
        /// <summary>
        /// 3. Метод удаления одного узла по его значению
        /// </summary>
        /// <param name="_value"></param>
        /// <returns></returns>
        public bool Remove(int _value)
        {
            // здесь будет ваш код удаления одного узла по заданному значению
            Node current = head;
            Node previous = null;

            // поиск удаляемого узла
            while (current != null)
            {
                if (current.value == _value)
                {
                    break;
                }
                previous = current;
                current = current.next;
            }
            if (current != null)
            {
                //узел первый
                if (current == head)
                {
                    //узел первый и последний
                    if (current.next == null)
                    {
                        tail = current.next;
                        head = current.next;
                        return true;
                    }
                    head = current.next;
                    head.prev = previous;
                }

                //узел не последний
                else if (current.next != null)
                {
                    previous.next = current.next;
                    current.next.prev = previous;
                }
                else
                {
                    // если последний, переустанавливаем tail
                    tail = previous;
                    previous.next = current.next;
                }

                //count--;
                return true;
            }
            return false;
        }
        /// <summary>
        /// 4. Метод удаления всех узлов по конкретному значению.
        /// </summary>
        /// <param name="_value"></param>
        public void RemoveAll(int _value)
        {
            Node current = head, previous = null;

            //delete occurrences head
            while (current != null && current.value == _value)
            {
                //первый узел
                if (current.prev == null)
                {
                    //последний узел
                    if (current.next == null)
                    {
                        head = current.next;
                        tail = head;
                        current = head;
                        break;
                    }
                    else
                    {
                        current.next.prev = head.prev;
                        head = current.next;
                        current = head;
                    }
                }
                //предпоследний узел
                if (current != null && current.next == null)
                {
                    tail = previous;
                    if (previous != null)
                        previous.next = current.next;
                    //tail = current.next;
                }
                if (current == null)
                    tail = previous;
            }

            // Delete occurrences other than head
            while (current != null)
            {
                // Search for the key to be deleted,
                // keep track of the previous node
                // as we need to change 'prev->next'
                while (current != null && current.value != _value)
                {
                    previous = current;
                    current = current.next;
                }

                // If key was not present in linked list
                if (current == null)
                    return;

                // Unlink the node from linked list
                previous.next = current.next;

                // Update current for next iteration of outer loop
                current = previous.next;
                if (current != null)
                    current.prev = previous;
                if (current == null && previous.next == null)
                    tail = previous;
            }
            //tail = head;
        }
        /// <summary>
        /// 5. Метод вставки узла после заданного узла
        /// 6. Метод вставки узла самым первым элементом (как вариант предыдущего пункта, например)
        /// </summary>
        /// <param name="_nodeAfter"></param>
        /// <param name="_nodeToInsert"></param>
        public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
        {
            Node current = head;

            if (_nodeToInsert == null)
                return;

            // если _nodeAfter = null , 
            // добавьте новый элемент первым в списке 

            if (_nodeAfter is null)
            {
                if (head == null)
                {
                    head = _nodeToInsert;
                    tail = head;
                }
                else
                {
                    Node node = new Node(_nodeToInsert.value);
                    node.next = head;
                    head = node;
                }
            }
            else
            {
                while (current != null)
                {
                    if (current == _nodeAfter)
                    {
                        Node node = new Node(_nodeToInsert.value);
                        if (current.next == null)
                        {
                            tail = node;
                            tail.prev = current;
                        }
                        else
                            node.next = current.next;
                        current.next = node;
                        node = null;
                        break;
                    }
                    current = current.next;
                }
            }
        }
        /// <summary>
        /// 7. Метод очистки всего содержимого (создание пустого списка).
        /// </summary>
        public void Clear()
        {
            // здесь будет ваш код очистки всего списка
            head = null;
            tail = head;
        }

        public int Count()
        {
            // здесь будет ваш код подсчёта количества элементов в списке
            Node current = head;
            int count = 0;

            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }


        public List<int> Equal_Lenght(LinkedList<int> nodes1, LinkedList<int> nodes2)
        {
            var current1 = nodes1.First;
            var current2 = nodes2.First;
            List<int> result = new List<int>();

            if (nodes1.Count == 0)
                return result;
            if (nodes2.Count == 0)
                return result;

            if (nodes1.Count() == nodes2.Count())
            {
                while (current1 != null && current2 != null)
                {
                    int a, b;
                    a = current1.Value;
                    b = current2.Value;
                    result.Add(a + b);
                    current1 = current1.Next;
                    current2 = current2.Next;
                }
            }
            return result;
        }
    }
}
