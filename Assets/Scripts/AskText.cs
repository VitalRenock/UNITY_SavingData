using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AskText : MonoBehaviour {

    public string text;

    public void Start()
    {
        LangueManager.Instance.AskText(text, GetComponent<Text>());
    }
}
