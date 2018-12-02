using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour {
    bool open = false;
    public Canvas Canvas;
    public Button[] buttons;
    private DictionaryHandler dictHandler;

    void Start () {
        dictHandler = GameObject.Find("GUI").GetComponent<DictionaryHandler>();

        if (transform.GetComponent<DictionaryHandler>() != null)
        {
            dictHandler = transform.GetComponent<DictionaryHandler>();
        }


       
        /*button.onClick.AddListener(() => OnButtonClick(1+1
       print("lol"));*/
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P))
        {
            open = !open;
            Canvas.gameObject.SetActive(open);
        }

        int i = 0;
        foreach (KeyValuePair<string, string> entry in dictHandler.getDict())
        {
            buttons[i].GetComponent<Button>().gameObject.SetActive(true);
            buttons[i].GetComponentInChildren<Text>().text = entry.Value;
            i++;
        }        
    }
}
