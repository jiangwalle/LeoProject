using System;
using AutoMapper;

using RefactorMe.DontRefactor.Models;

namespace Test
{
	public class RefactorMeMapperProfile : Profile
	{
		protected override void Configure()
		{
			Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<Lawnmower, Product>()
					.ForMember(dest => dest.Type, opt => opt.ResolveUsing<ProductTypeResolver>());
				cfg.CreateMap<PhoneCase, Product>()
					.ForMember(dest => dest.Type, opt => opt.ResolveUsing<ProductTypeResolver>());
				cfg.CreateMap<TShirt, Product>()
					.ForMember(dest => dest.Type, opt => opt.ResolveUsing<ProductTypeResolver>());
			});
		}
	}
}
