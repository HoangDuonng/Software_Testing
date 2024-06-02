using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Factorial;


namespace FactorialTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation a;
        [TestInitialize] 
        public void SetUp()
        {
            a = new Calculation(5);
        }

        [TestMethod] 
        public void TestCase_1_11_HoangNongDuong()
        {
            int expected, actual;
            expected = 1;
            actual = a.Factorial(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase_2_11_HoangNongDuong()
        {
            int expected, actual;
            expected = 120;
            actual = a.Factorial(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase_3_11_HoangNongDuong()
        {
            int expected, actual;
            expected = 3628800;
            actual = a.Factorial(10);
            Assert.AreEqual(expected, actual);
        }

        // Trường hợp ngoại lệ nếu người dùng nhập số âm
        [TestMethod]
        public void TestCase_4_11_HoangNongDuong()
        {
            Assert.ThrowsException<ArgumentException>(() => a.Factorial(-1));
        }

        // Trường hợp ngoại lệ nếu người dùng nhập ký tự chuỗi
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestCase_5_11_HoangNongDuong()
        {
            string input = "abc";
            int number = int.Parse(input);
            a.Factorial(number);
        }

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void Test_Data_Source_11_HoangNongDuong()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int expected = int.Parse(TestContext.DataRow[1].ToString());
            Calculation b = new Calculation(a);
            int actual = b.Factorial(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
