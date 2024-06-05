using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Bài buổi 7_8 đầy đủ 7 cách tìm dựa trên các thuộc tính hoặc thẻ.
        private void button_11_HoangNongDuong_Click(object sender, EventArgs e)
        {
            // Các tiêu chuẩn tìm thành phần HTML 
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);
            String url = "https://www.netflix.com/login?nextpage=https%3A%2F%2Fwww.netflix.com%2Fbrowse";
            driver.Navigate().GoToUrl(url);


            // 1. Tìm dựa trên thuộc tính 'id'
            IWebElement email = driver.FindElement(By.Id(":r0:"));
            email.SendKeys("Vidu@gmail.com");

            // 2. Tìm dựa trên thuộc tính 'name'
            IWebElement pass = driver.FindElement(By.Name("password"));
            pass.SendKeys("aaa12@com");

            // 3. Tìm dựa trên giá trị thuộc tính class
            IWebElement login = driver.FindElement(By.ClassName("e1ax5wel2"));
            login.Click();

            // 4. Tìm dựa trên tên thẻ
            IWebElement loginText = driver.FindElement(By.TagName("h1"));
            Console.WriteLine(loginText.Text); 

            // 4.1 Tìm tất cả các thẻ 
            ReadOnlyCollection<IWebElement> Texts = driver.FindElements(By.TagName("li"));
            foreach (var item in Texts)
            {
                Console.WriteLine(item.Text);
            }

            // 5. Tìm thẻ a dựa trên tên của liên kết
            IWebElement linkText = driver.FindElement(By.LinkText("Forgot password?"));
            linkText.Click();

            // 6. Tìm dựa trên selector của css
            IWebElement recoveryEmail = driver.FindElement(By.CssSelector("input[type='email']"));
            recoveryEmail.SendKeys("HoangDuong@gmail.com");

            // 7. Tìm dựa trên chuỗi Xpath
            Thread.Sleep(2000);
            recoveryEmail.Clear();
            Thread.Sleep(2000);
            IWebElement recoveryEmailTwo = driver.FindElement(By.XPath("//*[@id=\"forgot_password_input\"]"));
            recoveryEmailTwo.SendKeys("NguUyennnnn@gmail.com");
        }
    }
}
