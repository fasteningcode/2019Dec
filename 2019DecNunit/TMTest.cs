using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _2019DecNunit
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // add reference to selenium
            // add reference to browser (eg: chrome)

            //open a chrome browser
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //accessing static method
            //LoginPage.LoginSuccess(driver);

            //create instance of class
            LoginPage login = new LoginPage();
            //access the method of class using the instance
            login.LoginSuccess(driver);
        }

        [TearDown]
        public void TearDown()
        {
            //close driver
            driver.Quit();
        }

        [Test]
        public void EditTMnVerify()
        {

        }
        
        [Test]

        public void DeletenVerify()
        {

        }

        [Test]
        public void CreateTMnVerify()
        {       


            // Create an instance of home page
            HomePage home = new HomePage();

            // create a method to verify the username
            home.VerifyUsername(driver);

            // create a method to click adminstration
            home.ClickAdminstration(driver);

            // create a method to click time n materials
            home.ClickTimenMaterial(driver);


            // click create new
            TimeMaterialPage timeMaterial = new TimeMaterialPage();
            timeMaterial.ClickCreateNew(driver);

            // enter valid information and click save
            timeMaterial.EnterValidDetails(driver);

            //verify that the time n material object is displayed in the table




            //assignment
            // complete 3 test cases
            // edit create time and material and verify
            // delete create time and material and verify

            

            //added reference for nunit3 & nunit3testadapter
        }
    }

}