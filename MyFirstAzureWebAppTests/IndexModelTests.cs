using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAzureWebApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAzureWebApp.Pages.Tests
{
	[TestClass()]
	public class IndexModelTests
	{
		private readonly IndexModel _indexModel;
		public IndexModelTests(IndexModel indexModel)
		{
			_indexModel = indexModel;
		}

		[TestMethod()]
		public void addTest()
		{
			Assert.Fail();
		}
		public void Add_ByAddingTwoNumbers_returns_sum_of_numbers()
		{
			//Arrange
			var a = 4;
			var b = 5;
			//Act
			var result = _indexModel.add(a, b);
			//Assert
			Assert.AreEqual(9, result);
		}

		[TestMethod]
		public void Add_ByAddingTwoNumbers_returns_sum_of_numbers_smart()
		{
			Assert.AreEqual(13, _indexModel.add(6, 7));
		}
	}

}