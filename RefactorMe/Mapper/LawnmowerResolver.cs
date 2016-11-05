using System;
using AutoMapper;

using RefactorMe.DontRefactor.Models;

namespace RefactorMe
{
	public class LawnmowerResolver : IValueResolver<Lawnmower, Product, string>
	{
		public string Resolve(Lawnmower source, Product destination, string member, ResolutionContext context)
		{
			return "Lawnmower";
		}
	}
}
