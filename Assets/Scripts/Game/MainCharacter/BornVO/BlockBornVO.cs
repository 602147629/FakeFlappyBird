using CX.U3D;
using UnityEngine;

namespace Game
{
	public abstract class BlockBornVO : GameObjectBornVO
	{
		protected BlockBornVO()
		{
			Scale = new Vector3(1, Random.Range(1, 4), 1);			
		}
	}

	public class UpBlockBornVO : BlockBornVO
	{
		public UpBlockBornVO ()
		{
			ResPath = "UpBlock";
			Position = new Vector3(6.7f, 6, 0);
		}
	}

	public class DownBlockBornVO : BlockBornVO
	{
		public DownBlockBornVO ()
		{
			ResPath = "DownBlock";
			Position = new Vector3(6.7f, -3.14f, 0);
		}
	}

}

