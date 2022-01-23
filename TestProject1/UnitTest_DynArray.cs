using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using AlgorithmsDataStructures;

namespace TestProject
{
    ///<summary> 
    ///Тесты для задания "Динамические массивы"
    /// </summary>
    [TestClass]
    public class AlgorithmsDataStructures
    {
        /// <summary>
        /// Вставка элемента, когда в итоге размер буфера не превышен (проверьте также размер буфера);
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("проверка работы метода Insert()")]
        public void DynArray_Insert_buffer_size_not_exceeded()
        {
            try
            {

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
        /// <summary>
        /// Вставка элемента, когда в результате превышен размер буфера (проверьте также корректное изменение размера буфера);
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("проверка работы метода Insert()")]
        public void DynArray_Insert_buffer_size_exceeded()
        {
            try
            {

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
        /// <summary>
        /// Попытка вставки элемента в недопустимую позицию
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("проверка работы метода Insert()")]
        public void DynArray_Insert_invalid_position()
        {
            try
            {

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
        /// <summary>
        /// удаление элемента, когда в результате размер буфера остаётся прежним (проверьте также размер буфера);
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("проверка работы метода Remove()")]
        public void DynArray_Remove_buffer_size_remains_the_same()
        {
            try
            {
             
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
        /// <summary>
        /// Удаление элемента, когда в результате понижается размер буфера (проверьте также корректное изменение размера буфера);
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("проверка работы метода Remove()")]
        public void DynArray_Remove_buffer_size_decrease()
        {
            try
            {

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
        /// <summary>
        /// попытка удаления элемента в недопустимой позиции
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("проверка работы метода Remove()")]
        public void DynArray_Remove_invalid_position()
        {
            try
            {

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