using OpenQA.Selenium;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System;
using CsvHelper.Configuration;

namespace Travels_Test
{
    public class Config
    {
        public IWebDriver Driver { get; set; }
        public string Browser;
        public string Login;
        public string Pass;
        public string Username;
        public void GetBrowserFromFile()
        {
            var reader = new StreamReader(File.OpenRead(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Config.csv"));
            List<string> column1 = new List<string>();
            while (!reader.EndOfStream)
            {
                column1.Add(reader.ReadLine());
            }
            Browser = column1[3];
        }
        public void GetLoginFromFile()
        {
            var reader = new StreamReader(File.OpenRead(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Config.csv"));
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
