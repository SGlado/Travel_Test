using OpenQA.Selenium;
using System.Collections.Generic;
using System.IO;

namespace Travels_Test
{
    public class Config
    {
        public IWebDriver Driver { get; set; }
        public static string Browser;
        public static void GetBrowserFromFile()
        {
            var reader = new StreamReader(File.OpenRead(@"D:\HELP\AUTOMATION\SGlado\Travels_Test\Config.csv"));
            List<string> column1 = new List<string>();
            while (!reader.EndOfStream)
            {
                column1.Add(reader.ReadLine());
            }
            Browser = column1[3];
        }
        public static string Login;
        public static string Pass;
        public static string Username;
        public static void GetLoginFromFile()
        {
            var reader = new StreamReader(File.OpenRead(@"D:\HELP\AUTOMATION\SGlado\Travels_Test\Config.csv"));
            List<string> column1 = new List<string>();

            while (!reader.EndOfStream)
            {
                column1.Add(reader.ReadLine());
            }
            string login = column1[0];
            string pass = column1[1];
            string username = column1[2];
            Login = login;
            Pass = pass;
            Username = username;
        }
    }
}
