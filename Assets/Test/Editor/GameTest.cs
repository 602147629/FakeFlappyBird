using NUnit.Framework;
using Game;
using UnityEngine;
using System;
using Game.View;


[TestFixture]
public class GameTest
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

		/*var currentView = viewInit.ViewFlow.CurrentView;
		Assert.AreEqual(currentView.ViewName, "WelcomeView");

		(currentView as IWelcomeView).OnStartGameEvent.Invoke();

		currentView = viewInit.ViewFlow.CurrentView;
		Assert.AreEqual(currentView.ViewName, "InGameView");*/
		
		
	}


}
