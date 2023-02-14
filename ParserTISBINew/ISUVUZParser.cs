using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTISBINew
{
    internal class ISUVUZParser : PageLoader
    {
        public string Text { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
        public ISUVUZParser(string url, string login, string password) : base(url)
        {
            
            Login = login;
            Password = password;
        }

        public string ScheduleParser()
        {
            OpenPage();

            Thread.Sleep(1500);
            driver.FindElement(By.XPath(@"//input[contains(@name,'Login')]")).SendKeys(Login);


            driver.FindElement(By.XPath(@"//input[contains(@name,'Password')]")).SendKeys(Password);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(@"//button[@type='button'][contains(.,'Войти')]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(@"//button[@type='button'][contains(.,'Начать работу')]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(@"//a[contains(@data-toggle,'dropdown')]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(@"//a[@class='dropdown-item'][contains(.,'Расписание занятий')]")).Click();
            Console.Clear();
            Thread.Sleep(2000);

            for (int i = 1; i <= 6; i++)
            {
                try
                {
                    Text += driver.FindElement(By.XPath($@"(//td[@class='align-middle table-primary'])[{i}]")).Text;
                    
                }
                catch (Exception e) 
                {
                    continue;
                }
                
                
            }
            return Text;
            
        }
    }
}
