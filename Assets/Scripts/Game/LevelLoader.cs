using UnityEngine;
using System.Collections;
using System;

namespace Game
{
	public class LevelLoader : MonoBehaviour 
	{
		static Action LoadCompleted;

		static LevelLoader()
		{
			new GameObject("LevelLoader").AddComponent<LevelLoader>();
		}

		void Awake()
		{
			DontDestroyOnLoad(gameObject);
		}

		public static void LoadLevel(string levelName)
		{
			Application.LoadLevel(levelName);
		}

		public static void LoadLevel(string levelName, Action loadCompleted)
		{
			LoadCompleted = loadCompleted;
			Load (levelName);
		}

		static void Load (string levelName)
		{
			Application.LoadLevel (levelName);
		}

		void OnLevelWasLoaded(int level) 
		{
			if (Application.loadedLevel == level)
			{
				if (LoadCompleted != null)
					LoadCompleted();
				LoadCompleted = null;
			}
		}

	}
}

