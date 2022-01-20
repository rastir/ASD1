using System;
using System.Collections.Generic;

/// <summary>
////Курс 1-й АСД
///Связный (связанный) список
/// </summary>

//Прочитайте обязательно:
//    Введение
//    Асимптотический анализ
//    Связный список -- это набор "элементарных" данных(например, чисел или строк), каждое из которых связано с другим данным "связью", извините за тавтологию.Каждое элементарное данное вместе со своей "связью" называется узел.
//  Надо сделать отступление для тех, кто не знаком с понятием указателя.
//Во многих языках программирования принято, что значение любого типа -- это объект, который хранится где-то в памяти, а переменная, в которую мы "записываем" этот объект, на самом деле хранит не его, а указатель на место в памяти, где реальный объект находится (адрес в памяти, номер ячейки памяти условно, ссылка). Поэтому когда мы записали в переменную x объект(экземпляр класса, список, ...), а потом делаем
//y = x
//то мы не копируем сам объект, а копируем только его адрес в памяти.По сути, и x и y указывают на один и тот же объект! И при обращении к любой из них будет меняться один и тот же объект. Это так называемая передача значения (объекта) по ссылке.
//Исключение делается обычно для чисел и строк -- они действительно в присваивании полноценно копируются (это так называемая передача по значению).
//В простейшем случае узел просто связывается со следующим узлом, получается цепочка узлов, по которой мы можем передвигаться от начала к концу(от конца к началу не можем, так как связь организована только в одну сторону). Конец списка обозначается так: связь последнего узла указывает на отсутствие значения, обычно реализованное в той или иной форме во всех языках.Условимся это отсутствие значения обозначать null.
//Отличие связного списка от массива, например, в том, что в связном списке мы можем легко вычленить его часть, взяв за начало любой элемент списка. Кроме того, операции добавления и удаления элементов выполняются очень эффективно, всего за два шага. И в памяти связный список хранится иначе, нежели массив: узлы списка могут быть разбросаны в памяти произвольно, а массив обычно занимает непрерывную область памяти.
//Нам потребуется определить два класса: Node, который определяет узел, и LinkedList, который собственно и задаёт связный список.
//В классе Node будут два элемента: value (само данное) и next -- "связь", по сути указатель на следующий узел (объект типа Node). Если данный узел финальный, поле next будет хранить null.
//Далее в этом курсе при записи алгоритмов или иных демонстрационных частей программы мы будем придерживаться некоторого условного псевдокода, напоминающего основной синтаксис популярных языков программирования.
//Псевдокод -- это упрощенный вариант синтаксиса C++, Java, C# и им подобных. Для простоты мы используем отступы вместо фигурных скобок, не ставим ";" и т. д.
//Класс LinkedList -- это по сути "обёртка", синтаксический сахар для узлов.Ведь мы уже можем работать с узлами напрямую:
//n1 = new Node(12)
//n2 = new Node(55)
//n1.next = n2
//В классе LinkedList нам понадобятся два поля: head и tail.В конструкторе этого класса зададим им значения null.
//Поле head -- это по сути указатель на узел-голову списка, а поле tail -- это указатель на завершающий узел.
//Добавим в класс LinkedList метод add_in_tail(), который добавляет новый узел в конец списка:
//void add_in_tail(Node item)
//    if (head == null)
//        head = item
//    else
//        tail.next = item
//    tail = item
//Перебор всех элементов списка запишется примерно так:

//node = head
//while (node != null)
//    node = node.next
//Сформируем тестовый список из трёх элементов:

//s_list = new LinkedList()
//s_list.add_in_tail(n1)
//s_list.add_in_tail(n2)
//s_list.add_in_tail(new Node(128))
//Объект s_list будет хранить список 12 55 128

//Теперь нам надо найти нужный узел по заданному значению:

//Node find(int val)
//    node = head
//    while (node != null)
//        if (node.value == val)
//            return node
//        node = node.next
//    return null
//my_node = s_list.find(55)
//Разрешать ли изменять значение некоторого узла в списке(менять значение его поля value)? В общем случае это нежелательно -- всегда лучше исходить из того, что наш связный список иммутабелен, и любые операции над ним не меняют содержимое его узлов.Вместо изменения значения узла лучше пользоваться комбинацией методов удаления и вставки нового узла.

//Задание.Реализуйте соответствующий код на выбранном вами языке программирования.
//Пункты, помеченные* сделайте отдельно.
//1. Добавьте в класс LinkedList метод удаления одного узла по его значению.
//2. Добавьте в класс LinkedList метод удаления всех узлов по конкретному значению.
//3. Добавьте в класс LinkedList метод очистки всего содержимого (создание пустого списка).
//4. Добавьте в класс LinkedList метод поиска всех узлов по конкретному значению(возвращается список/массив найденных узлов).
//5. Добавьте в класс LinkedList метод вычисления длины списка.
//6. Добавьте в класс LinkedList метод вставки узла после заданного узла.
//* 7. Напишите проверочные тесты для каждого из предыдущих заданий.
//* 8. Напишите функцию, которая получает на вход два связных списка, состоящие из целых значений, и если их длины равны, возвращает список, каждый элемент которого равен сумме соответствующих элементов входных списков.
//Рекомендации по тестированию.
//Проверяйте случаи, когда список пустой, содержит много элементов и один элемент: как в таких ситуациях будет работать удаление одного и нескольких элементов, вставка, поиск.Особое внимание уделите корректности полей head и tail после всех этих операций.


//Node, который определяет узел
//класс узла, который будет представлять одиночный объект в списке
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