//This class is auto-generated do not modify
namespace Constants
{
	public static class Scenes
	{
		public const string WELCOME = "Welcome";
		public const string LEVEL = "Level";
		public const string EMPTY = "Empty";

		public const int TOTAL_SCENES = 3;


		public static int nextSceneIndex()
		{
			if( UnityEngine.Application.loadedLevel + 1 == TOTAL_SCENES )
				return 0;
			return UnityEngine.Application.loadedLevel + 1;
		}
	}
}