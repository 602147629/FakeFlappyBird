using NUnit.Framework;
using Game;

public class GameTest
{
	[SetUp]
	public void SetUp()
	{

	}

	[Test]
	public void Start()
	{
		var viewInit = new ViewInitializer();		
		var gs = new GameStart(viewInit);
		gs.Start();

		Assert.AreEqual(viewInit.ViewFlow.CurrentView.ViewName, "WelcomePanel");
		
	}


}
