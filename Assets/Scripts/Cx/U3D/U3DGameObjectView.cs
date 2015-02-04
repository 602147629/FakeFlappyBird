using UnityEngine;
using CX.Obj;

namespace CX.U3D
{
	public class U3DGameObjectView : MonoBehaviour, IGameObjectView
	{
		private IGameObject hostObject;

		public void Destroy()
		{
			ComponentTool.Destroy(gameObject);
		}

		public IGameObject HostObject
		{
			get { return hostObject; }
			set { hostObject = value; }
		}

		public void Active(bool isActive)
		{
			gameObject.SetActive(isActive);
		}

		public bool IsActive
		{
			get
			{
				return gameObject.activeSelf;
			}
		}
	}
}

