using UnityEngine;
using System.Collections;
using NUnit.Framework;
using NSubstitute;
using CX.Character;
using CX.U3D.Character;
using CX.MVP.View;
using CX.U3D.MVP.View;

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

		viewMgr = new U3DViewManager();
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
		character.View.Destroy();
	}
}
