﻿using UnityEngine;
using System.Collections;

public class MainTest : MonoBehaviour {

	CountTimer ct;

	// Use this for initialization
	void Start () {
		ct = new CountTimer(5);
		//ct.TotalCount = 5;

		ct.Elapsed += HandleElapsed;
		ct.Start();
	}

	void HandleElapsed (float nowCount)
	{
		Debug.Log(nowCount);
		if (nowCount == ct.TotalCount)
		{
			ct.Close();
			ct.Elapsed += HandleElapsed;
			ct.Start();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
