using UnityEngine;

/// <summary>
/// View initializer.
/// Use to create views.
/// </summary>
public class ViewInitializer : MonoBehaviour
{
	public GameObject uiRoot;

	ViewManager viewMgr;

	void Awake()
	{
		viewMgr = new ViewManager();
		
		MonoView[] views = Resources.FindObjectsOfTypeAll<MonoView>();
		foreach (MonoView view in views)
		{
			MonoView monoView= viewMgr.CreateView(view.name) as MonoView;
			AddToUIRoot(monoView.gameObject);
		}
	}

	void AddToUIRoot(GameObject view)
	{
		ComponentTool.AddChild(uiRoot, view);
	}

}
