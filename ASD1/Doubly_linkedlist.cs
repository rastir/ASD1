using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    /// <summary>
    /// Двунаправленный связанный список
    /// </summary>
    /// Обычный список мы можем проходить только в одну сторону, от головы к хвосту, но имеется немало задач, когда желательно оставаться в рамках модели связанного списка, но бегать по нему в обе стороны. Некоторые операции в результате становятся ещё более эффективными (например, удаление узла), однако приходится выделять дополнительную "ячейку" памяти под второй указатель.

//    Концепция узла расширяется полем prev, который теперь указывает на предыдущий элемент в списке -- в дополнение к узлу next, который указывает на следующий элемент.

//    Общая схема работы двунаправленного связанного списка(класс LinkedList2) сохраняется как в прошлом уроке.

//   Немного изменить нам потребуется лишь метод add_in_tail() :

//void add_in_tail(Node item)
//    if (head == null)
//        head = item
//        item.prev = null
//        item.next = null
//    else
//        tail.next = item
//        item.prev = tail
//    tail = item
//Задания.
//1. Добавьте в класс LinkedList2 метод поиска первого узла по его значению.
//2. Добавьте в класс LinkedList2 метод поиска всех узлов по конкретному значению (возвращается список/массив найденных узлов).
//3. Добавьте в класс LinkedList2 метод удаления одного узла по его значению.
//4. Добавьте в класс LinkedList2 метод удаления всех узлов по конкретному значению.
//5. Добавьте в класс LinkedList2 метод вставки узла после заданного узла.
//6. Добавьте в класс LinkedList2 метод вставки узла самым первым элементом (как вариант предыдущего пункта, например).
//7. Добавьте в класс LinkedList2 метод очистки всего содержимого(создание пустого списка).
//8. Напишите проверочные тесты для каждого из предыдущих заданий.

//Рекомендации по тестированию
//Проверяйте случаи, когда список пустой, содержит много элементов и один элемент: как в таких ситуациях будет работать удаление, вставка, поиск.Особое внимание уделите корректности полей head и tail после всех этих операций, а также связь в обратную сторону prev.

//* 9. Существует интересный финт, обсуждаемый на курсе Стэнфордского университета CS106B -- фиктивный/пустой (dummy) узел. Пока нам при любых модификациях списка (добавление/удаление узла) приходится рассматривать три отдельные ситуации: работа с серединой списка, с его головой и с его хвостом.Фиктивный узел позволяет избавиться от этих краевых ситуаций, оставив только по одной универсальной операции на добавление и удаление. Идея в том, что мы добавляем в список два искусственных узла -- голову и хвост, которые пользователю класса не видны (они отличаются от видимых узлов, например, булевым флажком, а лучше всего это делать через наследование и перегрузку). Теперь, добавляя или удаляя узлы, мы всегда будем уверены, что у каждого из них имеется и предыдущий узел, и последующий, и от дополнительных проверок и модификаций полей head и tail можно избавиться.
//В реализации для тестов на сервере такую схему применять не надо, сделайте отдельную реализацию, бонус до +500.
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
                    if (current.next == null)
                        tail = current.next;
                    head = current.next;
                }

                //узел не последний
                else if (current.next != null)
                {
                    previous.next = current.next;
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
                head = current.next;
                current = head;

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
                            tail = node;
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
        static void Main()
        {
            //1-я часть
            //Node n1 = new(12);
            //Node n2 = new(55);
            //n1.next = n2;

            //LinkedList s_list = new LinkedList();
            //s_list.AddInTail(n1);
            //s_list.AddInTail(n2);
            //s_list.AddInTail(new Node(128));

            //Node my_node = s_list.Find(55);
            //Console.WriteLine(my_node.value);
            //Console.ReadKey();

            //var list1 = new List<int> {12, 55, 56 };
            //LinkedList<int> nodes1 = new LinkedList<int>(list1);
            //var list2 = new List<int> { 11, 0, 2 };
            //LinkedList<int> nodes2 = new LinkedList<int>(list1);
            //List<int> result = new List<int>();

            //foreach (int item in result)
            //{
            //    Console.Write(" "+ InsertAfter(list1., nodes2));
            //}            
            //Console.ReadKey();
            //-------------------
            //Node n1 = new(12);
            //Node n2 = new(55);
            //n1.next = n2;

            //LinkedList s_list2 = new LinkedList();
            //s_list2.AddInTail(n1);
            //s_list2.AddInTail(n2);
            //s_list2.AddInTail(new Node(128));
            //s_list2.AddInTail(new Node(55));

            //List<int> print_nodes = new List<int>();
            //s_list2.PrintAllNodes();

            //foreach (var item in s_list2.PrintAllNodes())
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine(print_nodes.Count());
            //s_list2.RemoveAll(n2.value);
            //s_list2.PrintAllNodes();
            //Console.ReadKey();
        }
    }
}
