using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TollsQA
{
    class FirstTC
    {
        static void Main(string[] args)
        {

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\esokol\source");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            IWebDriver driver = new FirefoxDriver(service);

            //           driver.Navigate().GoToUrl("http://google.ca");
            driver.Url = "http://www.demoqa.com";
        }
    }
}