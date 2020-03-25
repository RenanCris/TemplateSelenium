using OpenQA.Selenium.Chrome;
using System;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://github.com/RenanCris/TemplateSelenium");
            driver.Manage().Window.Maximize();

            Console.ReadKey();
            driver.Dispose();
        }
    }
}
