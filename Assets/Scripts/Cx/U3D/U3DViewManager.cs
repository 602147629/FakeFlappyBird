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
			type2ViewDic = new Dictionary<Type, IView>();
			name2Type = new Dictionary<string, Type>();

			viewFlow = new ViewFlow(this);
		}
		
		public IView GetView(string viewName)
		{
			IView view = ViewManagerBase.EmptyView;
			if (name2Type.ContainsKey(viewName))
			{
				view = GetView(name2Type[viewName]);
			}
			return view;
		}
		
		public TView GetView<TView>() where TView : class, IView
		{
			return GetView(typeof(TView)) as TView;
		}

		IView GetView(Type veiwType)
		{
			IView view = ViewManagerBase.EmptyView;
			if (type2ViewDic.ContainsKey(veiwType))
			{
				view = type2ViewDic[veiwType];
			}
			return view;
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
						view.ViewName = resName;
						var type = view.GetType ();
						type2ViewDic.Add (type, view);
						name2Type.Add (resName, type);
					}
				}

				var str = "Game.View." + resName + "Presenter";
				var presType = Type.GetType (str);
				if (presType != null)
				{
					var pres = Activator.CreateInstance (presType) as IPresenter;
					view.Presenter = pres;

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

		public IViewFlow ViewFlow 
		{
			get 
			{
				return viewFlow;
			}
		}
		
		IDictionary<Type, IView> type2ViewDic;
		IDictionary<string,Type> name2Type;
		IViewFlow viewFlow;
	}
}



