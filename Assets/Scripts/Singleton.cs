using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _Instance = null;


	public static T Instance
	{
		get
		{
			if (_Instance == null)
				Debug.Assert(false, "No Instance of" + typeof(T));

			return _Instance;
		}

	}

	#region Unity funtions
	protected virtual void Awake()
	{
		if(_Instance != this || _Instance != null)
		{
			DestroyImmediate(gameObject);
			return;
		}
		_Instance = this as T;
	}
	#endregion
}
