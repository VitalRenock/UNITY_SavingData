using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class LangueManager : Singleton<LangueManager>
{
    public GameObject overlay;
    public List<GameObject> buttons;


    public string langue { get; private set; }
    protected override void Awake () {
        langue = ReadFile();
        if (overlay != null)
            SetOverlay();
        base.Awake();
    }

    public void AskText(string _txt, Text _ui)
    {
        _ui.text = XmlReader.ReadXmlForKeyWord(LangueManager.Instance.langue + "_Text", _txt);
    }

    void WriteFile(string _s)
    {
        File.WriteAllText(Application.persistentDataPath + "/save.txt", _s);
    }

    string ReadFile()
    {
        if(System.IO.File.Exists(Application.persistentDataPath + "/save.txt"))
            return File.ReadAllText(Application.persistentDataPath + "/save.txt");
        else
        {
            WriteFile("FR");
            return "FR";
        }
    }

    public void SetOverlay()
    {
        switch (langue)
        {
            case "FR":
                overlay.transform.position = buttons[0].transform.position;
                break;
            case "EN":
                overlay.transform.position = buttons[1].transform.position;
                break;
            case "DE":
                overlay.transform.position = buttons[2].transform.position;
                break;
            case "AL":
                overlay.transform.position = buttons[3].transform.position;
                break;

        }
    }

    public void ChangeLangue(string _s)
    {
        if (_s == langue)
            return;
        WriteFile(_s);
        langue = _s;
        SetOverlay();
        foreach(AskText _a in GameObject.FindObjectsOfType<AskText>())
        {
            _a.Start();
        }
    }
}
