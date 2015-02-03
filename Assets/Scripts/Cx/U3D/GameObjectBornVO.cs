using UnityEngine;
using CX.Obj;

namespace CX.U3D
{
	/// <summary>
	/// Use to create a GameObject
	/// </summary>
	public class GameObjectBornVO : BornVO
	{
		private string resPath;

		private Vector3 position;

		private Vector3 scale = Vector3.one;

		private Quaternion rotation = Quaternion.identity;

		/// <summary>
		/// Gets or sets the res path.
		/// </summary>
		/// <value>The res path.</value>
		public string ResPath
		{
			get { return resPath; }
			set { resPath = value; }
		}

		/// <summary>
		/// Gets or sets the position.
		/// </summary>
		/// <value>The position.</value>
		public Vector3 Position
		{
			get { return position; }
			set { position = value; }
		}

		/// <summary>
		/// Gets or sets the scale.
		/// </summary>
		/// <value>The scale.</value>
		public Vector3 Scale
		{
			get { return scale; }
			set { scale = value; }
		}

		/// <summary>
		/// Gets or sets the rotation.
		/// </summary>
		/// <value>The rotation.</value>
		public Quaternion Rotation
		{
			get { return rotation; }
			set { rotation = value; }
		}

	}
}

