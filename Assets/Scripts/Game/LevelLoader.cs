using UnityEngine;
using System.Collections;
using System;

namespace Game
{
	public class LevelLoader : MonoBehaviour 
	{
		static Action LoadCompleted;

		public static void LoadLevel(string levelName)
		{
			Application.LoadLevel(levelName);
		}

		public static void LoadLevel(string levelName, Action loadCompleted)
		{
			Application.LoadLevel(levelName);
			LoadCompleted = loadCompleted;
		}

		void OnLevelWasLoaded(int level) 
		{
			if (Application.loadedLevel == level)
			{
				if (LoadCompleted != null)
					LoadCompleted();
			}
		}

	}
}

