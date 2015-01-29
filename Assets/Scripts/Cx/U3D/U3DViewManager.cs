using UnityEngine;
using System.Collections.Generic;
using CX.MVP.View;
using CX.MVP.Presenter;
using System;

namespace CX.U3D.MVP.View
{
	public class U3DViewManager : IViewManager
	{		
		public U3DViewManager ()
		{
			viewDic = new Dictionary<string, IView>();
			viewTypeDic = new Dictionary<Type, IView>();
			viewFlow = new ViewFlow(this);
		}
		
		public IView GetView(string viewName)
		{
			IView view = ViewManagerBase.EmptyView;
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
			IView view = ViewManagerBase.EmptyView;
			UnityEngine.Object res = viewResource as UnityEngine.Object;
			if (res != null)
			{
				var resName = res.name;
				var gameObject = GameObject.Instantiate (res) as GameObject;
				if (gameObject != null)
				{
					view = gameObject.GetComponent<U3DView>();
					if (view != null)
					{
						viewDic.Add (resName, view);
						view.ViewName = resName;
					}
				}

				viewTypeDic.Add(view.GetType(), view);
				var str = "Game.View." + resName + "Presenter";
				var presType = Type.GetType (str);
				if (presType != null)
				{
					var pres = Activator.CreateInstance (presType) as IPresenter;
					pres.View = view;

					if (pres is IViewNavable)
					{
						(pres as IViewNavable).ViewFlow = viewFlow;
					}
				}
			}
			else
			{
				view = ViewManagerBase.EmptyView;
			}
			return view;
		}
		
		public TView CreateView<TView>(object viewResource) where TView : class, IView
		{
			return CreateView(viewResource) as TView;
		}
		
		IDictionary<string, IView> viewDic;
		IDictionary<Type, IView> viewTypeDic;
		IViewFlow viewFlow;
		

		public IViewFlow ViewFlow {
			get {
				return viewFlow;
			}
		}
	}
}



