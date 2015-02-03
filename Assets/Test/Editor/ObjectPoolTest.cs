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
		}

		[Test]
		public void PushToPool()
		{
			var upBlockBornVO = new UpBlockBornVO ();
			cf.AddToPool (upBlockBornVO);

			var count = GameObject.FindObjectsOfType(typeof(CX.U3D.U3DGameObjectView)).Length;
			Assert.AreEqual(upBlockBornVO.BornCount, count);


		}
	}
}

