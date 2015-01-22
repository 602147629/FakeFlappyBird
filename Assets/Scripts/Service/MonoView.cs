using UnityEngine;

public class MonoView : MonoBehaviour, IView
{
	public virtual void Show(bool isShow)
	{
		gameObject.SetActive(isShow);
	}

	public string ViewName
	{
		get; set;
	}
}


