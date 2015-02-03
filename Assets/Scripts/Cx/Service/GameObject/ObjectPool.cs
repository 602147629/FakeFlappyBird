using System;
using System.Collections.Generic;

namespace CX.Obj
{
	public class ObjectPool : IObjectPool
	{
		private static readonly EmptyObject empty;

		public ObjectPool()
		{
			pools = new Dictionary<Type, Stack<IGameObject>>();
		}

		public IGameObject GetOne(Type type)
		{
			IGameObject obj = empty;

			Stack<IGameObject> objStack = null;
			if (pools.TryGetValue(type, out objStack))
			{
				if (objStack.Count > 0)
					obj = objStack.Pop();
			}
			return obj;
		}

		public void PutBack(IGameObject gameObject)
		{
			Type type = gameObject.GetType();

			Stack<IGameObject> objStack = null;
			if (!pools.TryGetValue(type, out objStack))
			{
				objStack = new Stack<IGameObject>();
				pools.Add(type, objStack);
			}
			objStack.Push(gameObject);
			
		}

		IDictionary<Type, Stack<IGameObject>> pools;

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

