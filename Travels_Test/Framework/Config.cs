using OpenQA.Selenium;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Travels_Test
    {
    public class Config
        {
        public IWebDriver Driver;
        public static string Browser;
        public static string Login;
        public static string Pass;
        public static string Username;
        public static Config instance;
        public Config() { }
        public static Config Instance
            {
            get
                {
                if (instance == null)
                    {
                    var instance = new StreamReader(File.OpenRead(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Config.csv"));
                    List<string> column1 = new List<string>();
                    while (!instance.EndOfStream)
                        {
                        column1.Add(instance.ReadLine());
                        }
                    string login = column1[0];
                    string pass = column1[1];
                    string username = column1[2];
                    string browser = column1[3];
                    Login = login;
                    Pass = pass;
                    Username = username;
                    Browser = browser;
                    }
                return instance;
                }
            }
        }
    }
