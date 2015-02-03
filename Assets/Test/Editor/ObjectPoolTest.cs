using System;
using NUnit.Framework;
using CX.Obj;
using CX.Character;
using CX.U3D.Character;
using Game;

namespace GameTest
{

	[TestFixture]
	public class ObjectPoolTest
	{		
		IObjectPool objectPool;
		CharacterFactory cf;

		[SetUp]
		public void SetUp()
		{
			cf = new CharacterFactory();
			objectPool = cf.ObjectPool;
		}

		[Test]
		public void PushToPool()
		{
			cf.AddToPool(new MainCharacterBornVO());

			var get = objectPool.GetOne(typeof(Game.Character.MainCharacter));

		}
	}
}

