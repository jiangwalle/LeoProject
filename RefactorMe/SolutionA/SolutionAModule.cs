using System;
using Autofac;
using AutoMapper;

using RefactorMe.service;
using RefactorMe.DontRefactor.Models;
using RefactorMe.DontRefactor.Data.Implementation;

namespace RefactorMe
{
	public class SolutionAModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CurrencyServiceInMemory>().As<ICurrencyService>().SingleInstance();
			builder.RegisterType<LawnmowerRepository>().As<BaseReadOnlyRepository<Lawnmower>>().SingleInstance();
			builder.RegisterType<PhoneCaseRepository>().As<BaseReadOnlyRepository<PhoneCase>>().SingleInstance();
			builder.RegisterType<TShirtRepository>().As<BaseReadOnlyRepository<TShirt>>().SingleInstance();
			builder.RegisterType<LawnmowerService>().AsSelf();
			builder.RegisterType<PhoneCaseService>().AsSelf();
			builder.RegisterType<TShirtService>().AsSelf();
			builder.RegisterType<ProductDataConsolidatorSolutionA>().AsSelf().SingleInstance();
		}
	}
}