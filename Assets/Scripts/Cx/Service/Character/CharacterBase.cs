using UnityEngine;
using System;
using CX.Obj;

namespace CX.Character
{
	public abstract class CharacterBase : ICharacter
	{
		public CharacterBase(ICharacterView view)
		{
			this.View = view;
		}

		public virtual ICharacterLifeCyle Life {
			get;set;
		}

		public virtual ICharacterView View
		{
			get;set;
		}

		IGameObjectView IGameObject.View
		{
			get;set;
		}
	}
}

