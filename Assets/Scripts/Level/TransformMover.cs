using UnityEngine;
using System;
using Level;
namespace Level
{
	public class TransformMover : MonoBehaviour
	{
		public Vector3 moveSpeed;
		public Transform mover;

		void Awake()
		{
			if (mover == null) mover = transform;
		}

		void Update()
		{
			mover.Translate(moveSpeed * Time.deltaTime);
		}
	}
}

