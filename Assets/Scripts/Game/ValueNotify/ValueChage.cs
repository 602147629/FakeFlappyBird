using System;
using System.Collections.Generic;

public interface IValueChange<T>
{
	T Value
	{
		get; set;
	}

	void AddListener(IValueListener<T> listner);

	void RemoveListenr(IValueListener<T> listner);
}

public class ValueChage<T> : IValueChange<T>
{
	T _value;

	public ValueChage (T value)
	{
		this._value = value;
	}

	public T Value
	{
		get { return _value; }
		set 
		{
			_value = value; 
			Change(_value);
		}
	}

	public void AddListener(IValueListener<T> listner)
	{
		listners.Add(listner);
	}

	public void RemoveListenr(IValueListener<T> listner)
	{
		listners.Remove(listner);
	}

	void Change(T newValue)
	{
		foreach (var l in listners)
		{
			l.OnChange(newValue);
		}
	}

	IList<IValueListener<T>> listners = new List<IValueListener<T>>();
}
