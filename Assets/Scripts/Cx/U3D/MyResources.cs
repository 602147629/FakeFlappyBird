using UnityEngine;
using System.Collections.Generic;

namespace CX.U3D
{
	/// <summary>
	/// My resources.
	/// Caches all resources in game. NOTICE to UNLOAD resources!
	/// </summary>
	public class MyResources
	{
		public static Object Load(string resPath)
		{
			Object res = null;
			if (!resMap.TryGetValue(resPath, out res))
			{
				res = Resources.Load(resPath);
				if (res != null)
				{
					resMap.Add(resPath, res);
				}
				else
				{
					MyDebug.Log(string.Format("Can not find resource at {0}", resPath));
				}
			}
			return res;
		}

		public static T Load<T>(string resPath) where T : Object
		{
			return Resources.Load<T>(resPath); 
		}

		private static Dictionary<string, Object> resMap = new Dictionary<string, Object>();

		public static void Clear()
		{
			resMap.Clear();
		}
	}
}
