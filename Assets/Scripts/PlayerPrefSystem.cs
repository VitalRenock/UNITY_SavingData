using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefSystem : MonoBehaviour
{

	private void Start()
	{
		float _myFloat = PlayerPrefs.GetFloat("Life");
		PlayerPrefs.SetFloat("Life", 3);
		if (PlayerPrefs.HasKey("Life")) { }
	}
}
