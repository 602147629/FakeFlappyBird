using CX.Character;
using CX.U3D;
using Game.Character;
using UnityEngine;
using CX.Obj;
using CX;

namespace CX.U3D.Character
{
	public class CharacterFactory
	{
		IObjectPool objectPool;

		public IObjectPool ObjectPool {
			get {
				return objectPool;
			}
		}

		public CharacterFactory ()
		{
			objectPool = new ObjectPool();
		}

		public void AddToPool(GameObjectBornVO bornVO)
		{
			UnityEngine.Object res = Resources.Load(bornVO.ResPath);

			for (int i = 0; i < bornVO.BornCount; i++)
			{
				GameObject ins = GameObject.Instantiate(res) as GameObject;
				ins.transform.position = bornVO.Position;
				ins.transform.localScale = bornVO.Scale;
				ins.transform.rotation = bornVO.Rotation;
				
				ins.SetActive(false);
				
				IGameObjectView view = ins.GetComponent<U3DGameObjectView>() as IGameObjectView;
				IGameObject go = CreateHelper.Create<IGameObject>(bornVO.ObjectType);

				view.HostObject = go;
				go.View = view;

				objectPool.PutBack(go);
			}
		}
	}
}

