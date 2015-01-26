using UnityEngine;
using System.Collections.Generic;

public class ViewManager : IViewManager
{
	public static readonly IView EmptyView = new NullView();

	public ViewManager ()
	{
		viewDic = new Dictionary<string, IView>();
	}

	public IView GetView(string viewName)
	{
		IView view = EmptyView;
		if (viewDic.ContainsKey(viewName))
		{
			view = viewDic[viewName];
		}
		return view;
	}

	public TView GetView<TView>(string viewName) where TView : class, IView
	{
		return GetView(viewName) as TView;
	}	

	public IView CreateView(object viewResource)
	{
		IView view = EmptyView;
		UnityEngine.Object res = viewResource as UnityEngine.Object;
		if (res != null)
		{
			var resName = res.name;
			var gameObject = GameObject.Instantiate (res) as GameObject;
			if (gameObject != null)
			{
				view = gameObject.GetComponent<MonoView>();
				if (view != null)
				{
					viewDic.Add (resName, view);
					view.ViewName = resName;
				}
			}
		}
		else
		{
			view = EmptyView;
		}
		return view;
	}

	public TView CreateView<TView>(object viewResource) where TView : class, IView
	{
		return CreateView(viewResource) as TView;
	}

	IDictionary<string, IView> viewDic;

	public class NullView : IView
	{
		public void Show(bool isShow)
		{
			Debug.Log(ToString());
		}

		public override string ToString()
		{
			return string.Format("[NullView]");
		}

		public string ViewName
		{
			get; set;
		}
	}
}


