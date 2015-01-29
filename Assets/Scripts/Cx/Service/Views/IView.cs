
namespace CX.MVP.View
{
	public interface IView
	{
		void Show(bool isShow);
		string ViewName { get; set; }
	}
}

