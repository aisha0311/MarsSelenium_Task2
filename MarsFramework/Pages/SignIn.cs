using MarsFramework.Test.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MarsFramework.Pages
{
    class SignIn
    {
       
       
        private IWebDriver driver; // constructor

        public SignIn(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void SignInSteps()
        {
            // {
            //     PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
            // }

            // #region  Initialize Web Elements 
            // Finding the Sign Link
            // [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
            // private IWebElement SignIntab { get; set; }

            // Finding the Email Field
            //[FindsBy(How = How.Name, Using = "email")]
            // private IWebElement Email { get; set; }

            // Finding the Password Field
            // [FindsBy(How = How.Name, Using = "password")]
            // private IWebElement Password { get; set; }

            // Finding the Login Button
            // [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
            // private IWebElement LoginBtn { get; set; }

            //#endregion

            //Initialize Web Elements
            IWebElement SignLink = driver.FindElement(By.XPath("//a[contains(text(),'Sign')]"));
        IWebElement Email = driver.FindElement(By.Name("email"));
        IWebElement Password = driver.FindElement(By.Name("password"));
        IWebElement LoginBtn = driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));

        // Populate/ create collection during runtime
        ExcelUtility.PopulateInCollection(@"C:\Users\shaik\Downloads\marsframework-master\MarsFramework\ExcelData\SignIn.xls", "SignIn");

            //type the user name as [mvpstudio.qa@gmail.com] 
            Email.SendKeys(ExcelUtility.ReadData(2, "Username"));

            // identify and type the password as [SydneyQa2018] 
            Password.SendKeys(ExcelUtility.ReadData(2, "Password"));

            Async.WaitForWebElementClickable(driver, "//button[contains(text(),'Login')]", 1, "XPath");

            //click on login button 
            LoginBtn.Click();
        }
    }
}


