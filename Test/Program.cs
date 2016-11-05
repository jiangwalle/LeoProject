using System;
using System.Collections.Generic;

using AutoMapper;
using AutoMapper.QueryableExtensions;
using RefactorMe.DontRefactor.Models;
using RefactorMe.DontRefactor.Data.Implementation;


namespace Test
{
	public class Source
	{
		public int Value1 { get; set; }
		public int Value2 { get; set; }
	}

	public class Destination
	{
		public int Total { get; set; }
	}

	class MainClass
	{
		public static void test()
		{
			List<object> repos = new List<object>();

			repos.Add(new LawnmowerRepository());

			foreach(var i in repos) {
				Type type = i.GetType();
				Console.WriteLine(type.Name);
			}
		}

		public static void Main(string[] args)
		{
			//Mapper.Initialize(cfg =>
			// 			cfg.CreateMap<Source, Destination>()
			//                  .ForMember(dest => dest.Total, opt => opt.ResolveUsing<CustomResolver>()));

			// 		Mapper.AssertConfigurationIsValid();

			//var source = new Source
			//{
			//	Value1 = 5,
			//	Value2 = 7
			//};

			//var result = Mapper.Map<Source, Destination>(source);

			//Console.WriteLine(result.Total);

			test();
		}
	}
}
