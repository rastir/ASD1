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
        public void Stack_size_empty_and_not_empty()
        {
            try
            {
                Stack<string> stack = new Stack<string>();
                Stack<string> stack2 = new Stack<string>(5);
                Assert.AreEqual(stack.Size(), 0);
                Assert.AreEqual(stack2.Size(), 5);
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
        public void Stack_push_not_empty()
        {
            try
            {
                Stack<string> stack = new Stack<string>(5);

                stack.Push("Kate");
                stack.Push("Sam");
                stack.Push("Alice");
                stack.Push("Tom");

                Assert.AreEqual(stack.Count, 4);
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
        [TestCategory("Исключение в операции push() в пустой стек")]
        public void Stack_push_empty()
        {
            try
            {
                Stack<string> stack = new();

                Assert.AreEqual(stack.Size(), 0);
                // добавляем четыре элемента
                stack.Push("Kate");

                Assert.AreEqual(stack.Count, 1);
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
        public void Stack_pop_empty()
        {
            try
            {
                Stack<string> stack = new Stack<string>();

                Assert.AreEqual(stack.Count, 0);
                // извлекаем один элемент
                Assert.AreEqual(stack.Pop(), null);
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
        public void Stack_pop_not_empty()
        {
            try
            {
                Stack<string> stack = new Stack<string>();
                Assert.AreEqual(stack.Size(), 0);

                // добавляем четыре элемента
                stack.Push("Kate");
                stack.Push("Sam");
                stack.Push("Alice");
                stack.Push("Tom");

                Assert.AreEqual(stack.Count, 4);
                // извлекаем один элемент
                Assert.AreEqual(stack.Pop(), "Tom");
                // просто получаем верхушку стека без извлечения
                Assert.AreEqual(stack.Peek(), "Alice");
                Assert.AreEqual(stack.Peek(), "Alice");

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
        public void Stack_Peek_empty_and_not_empty()
        {
            try
            {
                Stack<string> stack = new Stack<string>();
                Stack<string> stack2 = new Stack<string>();
                Assert.AreEqual(stack.Size(), 0);
                Assert.AreEqual(stack2.Size(), 0);

                // добавляем четыре элемента
                stack.Push("Kate");
                stack.Push("Sam");
                stack.Push("Alice");
                stack.Push("Tom");

                // извлекаем один элемент
                Assert.AreEqual(stack.Pop(), "Tom");
                // просто получаем верхушку стека без извлечения
                Assert.AreEqual(stack.Peek(), "Alice");
                Assert.AreEqual(stack2.Peek(), null);

                Assert.AreEqual(stack.Size(), 4);
                Assert.AreEqual(stack2.Size(), 0);
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
        public void Stack_Push_null()
        {
            try
            {
                Stack<string> stack = new Stack<string>();
                Stack<string> stack2 = new Stack<string>();
                Stack<string> stack3 = new Stack<string>(8);
                Assert.AreEqual(stack.Size(), 0);
                Assert.AreEqual(stack2.Size(), 0);

                // добавляем четыре элемента
                stack.Push(null);
                stack.Push("Sam");
                stack.Push("Alice");
                stack.Push("Tom");

                stack3.Push("Sam");
                stack3.Push("Ssss");
                // извлекаем один элемент
                Assert.AreEqual(stack.Pop(), "Tom");
                // просто получаем верхушку стека без извлечения
                Assert.AreEqual(stack.Peek(), "Alice");
                Assert.AreEqual(stack2.Peek(), null);

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
        //        Stack<string> stack = new();
        //        stack.Push(null);
        //        stack.Count();
        //        stack.Push("Kate4");
        //        stack.Push("Kate3");
        //        stack.Push("Kate2");
        //        stack.Push("Kate1");
        //        stack.Peek();
        //        stack.Peek();
        //        stack.Pop();
        //        stack.Pop();

        //        Assert.AreEqual(stack.Peek, "333");
        //        // добавляем четыре элемента
        //        stack.Push("Kate");

        //        Assert.AreEqual(stack.Count, 1);
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