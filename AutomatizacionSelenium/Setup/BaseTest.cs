﻿using AutomatizacionPrueba.Setup;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPrueba
{
    public class BaseTest
    {
        protected IWebDriver driver = new ChromeDriver();
        ChromeOptions option = new ChromeOptions();

        [SetUp]
        public void Setup()
        {
            option.AddArguments("--headless");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDownAfterTestMethod()
        {
            close();
        }

        public void close()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
