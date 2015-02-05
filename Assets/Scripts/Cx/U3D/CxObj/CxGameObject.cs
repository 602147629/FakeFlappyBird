using UnityEngine;
using CX.Obj;
using System;

namespace CX.U3D.Obj
{
	public class CxGameObject : ICxObject, IGameObject
	{
		private ObjectCreater creater;
		private GameObjectBornVO bornVO;

		public CxGameObject (GameObjectBornVO bornVO)
		{
			this.bornVO = bornVO;
			creater = new U3DObjectCreater();
		}

		public virtual void Create()
		{
			creater.Create(bornVO);
		}

		public virtual void Destroy()
		{
			View.Destroy();
		}

		public IGameObjectView View
		{
			get; set;
		}

		public Type CreateVOType
		{
			get; set;
		}
	}
}

