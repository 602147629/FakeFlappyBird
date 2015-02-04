using CX.U3D;
using UnityEngine;

namespace Game
{
	public class BlockBornVO : GameObjectBornVO
	{
		protected BlockBornVO()
		{
			BornCount = 20;
			ObjectType = "Game.Character.BlockerCharacter";
		}

		public override Vector3 Scale 
		{
			get 
			{
				return new Vector3(base.Scale.x, Random.Range(1, 4) * base.Scale.y, base.Scale.z);
			}
			set {
				base.Scale = value;
			}
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

