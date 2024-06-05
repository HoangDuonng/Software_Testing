using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulation;
using System;

namespace StringReverserTester
{
    [TestClass]
    public class UnitTest1
    {
        private StringReverse reverser;

        [TestInitialize]
        public void SetUp()
        {
            reverser = new StringReverse("");
        }

        // TC01 Đảo ngược chuỗi không chứa khoảng trắng.
        [TestMethod]
        public void TestCase_1_11_HoangNongDuong()
        {
            reverser = new StringReverse("hello");
            string expected = "olleh";
            string actual = reverser.ReverseString();
            Assert.AreEqual(expected, actual);
        }

        // TC02 Đảo ngược chuỗi có khoảng trắng.
        [TestMethod]
        public void TestCase_2_11_HoangNongDuong()
        {
            reverser = new StringReverse("hello world");
            string expected = "dlrow olleh";
            string actual = reverser.ReverseString();
            Assert.AreEqual(expected, actual);
        }

        // TC03 Đảo ngược chuỗi rỗng.
        [TestMethod]
        public void TestCase_3_11_HoangNongDuong()
        {
            reverser = new StringReverse(" ");
            string expected = " ";
            string actual = reverser.ReverseString();
            Assert.AreEqual(expected, actual);
        }

        // TC04 Đảo ngược chuỗi có ký tự đặc biệt.
        [TestMethod]
        public void TestCase_4_11_HoangNongDuong()
        {
            reverser = new StringReverse("123@abc!");
            string expected = "!cba@321";
            string actual = reverser.ReverseString();
            Assert.AreEqual(expected, actual);
        }

        // Test với file CSV
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestDataString.csv", "TestDataString#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Test_Data_Source_11_HoangNongDuong()
        {
            string input = TestContext.DataRow[0].ToString();
            string expected = TestContext.DataRow[1].ToString();
            reverser = new StringReverse(input);
            string actual = reverser.ReverseString();
            Assert.AreEqual(expected, actual);
        }
    }
}
