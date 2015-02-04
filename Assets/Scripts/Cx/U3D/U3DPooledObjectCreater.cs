using CX.Obj;
using UnityEngine;

namespace CX.U3D
{
	public class U3DPooledObjectCreater : PooledObjectCreater
	{
		GameObjectBornVO bornVO;
		Object res;

		public U3DPooledObjectCreater (GameObjectBornVO bornVO) : base (bornVO)
		{
			this.bornVO = bornVO;
			this.res = Resources.Load(bornVO.ResPath);
		}

		protected override IGameObject GenerateOne ()
		{
			GameObject ins = GameObject.Instantiate(res) as GameObject;
			ins.transform.position = bornVO.Position;
			ins.transform.localScale = bornVO.Scale;
			ins.transform.rotation = bornVO.Rotation;			
			
			IGameObjectView view = ins.GetComponent<U3DGameObjectView>() as IGameObjectView;
			IGameObject go = CreateHelper.Create<IGameObject>(bornVO.ObjectType);

			view.Active(false);
			view.HostObject = go;
			go.View = view;

			return go;
		}

		public override IGameObject Pop()
		{
			IGameObject obj =  base.Pop();
			obj.View.Active(true);
			return obj;
		}
	}
}

