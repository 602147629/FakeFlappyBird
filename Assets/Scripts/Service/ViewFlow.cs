using System;
using System.Collections.Generic;

public class ViewFlow : IViewFlow
{
	public ViewFlow (IViewManager viewMgr)
	{
		this.viewMgr = viewMgr;
	}

	public void Forward(string viewName)
	{
		if (HasView())
			views.Peek().Show(false);
		
		IView view = viewMgr.GetView(viewName);
		views.Push(view);
		view.Show(true);
	}

	public IView Back()
	{
		IView back = ViewManager.EmptyView;
		if (!HasView()) return back;

		IView view = views.Pop();
		view.Show(false);

		back = views.Peek ();
		back.Show (true);
		return back;
	}

	public IView Back(string viewName)
	{
		IView back = Back ();
		string backViewName = back.ViewName;
		if (viewName != backViewName)		
			Back(backViewName);
		return back;
	}

	public IView CurrentView 
	{
		get 
		{
			return HasView() ? views.Peek() : ViewManager.EmptyView;
		}
	}

	bool HasView()
	{
		return views.Count != 0;
	}

	IViewManager viewMgr;
	Stack<IView> views = new Stack<IView>();
}


