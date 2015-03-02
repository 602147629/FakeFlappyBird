using CX.Obj;
using System;
using System.Collections.Generic;
using Game;

public class ObjectSpawner<T>
{
	bool isSpawn;
	IObjectPool<T> pool;
	Timer spawnTimer;
	IList<CountTimer> ptTimers = new List<CountTimer>();

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
		ptTimers.Add(putBackTimer);
		putBackTimer.Elapsed += delegate {
			pool.PutBack(obj);
			ptTimers.Remove(putBackTimer);
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

		foreach (var p in ptTimers)
		{
			p.Stop();
		}
		ptTimers.Clear();
	}
}