using UnityEngine;
using CX.MVP.View;

namespace CX.U3D.MVP.View
{
	public class U3DView : MonoBehaviour, IView
	{
		string viewName;

		public virtual void Show(bool isShow)
		{
			gameObject.SetActive(isShow);
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

	}
}



