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

        private void button_1_11_HoangNongDuong_Click(object sender, EventArgs e)
        {
            // Test mẫu form
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);
            String url = "https://demoqa.com/automation-practice-form";
            driver.Navigate().GoToUrl(url);

            // 1. Điền thông tin Họ và Tên
            IWebElement firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Hoàng");
            IWebElement lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Dương");

            // 2. Điền thông tin email
            IWebElement email = driver.FindElement(By.Id("userEmail"));
            email.SendKeys("HoangDuong@gmail.com");

            // 3. Chọn giới tính
            IWebElement gender = driver.FindElement(By.CssSelector("label[for='gender-radio-1']"));
            gender.Click();

            // 4. Điền thông tin số điện thoại
            IWebElement phoneNumber = driver.FindElement(By.CssSelector("input[placeholder = 'Mobile Number']"));
            phoneNumber.SendKeys("0999999999");

            // 5. Chọn ngày tháng năm 
            // 5.1 Click vào ô ngày tháng
            IWebElement birthDay = driver.FindElement(By.ClassName("react-datepicker-wrapper"));
            birthDay.Click();
            // 5.2 Chọn ngày tháng trong lịch
            IWebElement dayOfBirth = driver.FindElement(By.XPath("//div[@aria-label='Choose Monday, June 3rd, 2024']"));
            dayOfBirth.Click();

            // 6. Chọn đối tượng được gợi ý
            // 6.1 Nhập chữ cái để được gợi ý
            IWebElement inputField = driver.FindElement(By.Id("subjectsInput"));
            inputField.SendKeys("E");
            // 6.2 Chọn phần tử được gợi ý 
            // 6.2.1 Khởi tạo WebDriverWait để đợi gợi ý xuất hiện
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            // 6.2.2 Đợi gợi ý đầu tiên xuất hiện
            IWebElement suggestion = wait.Until(dri =>
            {
                try
                {
                    IWebElement element = dri.FindElement(By.XPath("//div[contains(@class, 'subjects-auto-complete__menu')]//div[@id]"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                    return null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            });
            Thread.Sleep(4000);
            // 6.3 Click vào phần tử gợi ý
            suggestion.Click();

            // 7. Chọn sở thích
            IWebElement readingCheckbox = driver.FindElement(By.CssSelector("label[for='hobbies-checkbox-2']"));
            readingCheckbox.Click();
            IWebElement musicCheckbox = driver.FindElement(By.CssSelector("label[for='hobbies-checkbox-3']"));
            musicCheckbox.Click();

            // 8. Chọn hình ảnh 
            IWebElement uploadPicture = driver.FindElement(By.Id("uploadPicture"));
            uploadPicture.SendKeys(@"C:\Users\Duong\OneDrive\Pictures\Saved Pictures\Logo TLU.png");

            // 9. Nhập địa chỉ hiện tại
            IWebElement currentAddress = driver.FindElement(By.Id("currentAddress"));
            currentAddress.SendKeys("Số 2 Trường Sa");

            // 10. Chọn vị trí trong combobox
            IWebElement state = driver.FindElement(By.Id("state"));
            state.Click();

            Thread.Sleep(3000);
            IWebElement stateCombobox = driver.FindElement(By.CssSelector(".css-26l3qy-menu"));
            stateCombobox.Click();

            // 11. Chọn thành phố trong combobox
            IWebElement city = driver.FindElement(By.Id("city"));
            city.Click();

            Thread.Sleep(3000);
            IWebElement cityCombobox = driver.FindElement(By.CssSelector(".css-26l3qy-menu"));
            cityCombobox.Click();

            // 12. Bấm submit form
            IWebElement buttonSubmit = driver.FindElement(By.Id("submit"));
            buttonSubmit.Click();
            Thread.Sleep(5000);

            // 13. Đóng cửa sổ sau khi hoàn thành submit
            IWebElement buttonClose = driver.FindElement(By.Id("closeLargeModal"));
            buttonClose.Click();
            
        }

        private void button_2_11_HoangNongDuong_Click(object sender, EventArgs e)
        {
            // Test mẫu form
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);
            String url = "https://demoqa.com/automation-practice-form";
            driver.Navigate().GoToUrl(url);

            // 1. Điền thông tin Họ và Tên (Chuỗi rỗng)
            IWebElement firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("");
            IWebElement lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("");

            // 2. Điền thông tin email
            IWebElement email = driver.FindElement(By.Id("userEmail"));
            email.SendKeys("HoangDuong@gmail.com");

            // 3. Chọn giới tính (Không chọn giới tính)
            IWebElement gender = driver.FindElement(By.CssSelector("label[for='gender-radio-1']"));
            //gender.Click();

            // 4. Điền thông tin số điện thoại (Điền không đủ 10 số)
            IWebElement phoneNumber = driver.FindElement(By.CssSelector("input[placeholder = 'Mobile Number']"));
            phoneNumber.SendKeys("099999999");

            // 5. Chọn ngày tháng năm 
            // 5.1 Click vào ô ngày tháng
            IWebElement birthDay = driver.FindElement(By.ClassName("react-datepicker-wrapper"));
            birthDay.Click();
            // 5.2 Chọn ngày tháng trong lịch
            IWebElement dayOfBirth = driver.FindElement(By.XPath("//div[@aria-label='Choose Monday, June 3rd, 2024']"));
            dayOfBirth.Click();

            // 6. Bấm submit form ==> Không submit được báo đỏ những chỗ thông tin bắt buộc
            IWebElement buttonSubmit = driver.FindElement(By.Id("submit"));
            buttonSubmit.Click();
        }

        private void button_3_11_HoangNongDuong_Click(object sender, EventArgs e)
        {
            // Test mẫu chỉnh sửa đủ và đúng dữ liệu
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);
            String url = "https://demoqa.com/webtables";
            driver.Navigate().GoToUrl(url);

            // 1. Bấm vào nút chỉnh sửa
            IWebElement iconEdit = driver.FindElement(By.Id("edit-record-1"));
            iconEdit.Click();

            // 2. Chỉnh Họ
            IWebElement firstName = driver.FindElement(By.CssSelector("input[value='Cierra']"));
            firstName.Clear();
            firstName.SendKeys("Hoàng");

            // 2. Chỉnh Tên
            IWebElement lastName = driver.FindElement(By.Id("lastName"));
            lastName.Clear();
            lastName.SendKeys("Dương");

            // 3. Chỉnh Email
            IWebElement email = driver.FindElement(By.Id("userEmail"));
            email.Clear();
            email.SendKeys("Nguuyen@gmail.com");

            // 4. Chỉnh tuổi 
            IWebElement age = driver.FindElement(By.Id("age"));
            age.Clear();
            age.SendKeys("21");

            // 5. Bấm submit 
            IWebElement submit = driver.FindElement(By.CssSelector("button[type='submit']"));
            submit.Click();
            
        }

        private void button_4_11_HoangNongDuong_Click(object sender, EventArgs e)
        {
            // Test mẫu sửa dữ liệu đủ và không đúng kiểu dữ liệu
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);
            String url = "https://demoqa.com/webtables";
            driver.Navigate().GoToUrl(url);

            // 1. Bấm vào nút chỉnh sửa
            IWebElement iconEdit = driver.FindElement(By.Id("edit-record-2"));
            iconEdit.Click();

            // 2. Chỉnh Email (Không đúng định dạng mail)
            IWebElement email = driver.FindElement(By.Id("userEmail"));
            email.Clear();
            email.SendKeys("Nguuyengmail.hehe");

            // 3. Chỉnh tuổi (Nhập chuỗi ký tự) 
            IWebElement age = driver.FindElement(By.Id("age"));
            age.Clear();
            age.SendKeys("CN");

            // 4. Bấm submit ==> Không submit được báo đỏ những trường nhập sai kiểu dữ liệu
            IWebElement submit = driver.FindElement(By.CssSelector("button[type='submit']"));
            submit.Click();
        }

        private void button_5_11_HoangNongDuong_Click(object sender, EventArgs e)
        {
            // Test mẫu sửa dữ liệu đủ và không đủ dữ liệu
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);
            String url = "https://demoqa.com/webtables";
            driver.Navigate().GoToUrl(url);

            // 1. Bấm vào nút chỉnh sửa
            IWebElement iconEdit = driver.FindElement(By.Id("edit-record-3"));
            iconEdit.Click();

            // 2. Chỉnh lương (Xoá -> truyền khoảng trắng)
            IWebElement salary = driver.FindElement(By.Id("salary"));
            salary.Clear();
            salary.SendKeys(" ");
            Thread.Sleep(3000);

            // 3. Bấm submit ==> Không submit được báo đỏ trường nhập sai (thiếu) dữ liệu 
            IWebElement submit = driver.FindElement(By.CssSelector("button[type='submit']"));
            submit.Click();
        }
    }
}
