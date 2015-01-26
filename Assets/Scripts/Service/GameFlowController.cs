using UnityEngine;

public class GameFlowController : IGameFlow
{
	public void Start()
	{
		Application.LoadLevel(LevelConfig.LEVEL);
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
