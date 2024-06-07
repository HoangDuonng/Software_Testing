using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CN1_TC01_11_Duong(object sender, EventArgs e)
        {
            // Test mẫu form
            // Tạo một ChromeDriver mặc định.
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();

            // Ẩn cửa sổ lệnh của trình duyệt Chrome khi khởi động.
            chrome.HideCommandPromptWindow = true;

            // Khởi tạo một trình điều khiển (driver) để điều khiển trình duyệt Chrome, sử dụng dịch vụ ChromeDriver đã được cấu hình.
            IWebDriver driver = new ChromeDriver(chrome);

            // Xác định URL của trang web mà trình duyệt sẽ điều hướng đến.
            string url = "https://demoqa.com/automation-practice-form";

            // Điều hướng trình duyệt đến URL đã xác định.
            driver.Navigate().GoToUrl(url);


            // 1. Điền thông tin Họ và Tên
            // Tìm phần tử trang web có ID là "firstName" và gán cho biến firstName_11_Duong.
            IWebElement firstName_11_Duong = driver.FindElement(By.Id("firstName"));

            // Gửi chuỗi "Hoàng" vào phần tử web đã tìm được.
            firstName_11_Duong.SendKeys("Hoàng");

            // Tìm phần tử trang web có ID là "lastName" và gán cho biến lastName_11_Duong.
            IWebElement lastName_11_Duong = driver.FindElement(By.Id("lastName"));

            // Gửi chuỗi "Dương" vào phần tử web đã tìm được.
            lastName_11_Duong.SendKeys("Dương");


            // 2. Điền thông tin email
            IWebElement email_11_Duong = driver.FindElement(By.Id("userEmail"));
            email_11_Duong.SendKeys("HoangDuong@gmail.com");

            // 3. Chọn giới tính
            IWebElement gender_11_Duong = driver.FindElement(By.CssSelector("label[for='gender-radio-1']"));
            gender_11_Duong.Click();

            // 4. Điền thông tin số điện thoại
            IWebElement phoneNumber_11_Duong = driver.FindElement(By.XPath("//*[@id='userNumber']"));
            phoneNumber_11_Duong.SendKeys("0999999999");

            // 5. Chọn ngày tháng năm 
            // 5.1 Click vào ô ngày tháng
            IWebElement birthDay_11_Duong = driver.FindElement(By.ClassName("react-datepicker-wrapper"));
            birthDay_11_Duong.Click();
            // 5.2 Chọn ngày tháng trong lịch
            IWebElement dayOfBirth_11_Duong = driver.FindElement(By.XPath("//div[@aria-label='Choose Monday, June 3rd, 2024']"));
            dayOfBirth_11_Duong.Click();

            // 6. Chọn đối tượng được gợi ý
            // 6.1 Nhập chữ cái để được gợi ý
            IWebElement inputField_11_Duong = driver.FindElement(By.Id("subjectsInput"));
            inputField_11_Duong.SendKeys("E");
            // 6.2 Chọn phần tử được gợi ý 
            // 6.2.1 Khởi tạo WebDriverWait để đợi gợi ý xuất hiện
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            // 6.2.2 Đợi gợi ý đầu tiên xuất hiện
            // Sử dụng WebDriverWait để chờ đợi và kiểm tra sự xuất hiện của một phần tử trong một khoảng thời gian nhất định.
            IWebElement suggestion_11_Duong = wait.Until(dri =>
            {
                try
                {
                    // Tìm phần tử trên trang web sử dụng XPath.
                    IWebElement element = dri.FindElement(By.XPath("//div[contains(@class, 'subjects-auto-complete__menu')]//div[@id]"));

                    // Kiểm tra xem phần tử được tìm thấy và hiển thị hay không.
                    if (element.Displayed)
                    {
                        // Nếu phần tử được tìm thấy và hiển thị, trả về phần tử đó.
                        return element;
                    }
                    // Nếu phần tử được tìm thấy nhưng không hiển thị, trả về null.
                    return null;
                }
                catch (NoSuchElementException)
                {
                    // Nếu không tìm thấy phần tử, trả về null.
                    return null;
                }
            });

            Thread.Sleep(4000);
            // 6.3 Click vào phần tử gợi ý
            suggestion_11_Duong.Click();

            // 7. Chọn sở thích
            // Tìm phần tử checkbox cho hoạt động đọc sách bằng cách sử dụng CSS Selector và thuộc tính "for" với giá trị là 'hobbies-checkbox-2'.
            IWebElement readingCheckbox_11_Duong = driver.FindElement(By.CssSelector("label[for='hobbies-checkbox-2']"));

            // Click vào checkbox cho hoạt động đọc sách.
            readingCheckbox_11_Duong.Click();

            // Tìm phần tử checkbox cho hoạt động nghe nhạc bằng cách sử dụng CSS Selector và thuộc tính "for" với giá trị là 'hobbies-checkbox-3'.
            IWebElement musicCheckbox_11_Duong = driver.FindElement(By.CssSelector("label[for='hobbies-checkbox-3']"));

            // Click vào checkbox cho hoạt động nghe nhạc.
            musicCheckbox_11_Duong.Click();


            // 8. Chọn hình ảnh 
            IWebElement uploadPicture_11_Duong = driver.FindElement(By.Id("uploadPicture"));
            uploadPicture_11_Duong.SendKeys(@"C:\Users\Duong\OneDrive\Pictures\Saved Pictures\Logo TLU.png");

            // 9. Nhập địa chỉ hiện tại
            IWebElement currentAddress_11_Duong = driver.FindElement(By.Id("currentAddress"));
            currentAddress_11_Duong.SendKeys("Số 2 Trường Sa");

            // 10. Chọn vị trí trong combobox
            IWebElement state_11_Duong = driver.FindElement(By.Id("state"));
            state_11_Duong.Click();

            Thread.Sleep(3000);
            IWebElement stateCombobox_11_Duong = driver.FindElement(By.CssSelector(".css-26l3qy-menu"));
            stateCombobox_11_Duong.Click();

            // 11. Chọn thành phố trong combobox
            IWebElement city_11_Duong = driver.FindElement(By.Id("city"));
            city_11_Duong.Click();

            Thread.Sleep(3000);
            IWebElement cityCombobox_11_Duong = driver.FindElement(By.CssSelector(".css-26l3qy-menu"));
            cityCombobox_11_Duong.Click();

            // 12. Bấm submit form
            IWebElement buttonSubmit_11_Duong = driver.FindElement(By.Id("submit"));
            buttonSubmit_11_Duong.Click();
            Thread.Sleep(5000);

            // 13. Lấy được đoạn text "Thanks for submitting the form" để biết testcase đã pass.
            // Tìm phần tử popup với ID "example-modal-sizes-title-lg"
            IWebElement popUp_11_Duong = driver.FindElement(By.Id("example-modal-sizes-title-lg"));

            // Lấy văn bản từ popup
            string text = popUp_11_Duong.Text;

            // Chuỗi bạn muốn so sánh
            string ketqua = "Thanks for submitting the form";

            // So sánh văn bản từ popup với chuỗi "Thanks for submitting the form"
            if (text == ketqua)
            {
                // In ra "Testcase Pass" nếu điều kiện đúng
                Console.WriteLine("Testcase Pass");
            }

            // Dừng chương trình trong 5 giây
            Thread.Sleep(5000);


            // 14. Đóng cửa sổ sau khi hoàn thành submit
            IWebElement buttonClose_11_Duong = driver.FindElement(By.Id("closeLargeModal"));
            buttonClose_11_Duong.Click();

        }

        private void CN1_TC02_11_Duong(object sender, EventArgs e)
        {
            // Test mẫu form
            // Tạo một dịch vụ ChromeDriver mặc định.
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();

            // Ẩn cửa sổ lệnh của trình duyệt Chrome khi khởi động.
            chrome.HideCommandPromptWindow = true;

            // Tạo một đối tượng WebDriver cho trình duyệt Chrome, sử dụng dịch vụ ChromeDriver đã được cấu hình trước đó.
            IWebDriver driver = new ChromeDriver(chrome);

            // Xác định URL của trang web mà trình duyệt sẽ điều hướng đến.
            string url = "https://demoqa.com/automation-practice-form";

            // Điều hướng trình duyệt đến URL đã xác định.
            driver.Navigate().GoToUrl(url);


            // 1. Điền thông tin Họ và Tên (Chuỗi rỗng)
            IWebElement firstName_11_Duong = driver.FindElement(By.Id("firstName"));
            firstName_11_Duong.SendKeys("");
            IWebElement lastName_11_Duong = driver.FindElement(By.Id("lastName"));
            lastName_11_Duong.SendKeys("");

            // 2. Điền thông tin email
            IWebElement email_11_Duong = driver.FindElement(By.Id("userEmail"));
            email_11_Duong.SendKeys("HoangDuong@gmail.com");

            // 3. Chọn giới tính (Không chọn giới tính)
            IWebElement gender_11_Duong = driver.FindElement(By.CssSelector("label[for='gender-radio-1']"));
            //gender.Click();

            // 4. Điền thông tin số điện thoại (Điền không đủ 10 số)
            IWebElement phoneNumber_11_Duong = driver.FindElement(By.CssSelector("input[placeholder = 'Mobile Number']"));
            phoneNumber_11_Duong.SendKeys("099999999");

            // 5. Chọn ngày tháng năm 
            // 5.1 Click vào ô ngày tháng
            IWebElement birthDay_11_Duong = driver.FindElement(By.ClassName("react-datepicker-wrapper"));
            birthDay_11_Duong.Click();
            // 5.2 Chọn ngày tháng trong lịch
            IWebElement dayOfBirth_11_Duong = driver.FindElement(By.XPath("//div[@aria-label='Choose Monday, June 3rd, 2024']"));
            dayOfBirth_11_Duong.Click();

            // 6. Kiểm tra xem popup có được hiển thị không. (Nếu không hiển thị thì testcase pass).
            try
            {
                // Tìm phần tử trên trang web
                IWebElement popUp_11_Duong = driver.FindElement(By.Id("example-modal-sizes-title-lg"));

                // Nếu phần tử tồn tại, fail testcase vì popup đã hiển thị
                Console.WriteLine("Testcase Fail");
            }
            catch (NoSuchElementException)
            {
                // Nếu không tìm thấy phần tử, tức là popup không hiển thị, testcase pass
                Console.WriteLine("Testcase Pass");
            }

            // 6. Bấm submit form ==> Không submit được báo đỏ những chỗ thông tin bắt buộc
            IWebElement buttonSubmit_11_Duong = driver.FindElement(By.Id("submit"));
            buttonSubmit_11_Duong.Click();
        }

        private void CN2_TC01_11_Duong(object sender, EventArgs e)
        {
            // Test mẫu chỉnh sửa đủ và đúng dữ liệu
            // Tạo một dịch vụ ChromeDriver với cấu hình mặc định.
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();

            // Ẩn cửa sổ lệnh khi khởi động trình duyệt Chrome.
            chrome.HideCommandPromptWindow = true;

            // Khởi tạo một trình điều khiển (driver) để điều khiển trình duyệt Chrome, sử dụng dịch vụ ChromeDriver đã được cấu hình.
            IWebDriver driver = new ChromeDriver(chrome);

            // Xác định URL của trang web mà trình duyệt sẽ điều hướng đến.
            string url = "https://demoqa.com/webtables";

            // Điều hướng trình duyệt đến URL đã xác định.
            driver.Navigate().GoToUrl(url);


            // 1. Bấm vào nút chỉnh sửa
            IWebElement iconEdit_11_Duong = driver.FindElement(By.Id("edit-record-1"));
            iconEdit_11_Duong.Click();

            // 2. Chỉnh Họ
            IWebElement firstName_11_Duong = driver.FindElement(By.CssSelector("input[value='Cierra']"));
            firstName_11_Duong.Clear();
            firstName_11_Duong.SendKeys("Hoàng");

            // 2. Chỉnh Tên
            IWebElement lastName_11_Duong = driver.FindElement(By.Id("lastName"));
            lastName_11_Duong.Clear();
            lastName_11_Duong.SendKeys("Dương");

            // 3. Chỉnh Email
            IWebElement email_11_Duong = driver.FindElement(By.Id("userEmail"));
            email_11_Duong.Clear();
            email_11_Duong.SendKeys("Nguuyen@gmail.com");

            // 4. Chỉnh tuổi 
            IWebElement age_11_Duong = driver.FindElement(By.Id("age"));
            age_11_Duong.Clear();
            age_11_Duong.SendKeys("21");

            // 5. Bấm submit 
            IWebElement submit_11_Duong = driver.FindElement(By.CssSelector("button[type='submit']"));
            submit_11_Duong.Click();
            
        }

        private void CN2_TC02_11_Duong(object sender, EventArgs e)
        {
            // Test mẫu sửa dữ liệu đủ và không đúng kiểu dữ liệu
            // Tạo một dịch vụ ChromeDriver với cấu hình mặc định.
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();

            // Ẩn cửa sổ lệnh của trình duyệt Chrome khi khởi động.
            chrome.HideCommandPromptWindow = true;

            // Tạo một đối tượng WebDriver cho trình duyệt Chrome, sử dụng dịch vụ ChromeDriver đã được cấu hình trước đó.
            IWebDriver driver = new ChromeDriver(chrome);

            // Xác định URL của trang web mà trình duyệt sẽ điều hướng đến.
            string url = "https://demoqa.com/webtables";

            // Điều hướng trình duyệt đến URL đã xác định.
            driver.Navigate().GoToUrl(url);


            // 1. Bấm vào nút chỉnh sửa
            IWebElement iconEdit_11_Duong = driver.FindElement(By.Id("edit-record-2"));
            iconEdit_11_Duong.Click();

            // 2. Chỉnh Email (Không đúng định dạng mail)
            IWebElement email_11_Duong = driver.FindElement(By.Id("userEmail"));
            email_11_Duong.Clear();
            email_11_Duong.SendKeys("Nguuyengmail.hehe");

            // 3. Chỉnh tuổi (Nhập chuỗi ký tự) 
            IWebElement age_11_Duong = driver.FindElement(By.Id("age"));
            age_11_Duong.Clear();
            age_11_Duong.SendKeys("CN");

            // 4. Bấm submit ==> Không submit được báo đỏ những trường nhập sai kiểu dữ liệu
            IWebElement submit_11_Duong = driver.FindElement(By.CssSelector("button[type='submit']"));
            submit_11_Duong.Click();
        }

        private void CN2_TC03_11_Duong(object sender, EventArgs e)
        {
            // Test mẫu sửa dữ liệu đủ và không đủ dữ liệu
            // Tạo dịch vụ ChromeDriver với cấu hình mặc định.
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();

            // Ẩn cửa sổ lệnh khi khởi động trình duyệt Chrome.
            chrome.HideCommandPromptWindow = true;

            // Khởi tạo một đối tượng WebDriver cho trình duyệt Chrome, sử dụng dịch vụ ChromeDriver đã được cấu hình.
            IWebDriver driver = new ChromeDriver(chrome);

            // Xác định URL của trang web sẽ được trình duyệt điều hướng đến.
            string url = "https://demoqa.com/webtables";

            // Điều hướng trình duyệt đến URL đã xác định.
            driver.Navigate().GoToUrl(url);


            // 1. Bấm vào nút chỉnh sửa
            IWebElement iconEdit_11_Duong = driver.FindElement(By.Id("edit-record-3"));
            iconEdit_11_Duong.Click();

            // 2. Chỉnh lương (Xoá -> truyền khoảng trắng)
            IWebElement salary_11_Duong = driver.FindElement(By.Id("salary"));
            salary_11_Duong.Clear();
            salary_11_Duong.SendKeys(" ");
            Thread.Sleep(3000);

            // 3. Bấm submit ==> Không submit được báo đỏ trường nhập sai (thiếu) dữ liệu 
            IWebElement submit_11_Duong = driver.FindElement(By.CssSelector("button[type='submit']"));
            submit_11_Duong.Click();
        }
    }
}
