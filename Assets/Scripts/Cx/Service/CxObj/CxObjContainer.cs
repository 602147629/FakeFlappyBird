using System.Collections.Generic;
using CX.U3D.Obj;
using System;

namespace CX.Obj
{
	public class CxObjContainer
	{
		public CxObjContainer ()
		{
			//objList = new List<CxGameObject>(); 
		}

		public CxGameObject AddObject(BornVO bornVO)
		{
			var obj = CreateHelper.Create<CxGameObject>(bornVO.ObjectType, bornVO);
			//objList.Add(obj);
			return obj;
		}

		public void DestroyAll()
		{
			return;
			foreach (var obj in objList)
			{
				if (obj is IDisposable)
					(obj as IDisposable).Dispose();
			}
		}

		private IList<CxGameObject> objList;
	}
}
