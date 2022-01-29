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
        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("Некорректное создание пустого динамического массива (count != 0 или capacity != 16)")]
        public void DynArray_incorrect_new_array()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 1,
                    capacity = 2
                };
                Assert.AreEqual(dynArray.count, 1);
                Assert.AreEqual(dynArray.capacity, 2);
                Assert.AreEqual(dynArray.GetItem(1), 0);
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
        /// Вставка элемента, когда в итоге размер буфера не превышен (проверьте также размер буфера);
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        [TestCategory("Исключение при вставке в НЕпустой массив")]
        public void DynArray_Insert_in_not_empty_array()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 32
                };
                for (int i = 1; i <= 15; i++)
                {
                    dynArray.Append(i);
                    //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Append(i));
                }
                dynArray.Insert(1, 1);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
                Assert.AreEqual(dynArray.count, 16);
                Assert.AreEqual(dynArray.capacity, 32);
                Assert.AreEqual(dynArray.GetItem(1), 1);
                Assert.AreEqual(dynArray.GetItem(16), 15);
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
        [TestCategory("Исключение при вставке в пустой массив")]
        public void DynArray_Insert_in_empty_array()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 32
                };
                dynArray.Insert(555, 0);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
                Assert.AreEqual(dynArray.count, 1);
                Assert.AreEqual(dynArray.capacity, 32);
                Assert.AreEqual(dynArray.GetItem(1), 555);
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
        [TestCategory("проверка работы метода Insert()")]
        public void DynArray_Insert_buffer_size_not_exceeded()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 32
                };
                for (int i = 1; i <= 16; i++)
                {
                    dynArray.Append(i);
                    //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Append(i));
                }
                dynArray.Insert(555, 15);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
                Assert.AreEqual(dynArray.count, 17);
                Assert.AreEqual(dynArray.capacity, 32);
                Assert.AreEqual(dynArray.GetItem(2), 2);
                Assert.AreEqual(dynArray.GetItem(15), 555);
                Assert.AreEqual(dynArray.GetItem(16), 15);
                Assert.AreEqual(dynArray.GetItem(17), 16);
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
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 16
                };
                for (int i = 1; i <= 15; i++)
                {
                    dynArray.Append(i);
                    //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Append(i));
                }
                dynArray.Append(3333);
                dynArray.Insert(555, 1);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
                Assert.AreEqual(dynArray.count, 17);
                Assert.AreEqual(dynArray.capacity, 32);
                Assert.AreEqual(dynArray.GetItem(1), 555);
                Assert.AreEqual(dynArray.GetItem(3), 2);
                Assert.AreEqual(dynArray.GetItem(2), 1);
                Assert.AreEqual(dynArray.GetItem(16), 15);
                Assert.AreEqual(dynArray.GetItem(17), 3333);
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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("проверка работы метода Insert()")]
        public void DynArray_Insert_buffer_size_exceeded2()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 2
                };
                for (int i = 1; i <= 16; i++)
                {
                    dynArray.Append(i);
                    //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Append(i));
                }
                dynArray.Insert(3333, 15);
                dynArray.Insert(4444, 16);
                dynArray.Insert(4444, 19);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
                Assert.AreEqual(dynArray.count, 18);
                Assert.AreEqual(dynArray.capacity, 32);
                Assert.AreEqual(dynArray.GetItem(16), 3333);
                Assert.AreEqual(dynArray.GetItem(17), 4444);
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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("проверка работы метода Insert()")]
        public void DynArray_Insert_invalid_position()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 16
                };
                dynArray.Insert(1999, 333);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Insert(1999, 0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
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
        /// Попытка вставки элемента в нулевую позицию
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("проверка работы метода Insert()")]
        public void DynArray_Insert_zero_position_empty_array()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 16
                };
                dynArray.Insert(1999, 0);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Insert(1999, 0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
                Assert.AreEqual(dynArray.count, 1);
                Assert.AreEqual(dynArray.capacity, 16);
                Assert.AreEqual(dynArray.GetItem(1), 1999);
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
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("Исключение при вставке в непустой массив без изменения размера буфера")]
        public void DynArray_Inserrt_not_empty_not_change_array()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 2
                };
                dynArray.MakeArray(2);
                for (int i = 1; i <= 5; i++)
                {
                    dynArray.Append(i);
                    //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Append(i));
                }
                dynArray.Insert(555, 1);
                Assert.AreEqual(dynArray.count, 6);
                Assert.AreEqual(dynArray.capacity, 8);
                Assert.AreEqual((int)dynArray.GetItem(1), 555);
                Assert.AreEqual((int)dynArray.GetItem(2), 1);
                Assert.AreEqual((int)dynArray.GetItem(6), 5);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
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
        [TestCategory("Исключение при вставке в хвост, когда в массиве один элемент")]
        public void DynArray_Insert_into_tail_when_one_element()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 2
                };
                dynArray.MakeArray(2);
                dynArray.Append(1);
                dynArray.Insert(555, 1);
                Assert.AreEqual(dynArray.count, 2);
                Assert.AreEqual(dynArray.capacity, 2);
                Assert.AreEqual((int)dynArray.GetItem(1), 1);
                Assert.AreEqual((int)dynArray.GetItem(2), 555);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
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
        [TestCategory("проверка работы метода Insert()")]
        public void DynArray_Remove_invalid_position()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0
                };
                dynArray.Remove(0);
                dynArray.MakeArray(0);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
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
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("проверка работы метода Remove()")]
        public void DynArray_Remove_buffer_size_remains_the_same()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 16
                };
                for (int i = 1; i <= 5; i++)
                {
                    dynArray.Append(i);
                    //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Append(i));
                }
                dynArray.Remove(1);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
                Assert.AreEqual(dynArray.count, 4);
                Assert.AreEqual(dynArray.capacity, 16);
                Assert.AreEqual(dynArray.GetItem(1), 2);
                Assert.AreEqual(dynArray.GetItem(4), 5);
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
        [TestCategory("проверка работы метода Remove()")]
        public void DynArray_Remove_buffer_size_remains_the_same2()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 16
                };
                for (int i = 1; i <= 5; i++)
                {
                    dynArray.Append(i);
                    //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Append(i));
                }
                dynArray.Remove(5);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
                Assert.AreEqual(dynArray.count, 4);
                Assert.AreEqual(dynArray.capacity, 16);
                Assert.AreEqual(dynArray.GetItem(1), 1);
                Assert.AreEqual(dynArray.GetItem(4), 4);
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
        [TestCategory("проверка работы метода Remove()")]
        public void DynArray_Remove_middle_not_empty_array()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 16
                };
                for (int i = 1; i <= 5; i++)
                {
                    dynArray.Append(i);
                    //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Append(i));
                }
                dynArray.Remove(3);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
                Assert.AreEqual(dynArray.count, 4);
                Assert.AreEqual(dynArray.capacity, 16);
                Assert.AreEqual(dynArray.GetItem(1), 1);
                Assert.AreEqual(dynArray.GetItem(3), 4);
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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("проверка работы метода Remove()")]
        public void DynArray_Remove_buffer_size_decrease()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0,
                    capacity = 32
                };
                for (int i = 1; i <= 16; i++)
                {
                    dynArray.Append(i);
                    //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Append(i));
                }
                dynArray.Remove(16);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
                Assert.AreEqual(dynArray.count, 15);
                Assert.AreEqual(dynArray.capacity, 21);
                Assert.AreEqual(dynArray.GetItem(1), 1);
                Assert.AreEqual(dynArray.GetItem(16), default);
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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestCategory("проверка работы метода Remove()")]
        public void DynArray_Remove_invalid_position2()
        {
            try
            {
                // создаем объект класса согласно конструктору и полям
                DynArray<int> dynArray = new()
                {
                    count = 0
                };
                for (int i = 0; i < 5; i++)
                    dynArray.Append(i);
                dynArray.MakeArray(0);
                dynArray.Append(5);
                dynArray.Remove(20);
                //Assert.ThrowsException<ArgumentOutOfRangeException>(Exception.Equals());
                //AssertFailedException.Equals(item, ex);
            }
            catch (IndexOutOfRangeException e)
            {
                //Assert.ThrowsException<IndexOutOfRangeException>();
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
        [TestCategory("Исключение при вызове remove(0)")]
        public void DynArray_Remove_from_empty_array()
        {
            try
            {
                DynArray<int> dynArray = new()
                {
                    count = 0
                    //capacity = 32
                };

                dynArray.Append(0);
                dynArray.Remove(0);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => dynArray.Remove(0));
                //Assert.ThrowsException<System.ArgumentNullException>(() => dynArray.Remove(0));
                Assert.AreEqual(dynArray.count, 0);
                Assert.AreEqual(dynArray.capacity, 16);

                //Assert.AreEqual(dynArray.GetItem(0), 555);
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