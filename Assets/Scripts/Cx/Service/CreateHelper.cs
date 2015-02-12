using System;

namespace CX
{
	/// <summary>
	/// Convenient static class to get an object instace.
	/// </summary>
	public class CreateHelper
	{
		public static object Create(Type type, params object[] objects)
		{
			object obj = null;

			if (type != null)
			{
				obj = Activator.CreateInstance(type, objects);
			}

			return obj;
		}

		/// <summary>
		/// Create the specified object by its type name.
		/// </summary>
		/// <param name="typeName">Type name.</param>
		/// <typeparam name="T">The constructor's parameters.</typeparam>
		public static T Create<T>(string typeName, params object[] objects)
		{
			return Create<T>(Type.GetType(typeName), objects);
		}

		/// <summary>
		/// Create the specified object by its type.
		/// </summary>
		/// <param name="type">Type.</param>
		/// <param name="objects">Objects.</param>
		/// <typeparam name="T">The constructor's parameters.</typeparam>
		public static T Create<T>(Type type, params object[] objects)
		{
			if (type != null)
			{
				object obj = Create(type, objects);
				if (obj is T)
				{
					return (T)obj;
				}
			}
			return default(T);
		}

		/// <summary>
		/// Create the specified objects, using type of T.
		/// </summary>
		/// <param name="objects">Objects.</param>
		/// <typeparam name="T">The constructor's parameters.</typeparam>
		public static T Create<T>(params object[] objects)
		{
			object obj = Create(typeof(T), objects);
			if (obj is T)
			{
				return (T)obj;
			}
			return default(T);
		}
	}
}

