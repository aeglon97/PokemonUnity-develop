using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour {
    bool open = false;
    public Canvas Canvas;
    public Button[] buttons;
    private DictionaryHandler dictHandler;

    public void Start () {
        dictHandler = GameObject.Find("GUI").GetComponent<DictionaryHandler>();

        if (transform.GetComponent<DictionaryHandler>() != null)
        {
            dictHandler = transform.GetComponent<DictionaryHandler>();
        }

        int i = 0;

    }

	public void Update () {
		if (Input.GetKeyDown(KeyCode.P))
        {
            open = !open;
            Canvas.gameObject.SetActive(open);
        }

        int i = 0;
        foreach (KeyValuePair<string, string> entry in dictHandler.getDict())
        {
            buttons[i].GetComponent<Button>().gameObject.SetActive(true);
            //buttons[i].GetComponent<Button>().onClick.AddListener(() => toggleLang(false, entry, i));
            i++;
        }        
    }

    public void toggleLang(bool isEnglish, KeyValuePair<string, string> entry, int i)
    {
        buttons[i].GetComponentInChildren<Text>().text = "fuck";
        Debug.Log("yes");
        if (!isEnglish)
        {
            //text.text = entry.Key;
        }
        else
        {
            Debug.Log(2);
            //text.text = entry.Value;
        }
        isEnglish = !isEnglish;
    }
}
