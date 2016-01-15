using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using selenium_third.src;
using OpenQA.Selenium.Support.UI;

namespace selenium_third {
	class Program {
		static void Main(string[] args) {}		

		[SetUp]
		public void Initialize() {
			PropertiesCollection.driver  = new ChromeDriver();
			Console.WriteLine("Start test");
			PropertiesCollection.driver.Navigate().GoToUrl("http://2gis.ru/countries/global");
			Console.WriteLine("Go to http://2gis.ru/countries/global");
		}

		[Test]
		public void ExecuteTestInputExistentTown_1() {
			IWebElement town = PropertiesCollection.driver.FindElement(By.ClassName("world__searchInput"));
			Console.WriteLine("Select the line with -Input the name of the town-");
			town.SendKeys("Новосибирск");
			Console.WriteLine("Input in the line -Новосибирск- ");
		}

		[Test]
		public void ExecuteTestInputExistentTownByLatin_6() {
			IWebElement town = PropertiesCollection.driver.FindElement(By.ClassName("world__searchInput"));
			Console.WriteLine("Select the line with -Input the name of the town-");
			town.SendKeys("Vjcrdf");
			Console.WriteLine("Input in the line -Vjcrdf-");
		}

		[TearDown]
		public void CleanUp() {
			PropertiesCollection.driver.Close();
			Console.WriteLine("End test");
		}
	}
}
