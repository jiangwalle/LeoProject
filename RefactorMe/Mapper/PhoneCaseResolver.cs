using System;
using AutoMapper;

using RefactorMe.DontRefactor.Models;

namespace RefactorMe
{
	public class PhoneCaseResolver : IValueResolver<PhoneCase, Product, string>
	{
		public string Resolve(PhoneCase source, Product destination, string member, ResolutionContext context)
		{
			return "Phone Case";
		}
	}
}
