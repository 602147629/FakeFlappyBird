using NUnit.Framework;
using System;
using UnityEngine;
using System.Timers;

namespace GameTest 
{
	[TestFixture]
	public class TimerTest
	{

		System.Timers.Timer t;

		[SetUp]
		public void SetUp()
		{
			t = new System.Timers.Timer(5);
			t.Elapsed += HandleElapsed;
		}

		void HandleElapsed (object sender, ElapsedEventArgs e)
		{
			Debug.Log(e.SignalTime);
		}

		[Test]
		public void Test()
		{
		}

		[TearDown]
		public void TearDown()
		{
			//ct.Close();
		}
	}
}

