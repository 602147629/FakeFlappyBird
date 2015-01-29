using UnityEngine;
using CX.MVP.View;

namespace CX.U3D.MVP.View
{
	public class MonoView : MonoBehaviour, IView
	{
		public virtual void Show(bool isShow)
		{
			gameObject.SetActive(isShow);
		}
		
		public string ViewName
		{
			get; set;
		}
	}
}



