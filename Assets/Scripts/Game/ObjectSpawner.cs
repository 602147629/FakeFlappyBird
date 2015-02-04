using UnityEngine;
using CX.Obj;
using System;


public class ObjectSpawner : MonoBehaviour
{
	IObjectPool pool;
	Type bornType;

	public void StartSpawn(IObjectPool pool, Type bornType)
	{
		this.pool = pool;
		this.bornType = bornType;

		InvokeRepeating("Spawn", 0, 1);
	}

	public void StopSpawn()
	{
		CancelInvoke("Spawn");
	}

	void Spawn()
	{
		pool.GetOne(bornType);
	}
}


