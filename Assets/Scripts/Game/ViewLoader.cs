using UnityEngine;
using CX.MVP.View;
using CX.U3D.MVP.View;

namespace Game
{
	/// <summary>
	/// View Loader
	/// Use to create views.
	/// </summary>
	public class ViewLoader
	{
		GameObject uiRoot;
		Canvas uiCanvas;
		
		IViewManager viewMgr;

		public ViewLoader(IViewManager viewMgr)
		{
			this.viewMgr = viewMgr;
		}


		public void LoadView()
		{
			uiRoot = GameObject.FindGameObjectWithTag("UIROOT");
			uiRoot.AddComponent<DontDestroy>();
			uiCanvas = uiRoot.GetComponentInChildren<Canvas>();
			
			Object[] views = Resources.LoadAll("View");
			foreach (var view in views)
			{
				U3DView monoView= viewMgr.CreateView<U3DView>(view);
				AddToUIRoot(monoView.gameObject);
			}
		}
		
		void AddToUIRoot(GameObject view)
		{
			ComponentTool.AddChild(uiCanvas.gameObject, view);
		}
	}
}
