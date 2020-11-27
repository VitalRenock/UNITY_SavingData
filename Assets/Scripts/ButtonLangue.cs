using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLangue : MonoBehaviour {
    public string langue;

    public void ChangeLangue()
    {
        LangueManager.Instance.ChangeLangue(langue);
    }
	
}
