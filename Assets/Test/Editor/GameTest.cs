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
		var viewInit = new ViewInitializer();		
		var gs = new GameStart(viewInit);
		gs.Start();

		var currentView = viewInit.ViewFlow.CurrentView;
		Assert.AreEqual(currentView.ViewName, "WelcomeView");

		(currentView as IWelcomeView).OnStartGameEvent.Invoke();

		currentView = viewInit.ViewFlow.CurrentView;
		Assert.AreEqual(currentView.ViewName, "GameOverView");
		
		
	}


}
