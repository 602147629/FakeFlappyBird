using UnityEngine;

namespace CX.U3D 
{
	/// <summary>
	/// My debug.
	/// Wraps unity's debug is necessary.
	/// </summary>
	public class MyDebug
	{
		public static void Log(object message, Object context = null)
		{
			Debug.Log(message, context);
		}

		public static void LogError(object message, Object context = null)
		{
			Debug.LogError(message, context);
		}

		public static void LogWarning(object message, Object context = null)
		{
			Debug.LogWarning(message, context);
		}

		public static void LogException(System.Exception exception, Object context = null)
		{
			Debug.LogException(exception, context);
		}
	}
}

