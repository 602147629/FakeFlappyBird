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
			objectPool.RegCreater(new U3DPooledObjectCreater(bornVO));
		}
	}
}

