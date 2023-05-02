﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAzureWebApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAzureWebApp.Pages.Tests
{
	[TestClass()]
	public class UnitTests_IndexModelTests
	{
		private readonly IndexModel _indexModel;

		public UnitTests_IndexModelTests()
		{
			_indexModel = new IndexModel(null, null);
		}

		[TestMethod]
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
			Assert.AreEqual(12, _indexModel.add(9, 6));
		}
	}
}