using UnityEngine;
using System.Collections;
using NUnit.Framework;
using NSubstitute;
using CX.Character;
using CX.U3D.Character;

public class CharacterTest
{
	ICharacter character;
	IViewFlow viewFlow;
	IViewManager viewMgr;
	
	[SetUp]
	public void SetUp()
	{
		CharacterFactory cf = new CharacterFactory();
		character = cf.Create("bird");
		character.Life = new CharacterLife();

		viewMgr = new ViewManager();
		viewFlow = new ViewFlow(viewMgr);
	}

	[Test]
	public void TestDead()
	{
		character.Life.Dead();
	}

	[TearDown]
	public void TearDown()
	{
		character.Destroy();
	}
}
