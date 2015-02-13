using UnityEngine;
using System;
using CX.Obj;
using CX.U3D.Obj;
using CX.Character;

namespace CX.U3D.Character
{
	public class CharacterBase : CxGameObject, ICharacter
	{
		public CharacterBase(GameObjectBornVO bornVO) : base (bornVO)
		{

		}

		public virtual ICharacterLifeCyle Life 
		{
			get;set;
		}
	}
}