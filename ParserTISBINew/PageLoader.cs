using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ParserTISBINew
{
    internal class PageLoader
    {
        public IWebDriver driver = new ChromeDriver();
        public string Url { get; set; }
        
        public string Text { get; set; }
        public string TextLi { get; set; }

        public PageLoader(string url)
        {
            Url = url;
            
        }
        // Открывает сайты с помощью Драйвера
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(@$"{Url}");
     
        }
        // Парсит абзацы текста сайта ТИСБИ
        public string ParseText(int startCycle, int endCycle)
        {
            while(startCycle <= endCycle) 
            {

                IWebElement tag = driver.FindElement(By.XPath($@"(//div[contains(@class,'postupit-tabs__text')])[{startCycle}]"));
                Text += tag.Text;
                
                startCycle++;
            }
            Console.Clear();    
            return Text;
        }

        
        
    }
}
