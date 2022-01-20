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
        public void LinkedList_Find1() 
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
        public void LinkedList_Find2() 
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
        public void LinkedList_FindAll_one_element() 
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
        public void LinkedList_FindAll_empty() 
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
        public void LinkedList_Remove_notnull() 
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
                Assert.AreEqual(3, s_list2.Count());
                Assert.AreEqual(12, s_list2.head.value);
                Assert.AreEqual(55, s_list2.tail.value);
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
        public void LinkedList_Remove_empty()
        {
            try
            {
                LinkedList s_list2 = new LinkedList();

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
        public void LinkedList_Remove_one_element()
        {
            try
            {
                Node n1 = new(12);
                //n1.next = new(12);
                
                LinkedList s_list2 = new LinkedList();
                
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
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Remove_many_equal_elements() 
        {
            try
            {
                Node n1 = new(55);
                Node n2 = new(56);
                n1.next = n2;

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(57));
                s_list2.AddInTail(new Node(59));

                bool result = s_list2.Remove(n2.value);
                Assert.IsTrue(result);
                Assert.AreEqual(3, s_list2.Count());
                Assert.AreEqual(55, s_list2.head.value);
                Assert.AreEqual(59, s_list2.tail.value);
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
        public void LinkedList_Remove_many_first_element()
        {
            try
            {
                Node n1 = new(55);
                Node n2 = new(56);
                n1.next = n2;

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(57));
                s_list2.AddInTail(new Node(59));

                bool result = s_list2.Remove(n1.value);
                Assert.IsTrue(result);
                Assert.AreEqual(3, s_list2.Count());
                Assert.AreEqual(56, s_list2.head.value);
                Assert.AreEqual(59, s_list2.tail.value);
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
                Console.WriteLine("TEST \"LinkedList_many_first_element\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Remove_many_last_element()
        {
            try
            {
                Node n1 = new(55);
                Node n2 = new(56);
                n1.next = n2;

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(57));
                s_list2.AddInTail(new Node(59));

                bool result = s_list2.Remove(59);
                Assert.IsTrue(result);
                Assert.AreEqual(3, s_list2.Count());
                Assert.AreEqual(55, s_list2.head.value);
                Assert.AreEqual(57, s_list2.tail.value);
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
                Console.WriteLine("TEST \"LinkedList_Remove_last_element\" PASSED");
            }
        }
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Remove_many_equal_elements2() 
        {
            try
            {
                Node n1 = new(55);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(55));

                bool result = s_list2.Remove(n2.value);
                Assert.IsTrue(result);
                Assert.AreEqual(3, s_list2.Count());
                Assert.AreEqual(55, s_list2.head.value);
                Assert.AreEqual(55, s_list2.tail.value);
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

                LinkedList s_list2 = new LinkedList();
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
        public void LinkedList_RemoveAll_many_equal_elements_not_exist3() 
        {
            try
            {
                Node n1 = new(55);
                Node n2 = new(55);
                n1.next = n2;

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(55));
                s_list2.AddInTail(new Node(55));

                s_list2.RemoveAll(56);

                Assert.AreEqual(4, s_list2.Count());
                Assert.AreEqual(55, s_list2.head.value);
                Assert.AreEqual(55, s_list2.tail.value);
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
        public void LinkedList_RemoveAll_null() 
        {
            try
            {
                LinkedList s_list2 = new LinkedList();

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
        public void LinkedList_RemoveAll_from_first()
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

                List<int> print_nodes = new List<int>();

                s_list2.RemoveAll(n1.value);

                Assert.AreEqual(3, s_list2.Count());
                Assert.AreEqual(55, s_list2.head.value);
                Assert.AreEqual(55, s_list2.tail.value);
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

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                List<int> print_nodes = new List<int>();

                s_list2.RemoveAll(n2.value);
                
                Assert.AreEqual(2, s_list2.Count());
                Assert.AreEqual(12, s_list2.head.value);
                Assert.AreEqual(128, s_list2.tail.value);
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

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(new Node(128));
                s_list2.AddInTail(new Node(55));

                List<int> print_nodes = new List<int>();

                s_list2.RemoveAll(55);

                Assert.AreEqual(3, s_list2.Count());
                Assert.AreEqual(12, s_list2.head.value);
                Assert.AreEqual(128, s_list2.tail.value);
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

                LinkedList s_list2 = new LinkedList();
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
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Clear_null() 
        {
            try
            {
                LinkedList s_list2 = new LinkedList();

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

                LinkedList s_list2 = new LinkedList();
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
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_Count_null() 
        {
            try
            {
                LinkedList s_list2 = new LinkedList();

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

                LinkedList s_list2 = new LinkedList();
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
        [TestMethod]
        [TestCategory("АСД 1-й курс")]
        public void LinkedList_InsertAfter_empty_first() 
        {
            try
            {
                LinkedList s_list2 = new LinkedList();
                Node n1 = new(12);
                Node n2 = new(25);

                s_list2.InsertAfter(null,n1);
                //s_list2.InsertAfter(n1, n2);

                Assert.AreEqual(1, s_list2.Count());
                Assert.AreEqual(s_list2.head.value, 12);
                //Assert.AreEqual(s_list2.tail.value, 12); ??
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
                LinkedList s_list2 = new LinkedList();
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
                LinkedList s_list2 = new LinkedList();
                Node n1 = new(12);
                Node n2 = new(25);

                s_list2.InsertAfter(null, n1);
               // Assert.AreEqual(1, s_list2.Count());
                Assert.AreEqual(s_list2.head.value, 12);
                //Assert.AreEqual(s_list2.tail.value, 12);

                s_list2.InsertAfter(n1, n2);
                //Assert.AreEqual(2, s_list2.Count());
                Assert.AreEqual(s_list2.head.value, 12);
                //Assert.AreEqual(s_list2.tail.value, 25); ??
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
        public void LinkedList_InsertAfter_not_empty_middle() 
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
        public void LinkedList_InsertAfter_not_empty_middle2() 
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

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                s_list2.AddInTail(n2);
                s_list2.AddInTail(n3);
                s_list2.AddInTail(n4);

                s_list2.InsertAfter(n4, nn);

                Assert.AreEqual(5, s_list2.Count());
                Assert.AreEqual(12, s_list2.head);
                Assert.AreEqual(111, s_list2.tail);
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

                LinkedList s_list2 = new LinkedList();
                s_list2.AddInTail(n1);
                
                s_list2.InsertAfter(n1, nn);

                Assert.AreEqual(2, s_list2.Count());
                Assert.AreEqual(12, s_list2.head);
                Assert.AreEqual(111, s_list2.tail);
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
        public void LinkedList_Equal_Lenght_null() 
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
        public void LinkedList_Equal_Lenght_notnull() 
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
