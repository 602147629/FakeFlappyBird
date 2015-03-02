using CX.Obj;
using System;
using System.Collections;
using Game;

public class ObjectSpawner<T>
{
	bool isSpawn;
	IObjectPool<T> pool;
	Timer spawnTimer;

	public ObjectSpawner(IObjectPool<T> pool)
	{
		this.pool = pool;
		spawnTimer = new Timer();
		spawnTimer.Elapsed += HandleSpawnElapsed;

		GameFacade.GameFlow.GamePause += (sender, e) => StopSpawn();
		GameFacade.GameFlow.GameResume += (sender, e) => StartSpawn();
		GameFacade.GameFlow.GameStop += (sender, e) => StopSpawn();
	}

	void HandleSpawnElapsed (float nowCount)
	{
		T obj = pool.GetOne();
		CountTimer putBackTimer = new CountTimer(10, 1);
		putBackTimer.Elapsed += delegate {
			pool.PutBack(obj);
				};
		putBackTimer.Start();
	}

	public void StartSpawn()
	{
		spawnTimer.Start();
	}

	public void StopSpawn()
	{
		spawnTimer.Stop();
	}
}