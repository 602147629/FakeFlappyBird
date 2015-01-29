using UnityEngine;
using CX.MVP.View;
using CX.U3D.MVP.View;

namespace Game
{
	/// <summary>
	/// View initializer.
	/// Use to create views.
	/// </summary>
	public class ViewInitializer
	{
		GameObject uiRoot;
		
		IViewManager viewMgr;
        
		IViewFlow viewFlow;

		public IViewFlow ViewFlow
        {
            get
            {
                return viewFlow;
            }
        }

		public ViewInitializer()
		{
			
		}
		
		public void InitView()
		{
			uiRoot = GameObject.FindGameObjectWithTag("UIROOT");
			viewMgr = new U3DViewManager();
			
			Object[] views = Resources.LoadAll("View");
			foreach (var view in views)
			{
				U3DView monoView= viewMgr.CreateView<U3DView>(view);
				AddToUIRoot(monoView.gameObject);
			}
			viewFlow = (viewMgr as U3DViewManager).ViewFlow;

			viewFlow.Forward("WelcomeView");
		}
		
		void AddToUIRoot(GameObject view)
		{
			ComponentTool.AddChild(uiRoot, view);
		}
	}
}
