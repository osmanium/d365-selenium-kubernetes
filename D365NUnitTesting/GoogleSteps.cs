using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace D365NUnitTesting
{
    [Binding]
    public class GoogleSteps
    {
        private void Google()
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

        [Given(@"I have opened google (.*)")]
        public void GivenIHaveOpenedGoogle(int index)
        {
            Google();
        }

        [Given(@"I have opened bing (.*)")]
        public void GivenIHaveOpenedBing(int index)
        {
            Google();
        }
    }
}
