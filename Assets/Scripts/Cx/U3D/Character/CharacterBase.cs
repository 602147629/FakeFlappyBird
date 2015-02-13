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

		private ICharacterView view;
		private ICharacterLifeCyle life;
		private Type createVOType;

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

		public Type CreateVOType
		{
			get
			{
				return createVOType;
			}
			set
			{
				createVOType = value;
			}
		}
	}
}

