using System;
using AutoMapper;

using RefactorMe.DontRefactor.Models;

namespace RefactorMe
{
	public class SolutionAProfile : Profile
	{
		protected override void Configure()
		{
			CreateMap<Lawnmower, Product>()
				.ForMember(dest => dest.Type, opt => opt.ResolveUsing<LawnmowerResolver>());
			CreateMap<PhoneCase, Product>()
				.ForMember(dest => dest.Type, opt => opt.ResolveUsing<PhoneCaseResolver>());
			CreateMap<TShirt, Product>()
				.ForMember(dest => dest.Type, opt => opt.ResolveUsing<TShirtResolver>());
		}
	}
}
