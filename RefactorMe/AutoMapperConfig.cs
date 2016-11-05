using System;
using AutoMapper;

using RefactorMe.DontRefactor.Models;

namespace RefactorMe
{
	public class AutoMapperConfig
	{
		public static void RegisterMappings()
		{
			Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<TShirt, Product>().
						ForMember(dest => dest.Type, opt => opt.ResolveUsing<TShirtResolver>());

				cfg.CreateMap<PhoneCase, Product>().
						ForMember(dest => dest.Type, opt => opt.ResolveUsing<PhoneCaseResolver>());

				cfg.CreateMap<Lawnmower, Product>().
						ForMember(dest => dest.Type, opt => opt.ResolveUsing<LawnmowerResolver>());
			});
		}
	}
}
