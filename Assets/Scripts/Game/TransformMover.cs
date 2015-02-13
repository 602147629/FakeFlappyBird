using UnityEngine;
using System;
using Level;
using CX.Obj;
using Game;

namespace Level
{
	public class TransformMover : MonoBehaviour, IMovable
	{
		public Vector3 moveSpeed;
		public Transform mover;

		void Awake()
		{
			if (mover == null) mover = transform;

			//GameFacade.GameFlow.GameStart += (sender, e) => StartMove();
			GameFacade.GameFlow.GameResume += (sender, e) => StartMove();
			GameFacade.GameFlow.GamePause += (sender, e) => StopMove();
			GameFacade.GameFlow.GameStop += (sender, e) => StopMove();
			isMoving = true;
		}

		void Update()
		{
			if (isMoving)
				mover.Translate(moveSpeed * Time.deltaTime);
		}

		#region IMovable implementation

		public void StartMove()
		{
			isMoving = true;
		}

		public void StopMove()
		{
			isMoving = false;
		}

		public bool IsMoving
		{
			get
			{
				return isMoving;
			}
		}

		#endregion

		private bool isMoving;
	}
}

