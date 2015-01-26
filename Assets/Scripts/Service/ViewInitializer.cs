using UnityEngine;

/// <summary>
/// View initializer.
/// Use to create views.
/// </summary>
public class ViewInitializer : MonoBehaviour
{
	public GameObject uiRoot;

	IViewManager viewMgr;
	IViewFlow viewFlow;

	void Awake()
	{
		viewMgr = new ViewManager();
		
		Object[] views = Resources.LoadAll("View");
		foreach (Object view in views)
		{
			MonoView monoView= viewMgr.CreateView<MonoView>(view);
			AddToUIRoot(monoView.gameObject);
		}

		viewFlow = new ViewFlow(viewMgr);
		viewFlow.Forward("WelcomePanel");
	}

	void AddToUIRoot(GameObject view)
	{
		ComponentTool.AddChild(uiRoot, view);
	}
}
