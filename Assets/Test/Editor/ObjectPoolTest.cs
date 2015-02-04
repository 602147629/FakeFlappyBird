using System;
using NUnit.Framework;
using CX.Obj;
using CX.Character;
using CX.U3D.Character;
using Game;
using CX.U3D;
using UnityEngine;

namespace GameTest
{

	[TestFixture]
	public class ObjectPoolTest
	{		
		IObjectPool objectPool;

		[SetUp]
		public void SetUp()
		{
			objectPool = new ObjectPool();
			objectPool.RegCreater(new U3DPooledObjectCreater(new UpBlockBornVO ()));
			objectPool.RegCreater(new U3DPooledObjectCreater(new MainCharacterBornVO ()));
		}

		IGameObject GetOne (Type type)
		{
			var get = objectPool.GetOne (type);
			return get;
		}

		[Test]
		public void PushToPool()
		{
			var get = GetOne (typeof(MainCharacterBornVO));
			var get2 = GetOne(typeof(MainCharacterBornVO));

			Assert.AreEqual(get.GetType(), get2.GetType());
		}

		[Test]
		public void PushActive()
		{
			var get = GetOne(typeof(MainCharacterBornVO));
			Assert.AreEqual(get.View.IsActive, true);
		}

		[TearDown]
		public void TearDown()
		{

		}
	}
}

