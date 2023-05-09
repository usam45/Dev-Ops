using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MyFirstAzureWebApp
    
{
    public class login
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("D:\\softwares\\chromedriver_win32\\chromedriver.exe");
            driver.Url = "https://www.google.com/";
            IWebElement emailField = driver.FindElement(By.Id("email"));
            IWebElement passwordField = driver.FindElement(By.Id("password"));

            emailField.SendKeys("admin@admin.com");
            passwordField.SendKeys("admin");

            // Submit the form
            passwordField.Submit();

        }
    }
}
