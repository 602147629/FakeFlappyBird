using UnityEngine;
using Game;
using CX.U3D.Character;
using CX.Obj;

public class GameFlowController : IGameFlow
{
	CharacterFactory characterFactory = new CharacterFactory();
	IObjectPool objectPool = new ObjectPool();

	public void Start()
	{
		LevelLoader.LoadLevel(LevelConfig.LEVEL, delegate() {
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
