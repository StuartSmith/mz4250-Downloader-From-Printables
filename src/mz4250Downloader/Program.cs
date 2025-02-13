using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using mz4250Downloader;
using static System.Net.WebRequestMethods;

class Program
{
    static void Main()
    {
        StlDownloader stlDownloader = new StlDownloader();



        /*    stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Paladins", "https://www.printables.com/model/1001916-paladin-collection-3/files").Wait();
        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\sorcerer", "https://www.printables.com/model/1002157-sorcerer-collection-3/files").Wait();
        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Wizards", "https://www.printables.com/model/1002252-wizard-collection-3/files").Wait();
        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Warlocks", "https://www.printables.com/model/1002249-warlock-collection-3/files").Wait();
        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Rogue", "https://www.printables.com/model/1002022-rogue-collection-3/files").Wait();
        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Monk", "https://www.printables.com/model/1001735-monk-collection-3/files").Wait();
        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Ranger", "https://www.printables.com/model/1001963-ranger-collection-3/files").Wait();
        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Fighter", "https://www.printables.com/model/1000389-fighter-collection-3/files").Wait();
        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Druid", "https://www.printables.com/model/999168-druid-collection-3/files").Wait();
        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Cleric", "https://www.printables.com/model/999150-cleric-collection-3/files").Wait();
        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Bard", "https://www.printables.com/model/999134-bard-collection-3/files").Wait();
        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Barbarian", "https://www.printables.com/model/998554-barbarian-collection-3/files").Wait();
        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Artificer", "https://www.printables.com/model/998538-artificer-collection-3/files").Wait();*/


        stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\MonsterManual", "https://www.printables.com/model/935575-the-updated-dd-monster-manual-collection/files").Wait();

        //stlDownloader.DownloadStlFilesAsync(@"C:\MyDownloads\Ranger", "https://www.printables.com/model/1001963-ranger-collection-3/files").Wait();


        // Task.WaitAll(tasks.ToArray());




        //// Set up Chrome options
        //ChromeOptions options = new ChromeOptions();
        //options.AddArgument("--start-maximized");

        //string downloadFolderPath = @"C:\MyDownloads\";


        //if (!System.IO.Directory.Exists(downloadFolderPath))
        //{
        //    System.IO.Directory.CreateDirectory(downloadFolderPath);
        //}

        //// Set Chrome options to configure download behavior
        //options.AddUserProfilePreference("download.default_directory", downloadFolderPath);
        //options.AddUserProfilePreference("download.prompt_for_download", false);
        //options.AddUserProfilePreference("download.directory_upgrade", true);
        //options.AddUserProfilePreference("safebrowsing.enabled", true);
        //options.AddArgument("--start-maximized");



        //// Initialize WebDriver
        //using (IWebDriver driver = new ChromeDriver(options))
        //{
        //    try
        //    {
        //        // Navigate to the page
        //        driver.Navigate().GoToUrl("https://www.printables.com/model/1001916-paladin-collection-3/files");

        //        // Wait for elements to load
        //        Thread.Sleep(5000);


        //        // Create explicit wait
        //        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //       // Accept cookie consent popup if it appears
        //        try
        //        {
        //            var consentButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(), 'I am OK with that')]")));
        //            consentButton.Click();
        //            Console.WriteLine("Accepted cookie consent.");
        //            Thread.Sleep(2000); // Wait for UI to stabilize
        //        }
        //        catch (WebDriverTimeoutException)
        //        {
        //            Console.WriteLine("No cookie popup found. Proceeding...");
        //        }

        //        driver.Navigate().GoToUrl("https://www.printables.com/model/1001916-paladin-collection-3/files");

        //        // Find all download buttons
        //        var downloadButtons = driver.FindElements(By.XPath("//button[contains(text(), 'Download')]")).ToList();

        //        Console.WriteLine($"Found {downloadButtons.Count} download buttons.");

        //        // Click each button
        //        foreach (var button in downloadButtons)
        //        {
        //            try
        //            {
        //                button.Click();
        //                Thread.Sleep(2000); // Small delay to allow downloads to process
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine($"Error clicking button: {ex.Message}");
        //            }
        //        }

        //        Console.WriteLine("Download clicks complete.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //    }
        //    finally
        //    {
        //        // Keep browser open for inspection (optional)
        //        Console.WriteLine("Press any key to close...");
        //        Console.ReadKey();
        //        driver.Quit();
        //    }
        //}
    }
}
