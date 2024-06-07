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
            a = new Calculation(0);
        }

        // TC01 Tính giai thừa của 0.
        [TestMethod]
        public void TestCase_01_11_Duong()
        {
            // Khai báo biến expected và actual.
            int expected, actual;

            // Gán giá trị mong đợi là 1.
            expected = 1;

            // Gọi phương thức Factorial với tham số 0 và lưu kết quả vào biến actual.
            actual = a.Factorial(0);

            // Xác nhận rằng kết quả thực tế khớp với kết quả mong đợi.
            Assert.AreEqual(expected, actual);
        }

        // TC02 Tính giai thừa của 5.
        [TestMethod]
        public void TestCase_02_11_Duong()
        {
            // Khai báo biến expected và actual.
            int expected, actual;

            // Gán giá trị mong đợi là 120.
            expected = 120;

            // Gọi phương thức Factorial với tham số 5 và lưu kết quả vào biến actual.
            actual = a.Factorial(5);

            // Xác nhận rằng kết quả thực tế khớp với kết quả mong đợi.
            Assert.AreEqual(expected, actual);

        }

        // TC03 Tính giai thừa của 10.
        [TestMethod]
        public void TestCase_03_11_Duong()
        {
            // Khai báo biến expected và actual.
            int expected, actual;

            // Gán giá trị mong đợi là 3628800.
            expected = 3628800;

            // Gọi phương thức Factorial với tham số 10 và lưu kết quả vào biến actual.
            actual = a.Factorial(10);

            // Xác nhận rằng kết quả thực tế khớp với kết quả mong đợi.
            Assert.AreEqual(expected, actual);

        }

        // TC04 Trường hợp ngoại lệ nếu người dùng nhập số âm.
        [TestMethod]
        public void TestCase_04_11_Duong()
        {
            // Xác nhận rằng việc gọi phương thức Factorial với tham số -1 sẽ ném ra ngoại lệ ArgumentException.
            Assert.ThrowsException<ArgumentException>(() => a.Factorial(-1));
        }

        // Đọc file CSV
        // Cung cấp quyền truy cập vào dữ liệu của bài kiểm thử.
        public TestContext TestContext { get; set; }
        // Chỉ định nguồn dữ liệu cho phương thức kiểm thử.
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void Test_Data_Source_11_Duong()
        {
            // Chuyển đổi cột đầu tiên của hàng dữ liệu hiện tại thành số nguyên 'a'.
            int a = int.Parse(TestContext.DataRow[0].ToString());
            // Chuyển đổi cột thứ hai của hàng dữ liệu hiện tại thành kết quả mong đợi.
            int expected = int.Parse(TestContext.DataRow[1].ToString());
            // Tạo một đối tượng của lớp Calculation với tham số là 'a'.
            Calculation b = new Calculation(a);
            // Kiểm tra nếu kết quả mong đợi là -1, điều này chỉ ra rằng một ngoại lệ được mong đợi.
            if (expected == -1)
            {
                // Xác nhận rằng việc gọi phương thức Factorial với 'a' ném ra ngoại lệ ArgumentException.
                Assert.ThrowsException<ArgumentException>(() => b.Factorial(a));
            }
            else
            {
                // Gọi phương thức Factorial và lưu kết quả vào biến 'actual'.
                int actual = b.Factorial(a);
                // Xác nhận rằng kết quả thực tế khớp với kết quả mong đợi.
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
