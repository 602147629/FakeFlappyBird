using UnityEngine;
using CX.Obj;
using System;

namespace CX.U3D.Obj
{
	public class CxGameObject : IActivable, IGameObject
	{
		private GameObjectBornVO bornVO;
		private U3DGameObjectView u3dView;

		public CxGameObject (GameObjectBornVO bornVO)
		{
			this.bornVO = bornVO;
			CreateGameObjectView(bornVO.ResPath);
		}

		void CreateGameObjectView(string resPath)
		{
			var res = MyResources.Load(resPath);
			var ins = GameObject.Instantiate(res) as GameObject;
			u3dView = ins.GetComponent<U3DGameObjectView>();
			if (u3dView == null) u3dView = ins.AddComponent<U3DGameObjectView>();
			View = u3dView as IGameObjectView;
			View.HostObject = this;
		}

		public virtual void Activate()
		{
			u3dView.transform.localPosition = bornVO.Position;
			u3dView.transform.localScale = bornVO.Scale;
			u3dView.transform.localRotation = bornVO.Rotation;

			u3dView.gameObject.SetActive(true);
		}

		public virtual void InActivate()
		{
			u3dView.gameObject.SetActive(false);
			//View.Destroy();
		}

		public virtual void Destroy()
		{
			GameObject.Destroy(u3dView.gameObject);
		}

		public virtual IGameObjectView View
		{
			get; set;
		}
	}
}

