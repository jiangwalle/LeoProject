using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

using Autofac;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using RefactorMe.DontRefactor.Models;
using RefactorMe.DontRefactor.Data.Implementation;
using RefactorMe;
using RefactorMe.service;

namespace Test
{
	public class TestSolutionA
	{
		private ProductDataConsolidatorSolutionA _solutionA;

		public TestSolutionA()
		{
			var builder = new ContainerBuilder();
			builder.RegisterModule(new AutoMapperModule());
			builder.RegisterModule(new SolutionAModule());
			var container = builder.Build();
			_solutionA = container.Resolve<ProductDataConsolidatorSolutionA>();
		}

		public void TestGetProductsInNZDollor()
		{
			List<Product> products = _solutionA.Get();

			// Assert products is right
			foreach (var item in products)
			{
				Console.WriteLine(item);
			}
		}

		public void TestGetProductsInUSDollor()
		{
			List<Product> products = _solutionA.GetInUSDollars();
			// Assert products is right
			foreach (var item in products)
			{
				Console.WriteLine(item);
			}
		}

		public void TestGetProductsInEuroDollor()
		{
			List<Product> products = _solutionA.GetInEuros();
			// Assert products is right
			foreach (var item in products)
			{
				Console.WriteLine(item);
			}
		}
	}

	public class TestSolutionB
	{
		private ProductDataConsolidatorSolutionB _solutionB;

		public TestSolutionB()
		{
			var builder = new ContainerBuilder();
			builder.RegisterModule(new AutoMapperModule());
			builder.RegisterModule(new SolutionBModule());
			var container = builder.Build();
			_solutionB = container.Resolve<ProductDataConsolidatorSolutionB>();
		}

		public void TestGetProductsInNZDollor()
		{
			List<Product> products = _solutionB.Get();

			// Assert products is right
			foreach (var item in products)
			{
				Console.WriteLine(item);
			}
		}

		public void TestGetProductsInUSDollor()
		{
			List<Product> products = _solutionB.GetInUSDollars();
			// Assert products is right
			foreach (var item in products)
			{
				Console.WriteLine(item);
			}
		}

		public void TestGetProductsInEuroDollor()
		{
			List<Product> products = _solutionB.GetInEuros();
			// Assert products is right
			foreach (var item in products)
			{
				Console.WriteLine(item);
			}
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			// Note: Don't test solutionA and solutionB at the same time

			TestSolutionA solutionA = new TestSolutionA();
			solutionA.TestGetProductsInEuroDollor();

			//TestSolutionB solutionB = new TestSolutionB();
			//solutionB.TestGetProductsInNZDollor();
		}
	}
}
