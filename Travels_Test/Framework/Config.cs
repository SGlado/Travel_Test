using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Travels_Test
{
	public class Config
	{
		public string Browser;
		public string Login;
		public string Pass;
		public string Username;
		private static Config instance;
		private Config()
		{
			InitializeProperties();
		}
		public static Config Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Config();
				}
				return instance;
			}
		}
		public void InitializeProperties()
		{
			var streamReader = new StreamReader(File.OpenRead(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Config.csv"));
			List<string> column1 = new List<string>();
			while (!streamReader.EndOfStream)
			{
				column1.Add(streamReader.ReadLine());
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
	}
}