using UnityEngine;
using System;
using CX.Obj;

namespace CX.Character
{
	public abstract class CharacterBase : ICharacter
	{
		private ICharacterView view;
		private ICharacterLifeCyle life;

		public virtual ICharacterLifeCyle Life 
		{
			get
			{
				return life;
			}
			set
			{
				life = value;
			}
		}

		public virtual ICharacterView View
		{
			get
			{
				return view;
			}
			set
			{
				view = value;
				view.Character = this;
			}
		}

		IGameObjectView IGameObject.View
		{
			get
			{
				return View;
			}
			set
			{
				View = value as ICharacterView;
			}
		}
	}
}

