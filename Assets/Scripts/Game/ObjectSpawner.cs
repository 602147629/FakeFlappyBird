using UnityEngine;
using CX.Obj;
using System;
using System.Collections;
using Game;

public class ObjectSpawner<T>
{
	bool isSpawn;
	IObjectPool<T> pool;
	MonoBehaviour _m;

	public ObjectSpawner(IObjectPool<T> pool)
	{
		this.pool = pool;
		_m = new GameObject ().AddComponent<MonoBehaviour>();

		GameFacade.GameFlow.GamePause += (sender, e) => StopSpawn();
		GameFacade.GameFlow.GameResume += (sender, e) => StartSpawn();
		GameFacade.GameFlow.GameStop += (sender, e) => StopSpawn();
	}

	public void StartSpawn()
	{
		isSpawn = true;
		_m.StartCoroutine(Spwan());
	}

	IEnumerator Spwan()
	{
		while (isSpawn)
		{
			T obj = pool.GetOne();
			_m.StartCoroutine(PutBack(obj));
			yield return new WaitForSeconds(1);
		}
		yield return null;
	}

	IEnumerator PutBack(T obj)
	{
		yield return new WaitForSeconds(15);
		pool.PutBack(obj);
	}

	public void StopSpawn()
	{
		isSpawn = false;
		_m.StopAllCoroutines();
	}
}