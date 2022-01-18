////using System;
////using System.Collections.Generic;

//namespace AlgorithmsDataStructures
//{
//    public class Node
//    {
//        public int value; //Класс Node является обобщенным, поэтому может хранить данные любого типа. Для хранения данных предназначено свойство value.
//        public Node next; //Для ссылки на следующий узел определено свойство Next.
//        public Node(int _value)
//        {
//            value = _value;
//        }
//    }

////    // LinkedList, который собственно и задаёт связный список.     //"обёртка", синтаксический сахар для узлов.
////    //Далее определим сам класс списка
////    public class LinkedList //односвязный список
////    {
////        public Node? head; // головной/первый элемент
////        public Node? tail; // последний/хвостовой элемент
////        public int count;        // количество элементов в списке

//        public LinkedList() //конструктор класса, инициализируем 
//        {
//            head = null; //поле head - указатель на узел-голову списка 
//            tail = null; //поле tail -- это указатель на завершающий узел.
//        }

////        public void AddInTail(Node _item) //доабвление нового узла в конец списка
////        {
////            if (head == null)
////                head = _item;
////            else
////                tail.next = _item;
////            tail = _item;

////            count++;
////        }

//        }

//        public List<Node> FindAll(int _value) //поиск всех значений по заданному значению
//        {
//            List<Node> nodes = new List<Node>();

//            // здесь будет ваш код поиска всех узлов по заданному значению
//            var current = head;
//            while (current != null)
//            {
//                if (current.value == _value)
//                    nodes.Add(current);
//                current = current.next;
//            }
//            return nodes;
//        }

////            // здесь будет ваш код поиска всех узлов по заданному значению
////            var current = head;
////            while (current != null)
////            {
////                if (current.Equals(_value))
////                    nodes.Add(current);
////                current = current.next;
////            }
////            return nodes;
////        }

//            // поиск удаляемого узла
//            while (current != null)
//            {
//                if (current.value == _value)
//                {
//                    break;
//                }
//                previous = current;
//                current = current.next;
//            }
//            if (current != null)
//            {
//                //узел первый
//                if (current == head)
//                    head = current.next;

//                //узел не последний
//                else if (current.next != null)
//                {
//                    previous.next = current.next;
//                }
//                else
//                {
//                    // если последний, переустанавливаем tail
//                    tail = current;
//                }

//                //count--;
//                return true;
//            }
//            return false;
//        }

////                count--;
////                return true;
////            }
////            return false;
////        }

//            while (current != null)
//            {
//                if (current.value == _value)
//                {
//                    // Если узел в середине или в конце
//                    if (previous != null)
//                    {
//                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
//                        previous.next = current.next;

//                        // Если current.Next не установлен, значит узел последний,
//                        // изменяем переменную tail
//                        if (current.next == null)
//                            tail = previous;
//                    }
//                    else
//                    {
//                        // если удаляется первый элемент
//                        // переустанавливаем значение head
//                        head = head.next;

//                        // если после удаления список пуст, сбрасываем tail
//                        if (head == null)
//                            tail = null;
//                    }
//                }
//                previous = current;
//                current = current.next;
//            }
//        }

////                        // если после удаления список пуст, сбрасываем tail
////                        if (head == null)
////                            tail = null;
////                    }
////                    count--;
////                }
////                previous = current;
////                current = current.next;
////            }
////        }

////        public void Clear()
////        {
////            // здесь будет ваш код очистки всего списка
////            head = null;
////            tail = head;
////            count = 0;
////        }

//            while (current != null)
//            {
//                count++;
//                current = current.next;
//            }
//            return count;
//        }

//        public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
//        {
//            Node current = head;

//            if (_nodeToInsert == null)
//                return;

//            // если _nodeAfter = null , 
//            // добавьте новый элемент первым в списке 

////            // если _nodeAfter = null , 
////            // добавьте новый элемент первым в списке 

////            if (_nodeAfter is null)
////            {
////                if (head == null)
////                    head = _nodeToInsert;
////                else
////                {
////                    Node node = new Node(_nodeToInsert.value);
////                    node.next = head;
////                    head = node;
////                }
////            }
////            else
////            {
////                while (current != null)
////                {
////                    if (current == _nodeAfter)
////                    {
////                        Node node = new Node(_nodeToInsert.value);
////                        current.next = node;
////                        node.next = _nodeToInsert;
////                        break;
////                    }
////                    current = current.next;
////                }
////            }
////        }
////        public List<int> Equal_Lenght(LinkedList<int> nodes1, LinkedList<int> nodes2)
////        {
////            //Node nodes1 = head;
////            var current1 = nodes1.First;
////            var current2 = nodes2.First;
////            List<int> result = new List<int>();

//            if (nodes1.Count == 0)
//                return result;
//            if (nodes2.Count == 0)
//                return result;

//            if (nodes1.Count() == nodes2.Count())
//            {
//                while (current1 != null && current2 != null)
//                {
//                    int a, b;
//                    a = current1.Value;
//                    b = current2.Value;
//                    result.Add(a + b);
//                    current1 = current1.Next;
//                    current2 = current2.Next;
//                }
//            }
//            return result;
//        }
//    }
//}
