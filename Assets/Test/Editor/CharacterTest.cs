using UnityEngine;
using System.Collections;
using NUnit.Framework;
using NSubstitute;
using CX.Character;
using CX.U3D.Character;
using CX.MVP.View;
using CX.U3D.MVP.View;
using Game.Character;

public class CharacterTest
{
	ICharacter character;

	
	[SetUp]
	public void SetUp()
	{
		CharacterFactory cf = new CharacterFactory();
		character = cf.Create("bird");
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
