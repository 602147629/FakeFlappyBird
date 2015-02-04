using CX.Obj;
using UnityEngine;

namespace CX.U3D
{
	public class U3DObjectCreater : ObjectCreater
	{
		Object res;

		Object GetRes(string resPath)
		{
			if (res == null)
			{
				res = Resources.Load(resPath);
			}
			return res;
		}

		public override IGameObject Create(BornVO bornVO)
		{
			GameObjectBornVO gameObjectBornVO = bornVO as GameObjectBornVO;

			GameObject ins = Object.Instantiate(GetRes(gameObjectBornVO.ResPath)) as GameObject;
			ins.transform.position = gameObjectBornVO.Position;
			ins.transform.localScale = gameObjectBornVO.Scale;
			ins.transform.rotation = gameObjectBornVO.Rotation;			
			
			IGameObjectView view = ins.GetComponent<U3DGameObjectView>() as IGameObjectView;
			IGameObject go = CreateHelper.Create<IGameObject>(bornVO.ObjectType);
			
			view.HostObject = go;
			go.View = view;
			
			return go;
		}
	}
}
