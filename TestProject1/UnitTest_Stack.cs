using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using System.Collections.Generic;
using AlgorithmsDataStructures;
//using Stack = AlgorithmsDataStructures.Stack;

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
        [TestCategory("Некорректное создание пустого динамического массива (count != 0 или capacity != 16)")]
        public void Stack_size()
        {
            try
            {
                Stack<string> stack = new Stack<string>(8);
                Stack<int> stack2 = new Stack<int>()
                {
                    n = 1
                };
                Assert.AreEqual(stack.Size(), 8);
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
    }
}