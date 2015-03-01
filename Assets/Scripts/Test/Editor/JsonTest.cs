using fastJSON;
using CX.U3D;
using UnityEngine;
using NUnit.Framework;

namespace UtilTest
{
	[TestFixture]
	public class JsonTest
	{
		[SetUp]
		public void SetUp()
		{

		}

		[Test]
		public void Test()
		{
			var vo = new GameObjectBornVO();
			var jsontext = JSON.ToJSON(vo);

			Debug.Log(jsontext);

			var obj = JSON.ToObject(jsontext);
			Debug.Log(obj.ToString());

		}
	}
}

