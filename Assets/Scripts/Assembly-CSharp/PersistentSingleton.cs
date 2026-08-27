using UnityEngine;

public abstract class PersistentSingleton<T> : StaticInstance<T> where T : MonoBehaviour
{
	protected override void Awake()
	{
	}
}
