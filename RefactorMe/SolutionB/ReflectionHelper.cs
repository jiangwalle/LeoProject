using System;
using System.Reflection;
using System.Collections.Generic;

namespace RefactorMe
{
	public class ReflectionHelper
	{
		/// <summary>
		/// Return all repositories from RefactorMe.DontRefactor Assembly 
		/// </summary>
		/// <returns>The all repos.</returns>
		public static List<Type> GetAllRepos()
		{
			List<Type> repos = new List<Type>();
			foreach (var item in Assembly.Load("RefactorMe.DontRefactor").GetTypes())
			{
				string name = item.Name;

				if (name.EndsWith("Repository")
					&& !name.Equals("BaseReadOnlyRepository")
					&& !name.Equals("IReadOnlyRepository"))
				{
					repos.Add(item);
				}
			}

			return repos;
		}
	}
}
