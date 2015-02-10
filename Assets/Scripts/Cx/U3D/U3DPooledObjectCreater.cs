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
			IGameObject gameObejct =  creater.Create(bornVO);
			gameObejct.View.Active(false);
			return gameObejct;
		}

		public override IGameObject Pop()
		{
			IGameObject obj =  base.Pop();
			if (obj is ICxObject)
				(obj as ICxObject).Create();
			else
				obj.View.Active(true);
			return obj;
		}

		public override void Push (IGameObject obj)
		{
			if (obj is ICxObject)
				(obj as ICxObject).Destroy();
			else
				obj.View.Active(false);
			base.Push (obj);
		}
	}
}

