using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Authentication
{
    class Program
    {
        private IWebDriver driver;
        private readonly By _loginInputButton = By.XPath("//input[@name='USER_LOGIN']");
        private readonly By _passwordInputButton = By.XPath("//input[@name='USER_PASSWORD']");
        private readonly By _loginButton = By.XPath("//input[@name='Login']");
        private const string _login = "test@gmail.com";
        private const string _password = "testpass";

        static void Main(string[] args)
        {
            Program aut = new Program();
            aut.Setup();
            aut.InputData();
        }

        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://texdesign.ru/auth/");
            driver.Manage().Window.Maximize();
        }

        public void InputData()
        {
            var login = driver.FindElement(_loginInputButton);
            login.SendKeys(_login);

            var password = driver.FindElement(_passwordInputButton);
            password.SendKeys(_password);

            var continueLogin = driver.FindElement(_loginButton);
            continueLogin.Click();
        }
    }
}
