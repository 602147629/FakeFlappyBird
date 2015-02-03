using System;
using System.Collections.Generic;

namespace CX.Obj
{
	public class ObjectPool : IObjectPool
	{
		private static readonly EmptyObject empty;

		public ObjectPool()
		{
			pools = new Dictionary<Type, PooledObjectCreater>();
		}

		public void RegCreater (PooledObjectCreater creater)
		{
			if (creater.CreateType != null)
			{
				creater.StartGenerate();
				pools.Add(creater.CreateType, creater);
			}
		}

		public IGameObject GetOne(Type type)
		{
			IGameObject obj = empty;

			PooledObjectCreater objCreater = null;
			if (pools.TryGetValue(type, out objCreater))
			{
				obj = objCreater.Pop();
			}
			return obj;
		}

		public void PutBack(IGameObject gameObject)
		{
			Type type = gameObject.GetType();

			PooledObjectCreater objCreater = null;
			if (pools.TryGetValue(type, out objCreater))
			{
				objCreater.Push(gameObject);
			}			
		}

		IDictionary<Type, PooledObjectCreater> pools;

		public class EmptyObject : IGameObject
		{
			public IGameObjectView View
			{
				get; set;
			}

			public override string ToString ()
			{
				return string.Format ("[EmptyObject: ]");
			}
			
		}
	}
}

