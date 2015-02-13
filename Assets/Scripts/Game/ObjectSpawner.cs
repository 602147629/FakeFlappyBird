using UnityEngine;
using CX.Obj;
using System;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{
	bool isSpawn;

	public void StartSpawn<T>(IObjectPool<T> pool)
	{
		isSpawn = true;
		StartCoroutine(Spwan<T>(pool));
	}

	IEnumerator Spwan<T>(IObjectPool<T> pool)
	{
		while (isSpawn)
		{
			T obj = pool.GetOne();
			StartCoroutine(PutBack<T>(pool, obj));
			yield return new WaitForSeconds(1);
		}
		yield return null;
	}

	IEnumerator PutBack<T>(IObjectPool<T> pool, T obj)
	{
		yield return new WaitForSeconds(15);
		pool.PutBack(obj);
	}

	public void StopSpawn()
	{
		isSpawn = false;
	}
}