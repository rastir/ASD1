using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;
namespace AlgorithmsDataStructures
{
    public class Node
    {
        public int value; //Класс Node является обобщенным, поэтому может хранить данные любого типа. Для хранения данных предназначено свойство value.
        public Node next; //Для ссылки на следующий узел определено свойство Next.
        public Node(int _value)
        {
            value = _value;
        }
    }

    // LinkedList, который собственно и задаёт связный список.     //"обёртка", синтаксический сахар для узлов.
    //Далее определим сам класс списка
    public class LinkedList //односвязный список
    {
        public Node head; // головной/первый элемент
        public Node tail; // последний/хвостовой элемент

        public LinkedList() //конструктор класса, инициализируем 
        {
            head = null; //поле head - указатель на узел-голову списка 
            tail = null; //поле tail -- это указатель на завершающий узел.
        }

        public void AddInTail(Node _item) //доабвление нового узла в конец списка
        {
            if (head == null)
                head = _item;
            else
                tail.next = _item;
            tail = _item;
        }

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

        public List<Node> FindAll(int _value) //поиск всех значений по заданному значению
        {
            List<Node> nodes = new List<Node>();

            // здесь будет ваш код поиска всех узлов по заданному значению
            var current = head;
            while (current != null)
            {
                if (current.value == _value)
                    nodes.Add(current);
                current = current.next;
            }
            return nodes;
        }

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
                    head = current.next;

                //узел не последний
                else if (current.next != null)
                {
                    previous.next = current.next;
                }
                else
                {
                    // если последний, переустанавливаем tail
                    tail = current;
                }

                //count--;
                return true;
            }
            return false;
        }

        public void RemoveAll(int _value)
        {

            // здесь будет ваш код удаления всех узлов по заданному значению
            Node current = head, prev = null;

            // If head node itself holds the key
            // or multiple occurrences of key
            while (current != null && current.value == _value)
            {
                head = current.next; // Changed head
                //tail = current.next;
                current = head; // Change current
                if (current != null && current.next == null)
                    tail = current.next;
            }

            // Delete occurrences other than head
            while (current != null)
            {
                while (current != null && current.value != _value)
                {
                    prev = current;
                    current = current.next;
                }

                if (current == null)
                    return;

                prev.next = current.next;

                current = prev.next;
                if (current == null && prev.next == null)
                    tail = prev;
            }
            //tail = head;
        }

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
                    head = _nodeToInsert;
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
                        current.next = node;
                        node.next = _nodeToInsert;
                        break;
                    }
                    current = current.next;
                }
            }
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
