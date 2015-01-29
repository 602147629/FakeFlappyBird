
namespace CX.MVP.View
{
	public abstract class ViewBase : IView
	{
		string viewName;

		public virtual void Show(bool isShow)
		{

		}

		public string ViewName
		{
			get
			{
				return viewName;
			}
			set
			{
				viewName = value;
			}
		}
	}
}

