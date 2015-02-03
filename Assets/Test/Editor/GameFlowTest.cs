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
		[SetUp]
		public void SetUp()
		{
			
		}
		
		[Test]
		public void JustTest()
		{
			
			
		}
		
		[Test]
		public void Start()
		{
			var gs = new GameFacade();
			gs.StartGame();			
			
		}
		
		
	}

}
