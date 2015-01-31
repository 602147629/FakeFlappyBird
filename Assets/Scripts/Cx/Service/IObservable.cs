using System;
namespace CX
{
	public interface IObservable
	{
		void AddObserver(IObserver observer);
		void RemoveObserver(IObserver observer);
	}
}



