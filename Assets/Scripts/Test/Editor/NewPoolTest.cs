using NUnit.Framework;
using CX.Obj;
using System;

namespace GameTest
{
	public class NewPoolTest
	{
		public class StringPooledObj : PooledObject<string>
		{
			public override string Make ()
			{
				return "Hello pool";
			}
		}

		IObjectPool<string> pool;



		[SetUp]
		public void SetUp()
		{
			pool = new ObjectPool<string>(new StringPooledObj(), 5);
		}

		[Test]
		public void Get()
		{
			var str = pool.GetOne();
			Assert.AreEqual("Hello pool", str);
			var ano = pool.GetOne();
			Assert.AreEqual("Hello pool", ano);
		}
	}
}

