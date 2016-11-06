using System;
using Autofac;
using AutoMapper;

using RefactorMe.service;

namespace RefactorMe
{
	public class SolutionBModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CurrencyServiceInMemory>().As<ICurrencyService>().SingleInstance();
			builder.RegisterType<ProductConsolidatorService>().As<IProductConsolidatorService>().SingleInstance();
			builder.RegisterType<ProductDataConsolidatorSolutionB>().AsSelf().SingleInstance();
		}
	}
}