using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mz4250Downloader
{
    public class StlDownloader
    {
        private readonly string _url;
        private readonly string _downloadDirectory;

      


        public async Task DownloadStlFilesAsync(string DownloadFolder,string Url )
        {   
            
            await Task.Delay(1000);

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            string downloadFolderPath = DownloadFolder;


            if (!System.IO.Directory.Exists(downloadFolderPath))
            {
                System.IO.Directory.CreateDirectory(downloadFolderPath);
            }

            // Set Chrome options to configure download behavior
            options.AddUserProfilePreference("download.default_directory", downloadFolderPath);
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddUserProfilePreference("download.directory_upgrade", true);
            options.AddUserProfilePreference("safebrowsing.enabled", true);
            options.AddArgument("--start-maximized");



            // Initialize WebDriver
            using (IWebDriver driver = new ChromeDriver(options))
            {
                try
                {
                    //"https://www.printables.com/model/1001916-paladin-collection-3/files";
                    // Navigate to the page
                    driver.Navigate().GoToUrl(Url);

                    // Wait for elements to load
                    Thread.Sleep(5000);


                    // Create explicit wait
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                    // Accept cookie consent popup if it appears
                    try
                    {
                        var consentButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(), 'I am OK with that')]")));
                        consentButton.Click();
                        Console.WriteLine("Accepted cookie consent.");
                        Thread.Sleep(2000); // Wait for UI to stabilize
                    }
                    catch (WebDriverTimeoutException)
                    {
                        Console.WriteLine("No cookie popup found. Proceeding...");
                    }

                    driver.Navigate().GoToUrl(Url);

                    // Find all download buttons
                    // var downloadButtons = driver.FindElements(By.XPath("//button[contains(text(), 'Download')]")).ToList();
                    // Find all download buttons whose parent does NOT contain ".blend"
                    var downloadButtons = driver.FindElements(By.XPath("//button[contains(text(), 'Download')]"))                       
                        .ToList();



                    Console.WriteLine($"Found {downloadButtons.Count} download buttons.");

                    // Click each button
                    foreach (var button in downloadButtons)
                    {
                        try
                        {
                            var parent = button.FindElement(By.XPath("./ancestor::div[1]")); // Adjust based on the site's structure
                            bool t = !parent.Text.Contains(".blend");

                            button.Click();
                            Thread.Sleep(2000); // Small delay to allow downloads to process

                            //Remove all the files with .blend extension
                            Directory.GetFiles(downloadFolderPath, "*.blend").ToList().ForEach(File.Delete);
                            Directory.GetFiles(downloadFolderPath, "*presupported*").ToList().ForEach(File.Delete);




                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error clicking button: {ex.Message}");
                        }
                    }

                    Console.WriteLine("Download clicks complete.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    // Keep browser open for inspection (optional)
                   // Console.WriteLine("Press any key to close...");
                   // Console.ReadKey();
                    driver.Quit();
                }
            }

        }
    }
}
