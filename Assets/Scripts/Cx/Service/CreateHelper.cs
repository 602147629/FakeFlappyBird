using System;

namespace CX
{
	/// <summary>
	/// Convenient static class to get an object instace.
	/// </summary>
	public class CreateHelper
	{
		/// <summary>
		/// Create the specified object by its type name.
		/// </summary>
		/// <param name="typeName">Type name.</param>
		public static object Create(string typeName)
		{
			object obj = null;

			Type type = Type.GetType(typeName);
			if (type != null)
			{
				obj = Activator.CreateInstance(type);
			}

			return obj;
		}

		/// <summary>
		/// Create the specified object by its type name.
		/// </summary>
		/// <param name="typeName">Type name.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static T Create<T>(string typeName) where T : class
		{
			return Create(typeName) as T;
		}
	}
}

