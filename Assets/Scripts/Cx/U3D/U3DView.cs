using UnityEngine;
using CX.MVP.View;
using CX.MVP.Presenter;

namespace CX.U3D.MVP.View
{
	public class U3DView : MonoBehaviour, IView
	{
		string viewName;
		IPresenter presenter;

		public virtual void Show(bool isShow)
		{
			gameObject.SetActive(isShow);
		}

		protected virtual void Start()
		{
			Presenter.View = this;
		}

		public string ViewName
		{
			get
			{
				return viewName;
			}
			set
			{
				viewName = value;
			}
		}		

		public IPresenter Presenter
		{
			get
			{
				return presenter;
			}
			set
			{
				presenter = value;
			}
		}

	}
}



