using UnityEngine;
using System.Collections.Generic;
using System;

public class Loop : MonoBehaviour
{
	public static event Action UpdateEvent;

	static Loop()
	{
		new GameObject("Looping").AddComponent<Loop>();
	}

	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	void Update()
	{
		if (UpdateEvent != null)
			UpdateEvent();
	}
}
