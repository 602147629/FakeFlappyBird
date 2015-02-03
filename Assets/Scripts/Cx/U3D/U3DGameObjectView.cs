using UnityEngine;
using CX.Obj;

namespace CX.U3D
{
	public class U3DGameObjectView : MonoBehaviour, IGameObjectView
	{
		public void Destroy()
		{
			ComponentTool.Destroy(gameObject);
		}

		public IGameObject HostObject
		{
			get; set;			
		}
	}
}

