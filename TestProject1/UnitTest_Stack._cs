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
                Stack<string> Stack = new Stack<string>();
                Assert.AreEqual(Stack.Size(), 0);
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
                Stack<string> Stack = new Stack<string>();

                Stack.Push("Kate");
                Stack.Push("Sam");
                Stack.Push("Alice");
                Stack.Push("Tom");

                Assert.AreEqual(Stack.Count, 4);
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
                Stack<string> Stack = new();

                Assert.AreEqual(Stack.Size(), 0);
                // добавляем четыре элемента
                Stack.Push("Kate");

                Assert.AreEqual(Stack.Count, 1);
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
                Stack<string> Stack = new Stack<string>();

                Assert.AreEqual(Stack.Count, 0);
                // извлекаем один элемент
                Assert.AreEqual(Stack.Pop(), null);
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
                Stack<string> Stack = new Stack<string>();
                Assert.AreEqual(Stack.Size(), 0);

                // добавляем четыре элемента
                Stack.Push("Kate");
                Stack.Push("Sam");
                Stack.Push("Alice");
                Stack.Push("Tom");

                Assert.AreEqual(Stack.Count, 4);
                // извлекаем один элемент
                Assert.AreEqual(Stack.Pop(), "Tom");
                Assert.AreEqual(Stack.Size(), 3);
                Assert.AreEqual(Stack.Count, 3);

                Assert.AreEqual(Stack.Pop(), "Alice");
                Assert.AreEqual(Stack.Size(), 2);
                Assert.AreEqual(Stack.Count, 2);

                Assert.AreEqual(Stack.Pop(), "Sam");
                Assert.AreEqual(Stack.Size(), 1);
                Assert.AreEqual(Stack.Count, 1);

                Assert.AreEqual(Stack.Pop(), "Kate");
                Assert.AreEqual(Stack.Size(), 0);
                Assert.AreEqual(Stack.Count, 0);
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
        [TestCategory("Некорректная операция pop() для стека с одним элементом")]
        public void Stack_pop_one_element()
        {
            try
            {
                Stack<string> Stack = new Stack<string>();
                Assert.AreEqual(Stack.Size(), 0);

                Stack.Push("Kate");
                Assert.AreEqual(Stack.Pop(), "Kate");

                Assert.AreEqual(Stack.Size(), 0);
                Assert.AreEqual(Stack.Count, 0);
                // извлекаем один элемент
                // просто получаем верхушку стека без извлечения
                Assert.AreEqual(Stack.Peek(), null);
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
                Stack<string> Stack = new Stack<string>();
                Stack<string> Stack2 = new Stack<string>();
                Assert.AreEqual(Stack.Size(), 0);
                Assert.AreEqual(Stack2.Size(), 0);

                // добавляем четыре элемента
                Stack.Push("Kate");
                Stack.Push("Sam");
                Stack.Push("Alice");
                Stack.Push("Tom");

                // извлекаем один элемент
                Assert.AreEqual(Stack.Pop(), "Tom");
                // просто получаем верхушку стека без извлечения
                Assert.AreEqual(Stack.Peek(), "Alice");
                Assert.AreEqual(Stack2.Peek(), null);

                Assert.AreEqual(Stack.Size(), 3);
                Assert.AreEqual(Stack2.Size(), 0);
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
                Stack<string> Stack = new Stack<string>();
                Stack<string> Stack2 = new Stack<string>();
                Assert.AreEqual(Stack.Size(), 0);
                Assert.AreEqual(Stack2.Size(), 0);

                // добавляем четыре элемента
                Stack.Push(null);
                Stack.Push("Sam");
                Stack.Push("Alice");
                Stack.Push("Tom");

                // извлекаем один элемент
                Assert.AreEqual(Stack.Pop(), "Tom");
                // просто получаем верхушку стека без извлечения
                Assert.AreEqual(Stack.Peek(), "Alice");
                Assert.AreEqual(Stack2.Peek(), null);

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
        public void Stack_Brackets_array()
        {
            try
            {
                string brackets = "(()((())()))";
                Stack<string> Stackk = new Stack<string>();

                Assert.AreEqual(Stackk.Brackets(brackets), true);

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
        public void Stack_Brackets_stack()
        {
            try
            {
                string brackets = "(()((())()))";
                Stack<string> Stackk = new Stack<string>();

                Stackk.Brackets(brackets);
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
        public void Stack_Brackets_stack_not_balance()
        {
            try
            {
                string brackets = "(()((())()))";
                string brackets2 = "))";
                string brackets3 = "())(";
                string brackets4 = "(()()(()";
                string brackets5 = "))((";
                string brackets6 = "(()()(()))";

                Stack<string> Stackk = new Stack<string>();
                Stack<string> Stackk2 = new Stack<string>();
                Stack<string> Stackk3 = new Stack<string>();
                Stack<string> Stackk4 = new Stack<string>();
                Stack<string> Stackk5 = new Stack<string>();
                Stack<string> Stackk6 = new Stack<string>();

                Assert.AreEqual(Stackk.Brackets(brackets),true);
                Assert.AreEqual(Stackk2.Brackets(brackets2), false);
                Assert.AreEqual(Stackk3.Brackets(brackets3), false);
                Assert.AreEqual(Stackk4.Brackets(brackets4), false);
                Assert.AreEqual(Stackk5.Brackets(brackets5), false);
                Assert.AreEqual(Stackk6.Brackets(brackets6), true);
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
        public void Stack2_push_()
        {
            try
            {
                Stack<string> Stack = new Stack<string>();

                Stack.Push("Kate");
                Stack.Push("Sam");
                Stack.Push("Alice");
                Stack.Push("Tom");

                Assert.AreEqual(Stack.Count, 4);

                Assert.AreEqual(Stack.Pop(), "Tom");
                Assert.AreEqual(Stack.Pop(), "Alice");
                Assert.AreEqual(Stack.Pop(), "Sam");
                Assert.AreEqual(Stack.Pop(), "Kate");
                Assert.AreEqual(Stack.Pop(), null);
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