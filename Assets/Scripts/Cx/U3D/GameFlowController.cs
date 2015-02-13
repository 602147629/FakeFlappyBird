using UnityEngine;
using Game;
using Game.Character;
using CX.U3D.Character;
using CX.Obj;
using CX.U3D;
using CX.U3D.Obj;
using Level;

public class GameFlowController : IGameFlow
{
	//IObjectPool objectPool = GameFacade.ObjectPool;

	public void Start()
	{
		LevelLoader.LoadLevel(LevelConfig.LEVEL, delegate() {
			//objectPool.RegCreater(new U3DPooledObjectCreater(new UpBlockBornVO()));
			//objectPool.RegCreater(new U3DPooledObjectCreater(new DownBlockBornVO()));

			IObjectPool<BlockerCharacter> pool1 = new ObjectPool<BlockerCharacter>(new CxGameObjectPooled<BlockerCharacter>(new DownBlockBornVO()), 20);
			IObjectPool<BlockerCharacter> pool2 = new ObjectPool<BlockerCharacter>(new CxGameObjectPooled<BlockerCharacter>(new UpBlockBornVO()), 20);

			new GameObject().AddComponent<ObjectSpawner>().StartSpawn(pool1);
			new GameObject().AddComponent<ObjectSpawner>().StartSpawn(pool2);
			//var createMain = new U3DObjectCreater();
			//createMain.Create(new MainCharacterBornVO());

			MainCharacter m = new MainCharacter(new MainCharacterBornVO());
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
