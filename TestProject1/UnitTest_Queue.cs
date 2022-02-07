using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using System.Collections.Generic;
//using System.Linq;
using AlgorithmsDataStructures;
namespace TestProject
{
    ///<summary> 
    ///Тесты для задания "Очередь"
    /// </summary>
    [TestClass]
    public class AlgorithmsDataStructures
    {
        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("Тесты")]
        public void Queue_size_empty_and_not_empty()
        {
            try
            {
                Queue<string> queue = new Queue<string>();
                Assert.AreEqual(queue.Size(), 0);
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"\" PASSED");
            }
        }
        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("Тесты")]
        public void Queue_enqueue()
        {
            try
            {
                Queue<string> queue = new Queue<string>();
                Assert.AreEqual(queue.Size(), 0);

                queue.Enqueue("333");
                Assert.AreEqual(queue.Size(), 1);
                
                queue.Enqueue("4");
                Assert.AreEqual(queue.Size(), 2);

                queue.Enqueue("555");
                Assert.AreEqual(queue.Size(), 3);
                
                Assert.AreEqual(queue.Dequeue(), "333");
                Assert.AreEqual(queue.Size(), 2);

                Assert.AreEqual(queue.Dequeue(), "4");
                Assert.AreEqual(queue.Size(), 1);
                
                Assert.AreEqual(queue.Dequeue(), "555");
                Assert.AreEqual(queue.Size(), 0);

                Assert.AreEqual(queue.Dequeue(), null);
                Assert.AreEqual(queue.Size(), 0);
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"\" PASSED");
            }
        }
        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("Тесты")]
        public void Queue_enqueue_dequeue()
        {
            try
            {
                Queue<string> queue = new Queue<string>();
                Assert.AreEqual(queue.Size(), 0);

                queue.Enqueue("333");
                Assert.AreEqual(queue.Size(), 1);

                queue.Enqueue("4");
                Assert.AreEqual(queue.Size(), 2);

                queue.Enqueue("555");
                Assert.AreEqual(queue.Size(), 3);

                while (queue.Size() > 0)
                    queue.Dequeue();

                Assert.AreEqual(queue.Size(), 0);
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"\" PASSED");
            }
        }
        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("Тесты")]
        public void Queue_dequeue_empty()
        {
            try
            {
                Queue<string> queue = new Queue<string>();
                Assert.AreEqual(queue.Size(), 0);

                Assert.AreEqual(queue.Dequeue(), null);
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.Fail();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("TEST \"\" PASSED");
            }
        }


        //[TestMethod]
        ////[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //[TestCategory("пробуем библиотеку из Framework")]
        //public void Stack_push_empty()
        //{
        //    try
        //    {
        //        Stack<string> Stack = new();
        //        Stack.Push(null);
        //        Stack.Count();
        //        Stack.Push("Kate4");
        //        Stack.Push("Kate3");
        //        Stack.Push("Kate2");
        //        Stack.Push("Kate1");
        //        Stack.Peek();
        //        Stack.Peek();
        //        Stack.Pop();
        //        Stack.Pop();

        //        Assert.AreEqual(Stack.Peek, "333");
        //        // добавляем четыре элемента
        //        Stack.Push("Kate");

        //        Assert.AreEqual(Stack.Count, 1);
        //    }
        //    catch (IndexOutOfRangeException e)
        //    {
        //        Assert.Fail();
        //    }
        //    catch (NullReferenceException e)
        //    {
        //        Console.WriteLine(e.Message + "TEST ERROR");
        //        throw new ArgumentNullException("parameter is null.", e);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("TEST \"\" PASSED");
        //    }
        //}

    }
}