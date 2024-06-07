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
        public void TestCase_01_11_Duong()
        {
            // Tạo một đối tượng StringReverse với chuỗi "hello".
            reverser = new StringReverse("hello");

            // Xác định kết quả mong đợi sau khi đảo ngược chuỗi.
            string expected = "olleh";

            // Đảo ngược chuỗi bằng phương thức ReverseString().
            string actual = reverser.ReverseString();

            // Khẳng định rằng kết quả thực tế khớp với kết quả mong đợi.
            Assert.AreEqual(expected, actual);

        }

        // TC02 Đảo ngược chuỗi có khoảng trắng.
        [TestMethod]
        public void TestCase_02_11_Duong()
        {
            // Tạo một đối tượng StringReverse với chuỗi "hello world".
            reverser = new StringReverse("hello world");

            // Xác định kết quả mong đợi sau khi đảo ngược chuỗi.
            string expected = "dlrow olleh";

            // Đảo ngược chuỗi bằng phương thức ReverseString().
            string actual = reverser.ReverseString();

            // Khẳng định rằng kết quả thực tế khớp với kết quả mong đợi.
            Assert.AreEqual(expected, actual);

        }

        // TC03 Đảo ngược chuỗi rỗng.
        [TestMethod]
        public void TestCase_03_11_Duong()
        {
            // Tạo một đối tượng StringReverse với một khoảng trắng.
            reverser = new StringReverse(" ");

            // Xác định kết quả mong đợi sau khi đảo ngược chuỗi.
            string expected = " ";

            // Đảo ngược chuỗi bằng phương thức ReverseString().
            string actual = reverser.ReverseString();

            // Khẳng định rằng kết quả thực tế khớp với kết quả mong đợi.
            Assert.AreEqual(expected, actual);

        }

        // TC04 Đảo ngược chuỗi có ký tự đặc biệt.
        [TestMethod]
        public void TestCase_04_11_Duong()
        {
            // Tạo một đối tượng StringReverse với chuỗi "123@abc!".
            reverser = new StringReverse("123@abc!");

            // Xác định kết quả mong đợi sau khi đảo ngược chuỗi.
            string expected = "!cba@321";

            // Đảo ngược chuỗi bằng phương thức ReverseString().
            string actual = reverser.ReverseString();

            // Khẳng định rằng kết quả thực tế khớp với kết quả mong đợi.
            Assert.AreEqual(expected, actual);

        }

        // Test với file CSV
        public TestContext TestContext { get; set; }
        // Chỉ định nguồn dữ liệu và phương thức truy cập cho phương thức kiểm thử.
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestDataString.csv", "TestDataString#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Test_Data_Source_11_Duong()
        {
            // Trích xuất giá trị đầu vào từ hàng hiện tại của nguồn dữ liệu và chuyển đổi thành chuỗi.
            string input = TestContext.DataRow[0].ToString();

            // Trích xuất kết quả mong đợi từ hàng hiện tại của nguồn dữ liệu và chuyển đổi thành chuỗi.
            string expected = TestContext.DataRow[1].ToString();

            // Tạo một đối tượng StringReverse với giá trị đầu vào trích xuất được.
            reverser = new StringReverse(input);

            // Đảo ngược chuỗi và lấy kết quả thực tế.
            string actual = reverser.ReverseString();

            // Khẳng định rằng kết quả thực tế khớp với kết quả mong đợi.
            Assert.AreEqual(expected, actual);
        }
    }
}
