//using System;
//using NUnit.Framework;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Remote;

//namespace Tests
//{
//    [Parallelizable(ParallelScope.All)]
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
//        }

//        private void Google()
//        {
//            var options = new ChromeOptions();
//            options.AddArguments("--start-maximized");


//            using (var driver = new RemoteWebDriver(new Uri("http://localhost:32000/wd/hub"), options))
//            {
//                driver.Manage().Window.Maximize();

//                driver.Navigate().GoToUrl("https://www.google.com");

//                driver.Quit();
//            }
//        }


//        [Test]
//        public void Test1()
//        {
//            Google();
//        }

//        [Test]
//        public void Test2()
//        {
//            Google();
//        }

//        [Test]
//        public void Test3()
//        {
//            Google();
//        }

//        [Test]
//        public void Test4()
//        {
//            Google();
//        }

//        [Test]
//        public void Test5()
//        {
//            Google();
//        }

//        [Test]
//        public void Test6()
//        {
//            Google();
//        }

//        [Test]
//        public void Test7()
//        {
//            Google();
//        }

//        [Test]
//        public void Test8()
//        {
//            Google();
//        }

//        [Test]
//        public void Test9()
//        {
//            Google();
//        }

//        [Test]
//        public void Test10()
//        {
//            Google();
//        }
//    }
//}