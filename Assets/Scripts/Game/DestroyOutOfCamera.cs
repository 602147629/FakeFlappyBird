using UnityEngine;

public class DestroyOutOfCamera : MonoBehaviour
{
	public GameObject toDestroy;

	void Awake()
	{
		if (toDestroy == null && renderer != null)
			toDestroy = gameObject;
		else
			enabled = false;
	}
	
	void OnBecameInvisible()
	{
		Destroy(toDestroy);
	}
}


