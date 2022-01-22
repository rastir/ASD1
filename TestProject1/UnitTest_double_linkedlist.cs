using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using AlgorithmsDataStructures;

namespace TestProject1
{
    ///<summary> 
    ///Тесты для задания "Связный (связанный) список"
    /// </summary>
    [TestClass]
    public class AlgorithmsDataStructures
    {
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_AddInTail_many_elements()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList2 s_list = new LinkedList2();
                s_list.AddInTail(n1);
                s_list.AddInTail(n2);
                s_list.AddInTail(new Node(128));

                Assert.AreEqual(3, s_list.Count());
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_AddInTail_one_element()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(12);
                n1.next = n2;
                LinkedList2 s_list = new LinkedList2();
                s_list.head = n1;
                s_list.tail = n2;

                Node n3 = new(55);
                Node n4 = new(56);
                s_list.AddInTail(n3);
                s_list.AddInTail(n4);
                Assert.AreEqual(4, s_list.Count());
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_AddInTail_empty_elements()
        {
            try
            {
                LinkedList2 s_list = new LinkedList2();
                s_list.AddInTail(new Node(128));

                Assert.AreEqual(1, s_list.Count());
                Assert.AreEqual(s_list.head.value, 128);
                Assert.AreEqual(s_list.tail.value, 128);
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        /// <summary>
        /// Find: список пустой, содержит много элементов, содержит один элемент
        /// удаление, вставка, поиск
        /// проверить корректность head, tail, prev
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Find_when_epmtylist()
        {
            try
            {
                LinkedList2 s_list = new LinkedList2();

                Node my_node = s_list.Find(1000);

                if (s_list.head != null || s_list.tail != null || s_list.prev != null || my_node != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Find_when_many_elements_not_in_list()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;
                Node n3 = new Node(128);
                n2.next = n3;

                LinkedList2 s_list = new LinkedList2();
                s_list.AddInTail(n1);
                s_list.AddInTail(n2);
                s_list.AddInTail(n3);

                Node my_node = s_list.Find(1000);
                if (s_list.head != n1 || s_list.tail != n3 || my_node != null)
                    Assert.Fail();

            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Find_when_many_elements_in_list()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;
                Node n3 = new Node(128);
                n2.next = n3;

                LinkedList2 s_list = new LinkedList2();
                s_list.AddInTail(n1);
                s_list.AddInTail(n2);
                s_list.AddInTail(n3);

                Node my_node = s_list.Find(128);
                Assert.AreEqual(my_node, n3);
                Assert.AreEqual(my_node.prev, n2);
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        /// <summary>
        /// FindAll: список пустой, содержит много элементов, содержит один элемент
        /// удаление, вставка, поиск
        /// проверить корректность head, tail, prev
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_FindAll_empty()
        {
            try
            {
                LinkedList2 s_list2 = new LinkedList2();

                List<Node> nodes = s_list2.FindAll(55);
                Assert.AreEqual(0, nodes.Count);
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_FindAll_many_elements()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(56));
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(57));
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(58));
                s_list2.AddInTail(new Node(55));

                List<Node> nodes = s_list2.FindAll(n2.value);
                Assert.IsNotNull(nodes);
                Assert.AreEqual(5, nodes.Count);
                Assert.AreEqual(nodes[0].value, n2.value);
                Assert.AreEqual(nodes[4].value, 55);
                if (nodes[0].prev.value != 12 || nodes[4].next != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_FindAll_one_element()
        {
            try
            {
                Node n1 = new(12);
                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);

                List<Node> nodes = s_list2.FindAll(n1.value);
                Assert.IsNotNull(nodes);
                Assert.AreEqual(1, nodes.Count);
                if (nodes[0].next != null || nodes[0].prev != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        /// <summary>
        /// Remove: список пустой, содержит много элементов, содержит один элемент
        /// удаление, вставка, поиск
        /// проверить корректность head, tail, prev
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Remove_empty()
        {
            try
            {
                LinkedList2 s_list2 = new LinkedList2();

                bool result = s_list2.Remove(23);

                if (result || s_list2.Count() != 0 || s_list2.head != null || s_list2.tail != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_Remove_empty\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Remove_many_elements_first_delete()
        {
            try
            {
                Node n1 = new(55);
                Node n2 = new(56);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(57));
                s_list2.AddInTail(new Node(59));

                bool result = s_list2.Remove(n1.value);
                Assert.IsTrue(result);
                Assert.AreEqual(3, s_list2.Count());
                Assert.AreEqual(56, s_list2.head.value);
                Assert.AreEqual(59, s_list2.tail.value);
                if (s_list2.head.prev != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Remove_many_elements_middle_delete()
        {
            try
            {
                Node n1 = new(55);
                Node n2 = new(56);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(57));
                s_list2.AddInTail(new Node(59));

                bool result = s_list2.Remove(n2.value);
                Assert.IsTrue(result);
                Assert.AreEqual(3, s_list2.Count());
                Assert.AreEqual(55, s_list2.head.value);
                Assert.AreEqual(57, s_list2.head.next.value);
                Assert.AreEqual(59, s_list2.tail.value);
                Assert.AreEqual(57, s_list2.tail.prev.value);
                if (s_list2.head.prev != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Remove_many_elements_last_delete()
        {
            try
            {
                Node n1 = new(55);
                Node n2 = new(56);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(57));
                s_list2.AddInTail(new Node(59));

                bool result = s_list2.Remove(59);
                Assert.IsTrue(result);
                Assert.AreEqual(3, s_list2.Count());
                Assert.AreEqual(55, s_list2.head.value);
                Assert.AreEqual(56, s_list2.head.next.value);
                Assert.AreEqual(57, s_list2.tail.value);
                Assert.AreEqual(56, s_list2.tail.prev.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Remove_two_elements_first_delete()
        {
            try
            {
                Node n1 = new(55);
                Node n2 = new(56);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);

                bool result = s_list2.Remove(55);
                Assert.IsTrue(result);
                Assert.AreEqual(1, s_list2.Count());
                Assert.AreEqual(56, s_list2.head.value);
                Assert.AreEqual(56, s_list2.tail.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null || s_list2.head.next != null || s_list2.tail.prev != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Remove_two_elements_last_delete()
        {
            try
            {
                Node n1 = new(55);
                Node n2 = new(56);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);

                bool result = s_list2.Remove(56);
                Assert.IsTrue(result);
                Assert.AreEqual(1, s_list2.Count());
                Assert.AreEqual(55, s_list2.head.value);
                Assert.AreEqual(55, s_list2.tail.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null || s_list2.head.next != null || s_list2.tail.prev != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Remove_one_element()
        {
            try
            {
                LinkedList2 s_list2 = new LinkedList2();
                Node n1 = new(12);
                s_list2.AddInTail(n1);

                bool result = s_list2.Remove(n1.value);

                if (!result || s_list2.Count() != 0 || s_list2.head != null || s_list2.tail != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_Remove_one_element\" PASSED");
            }
        }
        /// <summary>
        /// RemoveAll: список пустой, содержит много элементов, содержит один элемент
        /// удаление, вставка, поиск
        /// проверить корректность head, tail, prev
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_RemoveAll_empty()
        {
            try
            {
                LinkedList2 s_list2 = new LinkedList2();

                s_list2.RemoveAll(12);
                Assert.AreEqual(0, s_list2.Count());
                if (s_list2.head != null || s_list2.tail != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_RemoveAll_many_equal_elements_exist()
        {
            try
            {
                Node n1 = new(55);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(55));

                s_list2.RemoveAll(n2.value);

                Assert.AreEqual(0, s_list2.Count());
                if (s_list2.head != null || s_list2.tail != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_RemoveAll_many_equal_elements_not_exist()
        {
            try
            {
                Node n1 = new(55);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(55));

                s_list2.RemoveAll(56);

                Assert.AreEqual(4, s_list2.Count());
                Assert.AreEqual(55, s_list2.head.value);
                Assert.AreEqual(55, s_list2.tail.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_RemoveAll_from_first()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                s_list2.RemoveAll(n1.value);

                Assert.AreEqual(3, s_list2.Count());
                Assert.AreEqual(55, s_list2.head.value);
                Assert.AreEqual(55, s_list2.tail.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_from_first\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_RemoveAll_from_middle()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                s_list2.RemoveAll(n2.value);

                Assert.AreEqual(2, s_list2.Count());
                Assert.AreEqual(12, s_list2.head.value);
                Assert.AreEqual(128, s_list2.tail.value);
                Assert.AreEqual(128,s_list2.head.next.value);
                Assert.AreEqual(12, s_list2.tail.prev.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_RemoveAll_from_last()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(57);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                s_list2.RemoveAll(55);

                Assert.AreEqual(3, s_list2.Count());
                Assert.AreEqual(12, s_list2.head.value);
                Assert.AreEqual(128, s_list2.tail.value);
                Assert.AreEqual(57, s_list2.head.next.value);
                Assert.AreEqual(57, s_list2.tail.prev.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null)
                    Assert.Fail();

            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_from_last\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_RemoveAll_one_element()
        {
            try
            {
                Node n1 = new(12);

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);

                s_list2.RemoveAll(n1.value);

                if (s_list2.Count() != 0 || s_list2.head != null || s_list2.tail != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        /// <summary>
        /// Count
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Count_null()
        {
            try
            {
                LinkedList2 s_list2 = new LinkedList2();

                Assert.AreEqual(0, s_list2.Count());
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Count_notnull()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                Assert.AreEqual(4, s_list2.Count());
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        /// <summary>
        /// InsertAfter: список пустой, содержит много элементов, содержит один элемент
        /// удаление, вставка, поиск
        /// проверить корректность head, tail, prev
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_InsertAfter_empty_first1()
        {
            try
            {
                LinkedList2 s_list2 = new LinkedList2();
                Node n1 = new(12);
                Node n2 = new(25);

                s_list2.InsertAfter(null, n1);
                //s_list2.InsertAfter(n1, n2);

                Assert.AreEqual(1, s_list2.Count());
                Assert.AreEqual(s_list2.head.value, 12);
                Assert.AreEqual(s_list2.tail.value, 12);
                if (s_list2.head.prev != null || s_list2.tail.next != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_InsertAfter_empty_first2()
        {
            try
            {
                LinkedList2 s_list2 = new LinkedList2();
                Node n1 = new(12);
                Node n2 = new(25);

                s_list2.InsertAfter(n2, n1);
                s_list2.InsertAfter(n1, n2);

                if (s_list2.head != null || s_list2.tail != null || s_list2.Count() != 0)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_InsertAfter_empty_not_null()
        {
            try
            {
                LinkedList2 s_list2 = new LinkedList2();
                Node n1 = new(12);
                Node n2 = new(25);

                //s_list2.InsertAfter(null, n1);
                s_list2.InsertAfter(n1, n2);
                if (s_list2.Count() != 0 || s_list2.head != null || s_list2.tail != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_InsertAfter_empty_null4()
        {
            try
            {
                LinkedList2 s_list2 = new LinkedList2();
                Node n1 = new(12);
                Node n2 = new(25);

                s_list2.InsertAfter(null, n1);
                Assert.AreEqual(1, s_list2.Count());
                Assert.AreEqual(12, s_list2.head.value);
                Assert.AreEqual(12, s_list2.tail.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null)
                    Assert.Fail();

                s_list2.InsertAfter(n1, n2);
                Assert.AreEqual(2, s_list2.Count());
                Assert.AreEqual(12, s_list2.head.value);
                Assert.AreEqual(25, s_list2.head.next.value);
                Assert.AreEqual(25, s_list2.tail.value);
                Assert.AreEqual(12, s_list2.tail.prev.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_InsertAfter_not_empty_null_null()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));
                s_list2.InsertAfter(null, null);

                Assert.AreEqual(4, s_list2.Count());
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_InsertAfter_not_empty_middle()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                s_list2.InsertAfter(null, n2);

                Assert.AreEqual(5, s_list2.Count());
                Assert.AreEqual(55, s_list2.head.value);
                Assert.AreEqual(55, s_list2.tail.value);
                Assert.AreEqual(12, s_list2.head.next.value);
                Assert.AreEqual(128, s_list2.tail.prev.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_InsertAfter_not_empty_middle2()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                s_list2.InsertAfter(n1, n2);

                Assert.AreEqual(5, s_list2.Count());
                Assert.AreEqual(12, s_list2.head.value);
                Assert.AreEqual(55, s_list2.tail.value);
                Assert.AreEqual(55, s_list2.head.next.value);
                Assert.AreEqual(128, s_list2.tail.prev.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_InsertAfter_not_empty_last()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(56);
                n1.next = n2;
                Node n3 = new(57);
                n2.next = n3;
                Node n4 = new(58);
                n3.next = n4;
                Node nn = new(111);

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(n3);
                s_list2.AddInTail(n4);

                s_list2.InsertAfter(n4, nn);

                Assert.AreEqual(5, s_list2.Count());
                Assert.AreEqual(12, s_list2.head.value);
                Assert.AreEqual(111, s_list2.tail.value);
                Assert.AreEqual(56, s_list2.head.next.value);
                Assert.AreEqual(58, s_list2.tail.prev.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_InsertAfter_not_empty_one_element()
        {
            try
            {
                Node n1 = new(12);
                Node nn = new(111);

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);

                s_list2.InsertAfter(n1, nn);

                Assert.AreEqual(2, s_list2.Count());
                Assert.AreEqual(12, s_list2.head.value);
                Assert.AreEqual(111, s_list2.tail.value);
                Assert.AreEqual(111, s_list2.head.next.value);
                Assert.AreEqual(12, s_list2.tail.prev.value);
                if (s_list2.head.prev != null || s_list2.tail.next != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        /// <summary>
        /// Clear: список пустой, содержит много элементов, содержит один элемент
        /// удаление, вставка, поиск
        /// проверить корректность head, tail, prev
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Clear_null()
        {
            try
            {
                LinkedList2 s_list2 = new LinkedList2();

                s_list2.Clear();

                if (s_list2.Count() != 0 || s_list2.head != null || s_list2.tail != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Clear_notnull()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList2 s_list2 = new LinkedList2();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                s_list2.Clear();

                if (s_list2.Count() != 0 || s_list2.head != null || s_list2.tail != null)
                    Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"LinkedList_AddInTail\" PASSED");
            }
        }
    }
}
