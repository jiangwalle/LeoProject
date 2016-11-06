using System;
using Autofac;
using AutoMapper;

using RefactorMe.service;

namespace RefactorMe
{
	public class AutoMapperModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.Register(context =>
			{
				var config = new MapperConfiguration(x =>
				{
					x.AddProfile(new SolutionBProfile());
				});

				return config;
			}).SingleInstance()
			.AutoActivate()
			.AsSelf();

			builder.Register(context =>
			{
				var ctx = context.Resolve<IComponentContext>();
				var config = ctx.Resolve<MapperConfiguration>();
				return config.CreateMapper();
			}).As<IMapper>();
		}
	}
}
