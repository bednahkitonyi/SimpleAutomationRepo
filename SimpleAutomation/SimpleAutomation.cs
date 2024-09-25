using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;

namespace SimpleAutomation
{
    internal class SimpleAutomation
    {
        [Test]
        public void Register()

        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ke.sportpesa.com/en/sports-betting/football-1/");
            var btn = driver.FindElement(By.ClassName("btn-register"));

            Assert.That(btn, Is.Not.Null);

        }
        [Test]
        public void BetHistory()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ke.sportpesa.com/en/sports-betting/football-1/");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("0727523766");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Gunners2021%");
            driver.FindElement(By.CssSelector("#secondary_login > input[type=submit]:nth-child(6)")).Click();

            var bethistory = driver.FindElement(By.ClassName("bet-history"));
            Assert.That(bethistory, Is.Not.Null);

        }
        [Test]
        public void TransactionHistory()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ke.sportpesa.com/en/sports-betting/football-1/");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("0727523766");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Gunners2021%");
            driver.FindElement(By.CssSelector("#secondary_login > input[type=submit]:nth-child(6)")).Click();

            var Transaction = driver.FindElement(By.ClassName("transactions"));
            Assert.That(Transaction, Is.Not.Null);

        }
        [Test]
        public void Withdraw()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ke.sportpesa.com/en/sports-betting/football-1/");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("0727523766");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Gunners2021%");
            driver.FindElement(By.CssSelector("#secondary_login > input[type=submit]:nth-child(6)")).Click();

            var withdraw = driver.FindElement(By.ClassName("withdraw"));

            Assert.That(withdraw, Is.Not.Null);
        }

        [Test]
        public void Settings()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ke.sportpesa.com/en/sports-betting/football-1/");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("0727523766");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Gunners2021%");
            driver.FindElement(By.CssSelector("#secondary_login > input[type=submit]:nth-child(6)")).Click();

            var setting = driver.FindElement(By.ClassName("manage-account"));
            Assert.That(setting, Is.Not.Null);
        }

        [Test]
        public void ForgotPassword()
        {
            var driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ke.sportpesa.com/en/sports-betting/football-1/");
            driver.FindElement(By.CssSelector("#retrieve-password > span:nth-child(3)")).Click();


        }

        [Test]
        public void BrowserStack()
        {
            var driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.browserstack.com/");
            driver.FindElement(By.CssSelector("#customers_section_cta_variation > div > div > article > div > div > div > span:nth-child(1) > button")).Click();
            driver.FindElement(By.Id("csf_form_name_1")).Click();
            driver.FindElement(By.Id("csf_form_name_1")).SendKeys("Pauline");

            driver.FindElement(By.Id("csf_form_email_1")).Click();
            driver.FindElement(By.Id("csf_form_email_1")).SendKeys("Pauline@gmail.com");


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("csf_form_company_1")).Click();
            driver.FindElement(By.Id("csf_form_company_1")).SendKeys("TechFarm Solutions");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("csf_form_msg_1")).Click();
            driver.FindElement(By.Id("csf_form_msg_1")).SendKeys("Thanks amazing services");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector("#popUpContactUsModalForm > div:nth-child(6) > div > div > input")).Click();

        }
    }

 }
