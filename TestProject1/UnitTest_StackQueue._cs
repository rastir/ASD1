using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using System.Collections.Generic;
//using System.Linq;
using AlgorithmsDataStructures;
namespace TestProject
{
    ///<summary> 
    ///Тесты для занятия "Очередь" задания "реализовать очередь при помощи двух стэков"
    /// </summary>
    [TestClass]
    public class AlgorithmsDataStructures
    {
        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("Тесты")]
        public void Stack_Queue()
        {
            try
            {
                Stack<string> stackQueue = new Stack<string>();

                stackQueue.Push("a");
                Assert.AreEqual(stackQueue.Peek(), "a");
                Assert.AreEqual(stackQueue.Count(), 1);

                stackQueue.Push("b");
                Assert.AreEqual(stackQueue.Peek(), "a");
                Assert.AreEqual(stackQueue.Count(), 2);

                stackQueue.Push("c");
                Assert.AreEqual(stackQueue.Peek(), "a");
                Assert.AreEqual(stackQueue.Count(), 3);

                stackQueue.Push("d");
                Assert.AreEqual(stackQueue.Peek(), "a");
                Assert.AreEqual(stackQueue.Count(), 4);

                Assert.AreEqual(stackQueue.Pop(), "a");
                Assert.AreEqual(stackQueue.Peek(), "b");
                Assert.AreEqual(stackQueue.Count(), 3);

                Assert.AreEqual(stackQueue.Pop(), "b");
                Assert.AreEqual(stackQueue.Peek(), "c");
                Assert.AreEqual(stackQueue.Count(), 2);

                Assert.AreEqual(stackQueue.Pop(), "c");
                Assert.AreEqual(stackQueue.Peek(), "d");
                Assert.AreEqual(stackQueue.Count(), 1);

                Assert.AreEqual(stackQueue.Pop(), "d");
                Assert.AreEqual(stackQueue.Peek(), null);
                Assert.AreEqual(stackQueue.Count(), 0);

                Assert.AreEqual(stackQueue.Pop(), null);
                Assert.AreEqual(stackQueue.Count(), 0);
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
    }
}
