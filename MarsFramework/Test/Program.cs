using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            IWebDriver driver;
            [Test]
            public void Test()
            {
                SignIn signIn = new SignIn();
                signIn.SignInSteps();


            }



        }
    }
}