using UnityEngine;

public class ComponentTool
{
	public static void AddChild(GameObject parent, GameObject child)
	{
		if (!parent || !child) return;

		var transform = child.transform;
		transform.parent = parent.transform;
		transform.localPosition = Vector3.zero;
		transform.localRotation = Quaternion.identity;
		transform.localScale = Vector3.zero;
	}
}


