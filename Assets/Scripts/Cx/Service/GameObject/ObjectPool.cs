using System;
using System.Collections.Generic;

namespace CX.Obj
{
	public class ObjectPool : IObjectPool
	{
		public static readonly EmptyObject empty = new EmptyObject();

		public ObjectPool()
		{
			pools = new Dictionary<Type, PooledObjectCreater>();
		}

		public void RegCreater (PooledObjectCreater creater)
		{
			var createType = creater.CreateType;
			if (createType != null && !pools.ContainsKey(createType))
			{
				creater.StartGenerate();
				pools.Add (createType, creater);
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

		public void ClearAllInPool()
		{
			foreach (PooledObjectCreater creater in pools.Values)
			{
				creater.Clear();
			}
			pools.Clear();
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

