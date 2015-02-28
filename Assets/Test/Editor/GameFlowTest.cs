using NUnit.Framework;
using Game;
using UnityEngine;
using System;
using Game.View;
using CX.Obj;

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
		public void LoadRes ()
		{
			CxObjContainer cx = new CxObjContainer ();
			cx.AddObject (new MainCharacterBornVO ());
		}
		
		[Test]
		public void LoadNew()
		{
			LoadRes ();
			LevelLoader.LoadLevel(LevelConfig.EMPTY);
		}
		
		
	}

}
