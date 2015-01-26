using System;
using UnityEngine;

public class CharacterInitializer
{
	private GameObject player;

	public CharacterInitializer ()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}
}


