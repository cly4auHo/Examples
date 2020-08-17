using AssertSamples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AssertSamples_.Tests
{
    [TestClass]
    public class ExpectingExceptions
    {
        // Инициализирует новый экземпляр класса ExpectedExceptionAttribute 
        // ожидаемого типа c сообщением для включения, когда тест не создает исключение.
        // ExpectedException -  тест будет успешным если в процессе выполнения будет 
        // выброшено исключение с типом ArgumentNullException
        [ExpectedException(typeof(ArgumentNullException), "Exception was not thrown")]
        [TestMethod]
        public void MyClass_SayHello_Exception()
        {
            MyClass instance = new MyClass();

            instance.SayHello(null);
        }

        /// <summary>
        /// Проверяет указанные значения на равенство и создает исключение, если два значения
        ///  не равны.
        /// </summary>
        [TestMethod]
        public void MyClass_SayHello_ReturnDmitriy()
        {
            // arrange
            MyClass instance = new MyClass();
            string expected = "Hello Dmitriy";

            // act
            string actual = instance.SayHello("Dmitriy");

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
