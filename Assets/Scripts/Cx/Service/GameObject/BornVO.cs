namespace CX.Obj
{
	/// <summary>
	/// Base Born VO
	/// </summary>
	public class BornVO
	{
		private int bornCount = 1;
		
		private string objectType;

		/// <summary>
		/// Gets or sets the born count.
		/// </summary>
		/// <value>The born count.</value>
		public int BornCount
		{
			get { return bornCount; }
			set { bornCount = value; }
		}
		
		/// <summary>
		/// Gets or sets the type of the object.
		/// Determines to create which type of object.
		/// </summary>
		/// <value>The type of the object.</value>
		public string ObjectType
		{
			get { return objectType; }
			set { objectType = value; }
		}
	}
}

