using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

class Program {
    static void Main(string[] args) {
        // Set up the ChromeOptions for a browser
        ChromeOptions options = new ChromeOptions();
        options.AddUserProfilePreference("safebrowsing.enabled", "true");
        options.AddArguments("--safebrowsing-disable-download-protection", "--headless");

        // Create a new instance of the ChromeDriver with the defined options
        ChromeDriver driver = new ChromeDriver(options);

        // Navigate to the URL
        driver.Navigate().GoToUrl("https://www.emsisoft.com/en/anti-malware-home/");

        // Find the link to the Alternative installation options page and click it
        driver.FindElement(By.LinkText("Alternative installation options")).Click();

        // Wait for the Web installer link to be visible and click it
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Web installer"))).Click();

        // Quit the driver to close the browser
        driver.Quit();
    }
}

