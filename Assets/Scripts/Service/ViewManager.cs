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
		viewDic.TryGetValue(viewName, out view);
		return view;
	}

	public TView GetView<TView>(string viewName) where TView : class, IView
	{
		return GetView(viewName) as TView;
	}	

	public IView CreateView(string viewName)
	{
		IView view = EmptyView;
		Object res = Resources.Load("View/" + viewName);
		if (res != null && !viewDic.ContainsKey(viewName))
		{
			view = (GameObject.Instantiate(res) as GameObject).GetComponent<MonoView>();
			viewDic.Add(viewName, view);
			view.ViewName = viewName;
		}
		else
		{
			view = EmptyView;
		}
		return view;
	}

	public TView CreateView<TView>(string viewName) where TView : class, IView
	{
		return CreateView(viewName) as TView;
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


