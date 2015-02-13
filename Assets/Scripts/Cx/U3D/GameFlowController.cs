using UnityEngine;
using Game;
using Game.Character;
using CX.U3D.Character;
using CX.Obj;
using CX.U3D;
using CX.U3D.Obj;
using Level;
using System;

public class GameFlowController : IGameFlow
{
	//IObjectPool objectPool = GameFacade.ObjectPool;
	public event EventHandler GameStart;

	public event EventHandler GameRestart;

	public event EventHandler GamePause;

	public event EventHandler GameResume;

	public event EventHandler GameStop;

	public event EventHandler GameExit;

	
	public void Start()
	{
		LevelLoader.LoadLevel(LevelConfig.LEVEL, delegate() {

			IObjectPool<BlockerCharacter> pool1 = new ObjectPool<BlockerCharacter>(new CxGameObjectPooled<BlockerCharacter>(new DownBlockBornVO()), 20);
			IObjectPool<BlockerCharacter> pool2 = new ObjectPool<BlockerCharacter>(new CxGameObjectPooled<BlockerCharacter>(new UpBlockBornVO()), 20);

			new ObjectSpawner<BlockerCharacter>(pool1).StartSpawn();
			new ObjectSpawner<BlockerCharacter>(pool2).StartSpawn();

			MainCharacter m = new MainCharacter(new MainCharacterBornVO());

			if (GameStart != null)
				GameStart(this, EventArgs.Empty);
		});
	}

	public void Restart()
	{
		if (GameRestart != null)
			GameRestart(this, EventArgs.Empty);
	}

	public void Pause()
	{
		//Time.timeScale = 0;
		if (GamePause != null)
			GamePause(this, EventArgs.Empty);
	}

	public void Resume()
	{
		//Time.timeScale = 1;
		if (GameResume != null)
			GameResume(this, EventArgs.Empty);
	}

	public void Stop()
	{
		if (GameStop != null)
			GameStop(this, EventArgs.Empty);
	}

	public void Exit()
	{
		if (GameExit != null)
			GameExit(this, EventArgs.Empty);
		Application.LoadLevel("Empty");
	}

}
