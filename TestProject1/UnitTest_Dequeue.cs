using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using System.Collections.Generic;
//using System.Linq;
using AlgorithmsDataStructures;
namespace TestProject
{
    ///<summary> 
    ///Тесты для задания "Стэк"
    /// </summary>
    [TestClass]
    public class AlgorithmsDataStructures
    {
        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("Тесты")]
        public void Dequeue_Addfront_Removefront()
        {
            try
            {
                Deque<string> dequeue = new Deque<string>();

                Assert.AreEqual(dequeue.Size(),0);

                dequeue.AddFront("1");
                Assert.AreEqual(dequeue.Size(), 1);

                dequeue.AddFront("2");
                Assert.AreEqual(dequeue.Size(), 2);

                Assert.AreEqual(dequeue.RemoveFront(), "2"); ;
                Assert.AreEqual(dequeue.Size(), 1);

                Assert.AreEqual(dequeue.RemoveFront(), "1"); ;
                Assert.AreEqual(dequeue.Size(), 0);

                Assert.AreEqual(dequeue.RemoveFront(), null); ;
                Assert.AreEqual(dequeue.Size(), 0);
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
        public void Dequeue_Addtail_Removetail()
        {
            try
            {
                Deque<string> dequeue = new Deque<string>();

                Assert.AreEqual(dequeue.Size(), 0);

                dequeue.AddTail("1");
                Assert.AreEqual(dequeue.Size(), 1);

                dequeue.AddTail("2");
                Assert.AreEqual(dequeue.Size(), 2);

                Assert.AreEqual(dequeue.RemoveTail(), "2"); ;
                Assert.AreEqual(dequeue.Size(), 1);

                Assert.AreEqual(dequeue.RemoveTail(), "1"); ;
                Assert.AreEqual(dequeue.Size(), 0);

                Assert.AreEqual(dequeue.RemoveTail(), null); ;
                Assert.AreEqual(dequeue.Size(), 0);
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