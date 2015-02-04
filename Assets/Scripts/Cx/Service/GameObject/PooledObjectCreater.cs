using System.Collections.Generic;
using System;

namespace CX.Obj
{
	/// <summary>
	/// Pooled Object creater. Must work together with <see cref="CX.Obj.IObjectPool"/>
	/// </summary>
	public abstract class PooledObjectCreater
	{
		Stack<IGameObject> gameObjects;
		Type createType;
		protected BornVO bornVO;

		public Type CreateType 
		{
			get { return createType; }
		}
		
		protected PooledObjectCreater(BornVO bornVO)
		{
			this.bornVO = bornVO;
			this.createType = this.bornVO.GetType();
			gameObjects = new Stack<IGameObject>();
		}

		/// <summary>
		/// Musts call to start generate objects.
		/// </summary>
		public virtual void StartGenerate()
		{
			GenerateObjects(bornVO.BornCount);
		}

		/// <summary>
		/// Generates the objects with specified count.
		/// </summary>
		/// <param name="count">Count.</param>
		protected virtual void GenerateObjects(int count)
		{
			for (int i = 0; i < count; i++)
			{
				var obj = GenerateOne ();
				obj.CreateVOType = CreateType;
				Push (obj);
			}
		}

		/// <summary>
		/// Generates one object.
		/// </summary>
		/// <returns>The one.</returns>
		protected abstract IGameObject GenerateOne();

		/// <summary>
		/// Get one object out.
		/// </summary>
		/// <param name="obj">Object.</param>
		public virtual void Push(IGameObject obj)
		{
			gameObjects.Push(obj);
		}

		/// <summary>
		/// Put one object back;
		/// </summary>
		public virtual IGameObject Pop()
		{
			if (gameObjects.Count > 0)
				return gameObjects.Pop();
			else
			{
				GenerateObjects(bornVO.BornCount / 2 + 1);
				return Pop();
			}
		}	

		/// <summary>
		/// Destroy all objects.
		/// </summary>
		public virtual void Clear()
		{
			foreach (IGameObject obj in gameObjects)
			{
				obj.View.Destroy();
			}

			gameObjects.Clear();
		}
	}
}

