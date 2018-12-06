using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBtn : MonoBehaviour {
    public Text myText = null;
    public int counter = 0;
    private DictionaryHandler dictHandler;
    Text thisText;

    public void Start()
    {
    }
    public void ChangeText()
    {
        foreach (KeyValuePair<string, string> kvp in dictHandler.getDict())
        {
            Debug.Log(kvp.Key);
            Debug.Log(kvp.Value);
            if (kvp.Value == myText.text)
            {
                counter++;
                if (counter % 2 == 1)
                {
                    myText.text = kvp.Key;
                }
                else
                {
                    myText.text = kvp.Value;
                }
            }
            
        }
    }
}
