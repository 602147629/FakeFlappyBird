using UnityEngine;
using System;
using Level;
using CX.Obj;

namespace Level
{
	public class TransformMover : MonoBehaviour, IMovable
	{
		public Vector3 moveSpeed;
		public Transform mover;

		void Awake()
		{
			if (mover == null) mover = transform;
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

