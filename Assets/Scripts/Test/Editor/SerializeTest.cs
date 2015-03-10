using NUnit.Framework;
using System;
using System.Collections.Generic;
using CX.Serialize;
using CX.U3D.Serialize;

namespace UtilTest
{
	[TestFixture]
	public class SerializeTest
	{
		ISerializer serializer;
		TestSerialize ts;

		[SetUp]
		public void SetUp()
		{
			serializer = new DataSerializer(); 
			ts = new TestSerialize();
			ts.i = 5;
			ts.s = "xxx";

			TestSerialize2 ts2 = new TestSerialize2();
			ts2.lst.Add("a");

			ts.ts2 = ts2;

		}


		[Test]
		public void SerializeAndDeSerialize()
		{
			serializer.Serialize(ts);
			var t = serializer.Deserialize<TestSerialize>();
			Assert.AreEqual(t.i, 5);
			Assert.AreEqual(t.s, "xxx");
			Assert.AreEqual(t.ts2.lst[0], "a");
		}

		[Serializable]
		class TestSerialize
		{
			public int i;
			public string s;
			public TestSerialize2 ts2;
		}

		[Serializable]
		class TestSerialize2
		{
			public List<string> lst = new List<string>();
		}
	}


}

