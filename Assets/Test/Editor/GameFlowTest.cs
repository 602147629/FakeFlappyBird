using NUnit.Framework;
using Game;
using UnityEngine;
using System;
using Game.View;

namespace GameTest
{
	[TestFixture]
	public class GameFlowTest
	{
		IGameFlow gameFLow;

		[SetUp]
		public void SetUp()
		{
			gameFLow = new GameFlowController();
			
		}	

		
		[Test]
		public void Start()
		{
			gameFLow.Start();
			
		}
		
		
	}

}
