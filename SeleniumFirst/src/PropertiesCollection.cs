using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace selenium_third.src {

	enum PropertyType { Id, Name, ClassName }

	class PropertiesCollection {

		public static IWebDriver driver { get; set; }
	}
}
