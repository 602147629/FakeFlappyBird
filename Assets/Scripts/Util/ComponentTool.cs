using UnityEngine;

public class ComponentTool
{
	public static void AddChild(GameObject parent, GameObject child)
	{
		if (!parent || !child) return;

		var transform = child.transform;

		transform.SetParent(parent.transform, false);
	}
}


public class P : MonoBehaviour
{
	[SerializeField]
	protected int a;

	public int A
	{
		get { return a; }
	}
}

public class C : P
{

}