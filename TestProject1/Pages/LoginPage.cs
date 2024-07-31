// ﻿using OpenQA.Selenium;
// using SeleniumExtras.PageObjects;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace TestProject1.Pages
// {
//     internal class LoginPage
//     {
//         private IWebDriver driver;
//         [FindsBy(How = How.Id, Using = "Input Text")]
//         private IWebElement emailtext;
//         [FindsBy(How = How.Id, Using = "Password")]
//         private IWebElement passwordtext;
//         [FindsBy(How = How.Id, Using = "LoginButton")]
//         private IWebElement Login;

//         public LoginPage (IWebDriver driver)
//         {
//             this.driver = driver;
//             PageFactory.InitElements(driver, this);

//         }

//         public void login(string username, string password)
//         {
//             emailtext.SendKeys(username);
//             passwordtext.SendKeys(password);
//             Login.Click();

//         }


//     }
// }
