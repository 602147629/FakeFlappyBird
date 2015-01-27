using UnityEngine;

public class ComponentTool
{
	public static void AddChild(GameObject parent, GameObject child)
	{
		if (!parent || !child) return;

		var transform = child.transform;

		transform.SetParent(parent.transform, false);
	}

	public static void Destroy(GameObject toDestroy)
	{
		#if UNITY_EDITOR
		GameObject.DestroyImmediate(toDestroy);
		#else
		GameObject.Destroy(toDestroy);
		#endif
	}

}