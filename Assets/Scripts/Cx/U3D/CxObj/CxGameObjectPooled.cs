using CX.Obj;

namespace CX.U3D.Obj
{
	public class CxGameObjectPooled<T> : IPooledObject<T> where T : CxGameObject
	{
		BornVO bornVO;
		CxObjContainer objContainer;

		public CxGameObjectPooled(BornVO bornVO, CxObjContainer objContainer)
		{
			this.bornVO = bornVO;
			this.objContainer = objContainer;
		}

		public T Make()
		{
			//return CreateHelper.Create<T>(bornVO.ObjectType, bornVO);
			return objContainer.AddObject(bornVO) as T;
		}

		public void Activate(T obj)
		{
			obj.Activate();
		}

		public void InAactivate(T obj)
		{
			obj.InActivate();
		}

		public void Destroy(T obj)
		{
		}

		public bool Validate(T obj)
		{
			return true;
		}
	}
}
