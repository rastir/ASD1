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

                LinkedList s_list = new LinkedList();
                s_list.AddInTail(n1);
                s_list.AddInTail(n2);
                s_list.AddInTail(new Node(128));

                Assert.AreEqual(3, s_list.count);
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
                LinkedList s_list = new LinkedList();
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
        public void LinkedList_Find1() //когда связный список НЕпустой
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList s_list = new LinkedList();
                s_list.AddInTail(n1);
                s_list.AddInTail(n2);
                s_list.AddInTail(new Node(128));

                Node my_node = s_list.Find(1000);
                //Assert.IsNotNull(my_node);
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
        public void LinkedList_Find2() //когда связный список пустой
        {
            try
            {
                LinkedList s_list = new LinkedList();

                Node my_node = s_list.Find(1000);
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

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(55));

                List<Node> nodes = s_list2.FindAll(n2.value);
                Assert.IsNotNull(nodes);
                Assert.AreEqual(8, nodes.Count);    
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
        public void LinkedList_FindAll_one_element() //когда связный список НЕпустой
        {
            try
            {
                Node n1 = new(12);
                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);

                List<Node> nodes = s_list2.FindAll(n1.value);
                Assert.IsNotNull(nodes);
                Assert.AreEqual(1, nodes.Count);   
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
        public void LinkedList_FindAll_null() //когда связный список пустой
        {
            try
            {
                LinkedList s_list2 = new LinkedList();

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
        public void LinkedList_Remove_notnull() //когда связный список НЕпустой
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                bool result = s_list2.Remove(n2.value);
                Assert.IsTrue(result);
                int res = s_list2.count;
                Assert.AreEqual(3, res);
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
        public void LinkedList_RemoveAll_null() //когда связный список пустой
        {
            try
            {
                LinkedList s_list2 = new LinkedList();

                s_list2.RemoveAll(12);
                int res = s_list2.count;
                Assert.AreEqual(0, res);
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
        public void LinkedList_RemoveAll_notnull() //когда связный список НЕпустой
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                s_list2.RemoveAll(n2.value);
                int res = s_list2.count;
                Assert.AreEqual(2, res);
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
        public void LinkedList_Clear_null() //когда связный список пустой
        {
            try
            {
                LinkedList s_list2 = new LinkedList();

                s_list2.Clear();
                int res = s_list2.count;
                Assert.AreEqual(0, res);
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
        public void LinkedList_Clear_notnull() //когда связный список НЕпустой
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                s_list2.Clear();
                int res = s_list2.count;
                Assert.AreEqual(0, res);
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
        public void LinkedList_Count_null() //когда связный список пустой
        {
            try
            {
                LinkedList s_list2 = new LinkedList();

                int res = s_list2.Count();
                Assert.AreEqual(0, res);
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
        public void LinkedList_Count_notnull() //когда связный список НЕпустой
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                int res = s_list2.Count();
                Assert.AreEqual(4, res);
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
        public void LinkedList_InsertAfter_null() //когда связный список пустой
        {
            try
            {
                LinkedList s_list2 = new LinkedList();
                Node n1 = new(12);
                Node n2 = new(25);
                //n1.next=n2;
                //s_list.AddInTail(n1);
                //s_list.AddInTail(n2);

                s_list2.InsertAfter(null,n1);
                s_list2.InsertAfter(n1, n2);

                int res = s_list2.Count();
                Assert.AreEqual(3, res);
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
        public void LinkedList_InsertAfter_notnull0()
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList s_list2 = new LinkedList();
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
        public void LinkedList_InsertAfter_notnull1() //когда связный список НЕпустой
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                s_list2.InsertAfter(null, n2);

                int res = s_list2.Count();
                Assert.AreEqual(5, res);
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
        public void LinkedList_InsertAfter_notnull2() //когда связный список НЕпустой
        {
            try
            {
                Node n1 = new(12);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                s_list2.InsertAfter(n1, n2);

                int res = s_list2.Count();
                Assert.AreEqual(5, res);
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
        public void LinkedList_Equal_Lenght_null() //когда связный список пустой
        {
            try
            {
                var list1 = new List<int> { };
                LinkedList<int> nodes1 = new LinkedList<int>(list1);
                var list2 = new List<int> { };
                LinkedList<int> nodes2 = new LinkedList<int>(list2);
                List<int> result = new List<int>();

                LinkedList s_list3 = new LinkedList();
                s_list3.Equal_Lenght(nodes1,nodes2);

                Assert.AreEqual(s_list3.Count(), 0);
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
        public void LinkedList_Equal_Lenght_notnull() //когда связный список НЕпустой
        {
            try
            {
                var list1 = new List<int> { 12, 55, 56 };
                LinkedList<int> nodes1 = new LinkedList<int>(list1);
                var list2 = new List<int> { 11, 0, 2 };
                LinkedList<int> nodes2 = new LinkedList<int>(list2);
                List<int> result = new List<int>();

                LinkedList s_list3 = new LinkedList();
                s_list3.Equal_Lenght(nodes1, nodes2);

                var list33 = new List<int> { 23, 55, 58 };

                CollectionAssert.AreEqual(list33, s_list3.Equal_Lenght(nodes1, nodes2));
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
