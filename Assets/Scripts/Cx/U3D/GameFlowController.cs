using UnityEngine;
using Game;
using CX.U3D.Character;

public class GameFlowController : IGameFlow
{
	public void Start()
	{
		//Application.LoadLevel(LevelConfig.LEVEL);
		LevelLoader.LoadLevel(LevelConfig.LEVEL, delegate() {
			CharacterFactory.Create("bird");
		});
	}

	public void Restart()
	{

	}

	public void Pause()
	{
		Time.timeScale = 0;
	}

	public void Resume()
	{
		Time.timeScale = 1;
	}

	public void Stop()
	{
		Application.LoadLevel(LevelConfig.WELCOME);
	}
}
