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
}
