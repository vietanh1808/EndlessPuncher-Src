using Fubu.Helpers;
using UnityEngine;

public interface IPooledObject
{
	void CheckAvailable<T>(Pool<T> pool) where T : Object;
}
