/// <summary>
/// Unity GameObject that don't destory on load.
/// </summary>
using UnityEngine;

public class DontDestroy : MonoBehaviour {

	public GameObject dontDestroy;

	void Awake()
	{
		if (dontDestroy == null) dontDestroy = gameObject;
		DontDestroyOnLoad(dontDestroy);
	}

}
