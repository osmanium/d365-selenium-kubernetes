using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace D365KubernetesTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            var options = new ChromeOptions();
            options.AddArguments("--start-maximized");


            using (var driver = new RemoteWebDriver(new Uri("http://localhost:32000/wd/hub"), options))
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("https://www.google.com");

                driver.Quit();
            }
        }
    }
}
