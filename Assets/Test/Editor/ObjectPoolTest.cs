using System;
using NUnit.Framework;
using CX.Obj;
using CX.Character;
using CX.U3D.Character;
using Game;
using UnityEngine;

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

			var upBlockBornVO = new UpBlockBornVO ();
			cf.AddToPool (upBlockBornVO);
		}

		IGameObject GetOne ()
		{
			var get = objectPool.GetOne (typeof(Game.Character.MainCharacter));
			return get;
		}

		[Test]
		public void PushToPool()
		{
			var get = GetOne ();
			var get2 = GetOne();

			Assert.AreEqual(get.GetType(), get2.GetType());
		}

		[Test]
		public void PushActive()
		{
			var get = GetOne();
			Assert.AreEqual(get.View.IsActive, true);
		}
	}
}

