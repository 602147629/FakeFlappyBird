using UnityEngine;
using System.Collections;

public class MainTest : MonoBehaviour {

	CountTimer ct;

	// Use this for initialization
	IEnumerator Start () {
		ct = new CountTimer(5);
		//ct.TotalCount = 5;

		ct.Elapsed += HandleElapsed;
		//ct.Start();

		for (int i = 0; i < 3; i ++)
			StartCoroutine(E ());

		yield return new WaitForSeconds(3);
		StopCoroutine("E");
	}

	IEnumerator E()
	{
		while (true)		
		{
			yield return new WaitForSeconds(1);
			Debug.Log(Time.time);
		}
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
