using CX.Obj;
using UnityEngine;

namespace CX.U3D
{
	public class U3DPooledObjectCreater : PooledObjectCreater
	{
		U3DObjectCreater creater;

		public U3DPooledObjectCreater (GameObjectBornVO bornVO) : base (bornVO)
		{
			creater = new U3DObjectCreater();
		}

		protected override IGameObject GenerateOne ()
		{
			return creater.Create(bornVO);
		}

		public override IGameObject Pop()
		{
			IGameObject obj =  base.Pop();
			obj.View.Active(true);
			return obj;
		}
	}
}

