using System;
using AutoMapper;

using RefactorMe.DontRefactor.Models;

namespace RefactorMe
{
	public class SolutionBProfile : Profile
	{
		protected override void Configure()
		{
			CreateMap<Lawnmower, Product>()
					.ForMember(dest => dest.Type, opt => opt.ResolveUsing<ProductTypeResolver>());
			CreateMap<PhoneCase, Product>()
					.ForMember(dest => dest.Type, opt => opt.ResolveUsing<ProductTypeResolver>());
			CreateMap<TShirt, Product>()
					.ForMember(dest => dest.Type, opt => opt.ResolveUsing<ProductTypeResolver>());
		}
	}
}
