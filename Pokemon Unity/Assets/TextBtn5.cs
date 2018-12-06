using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBtn5 : MonoBehaviour
{
    public Text myText = null;
    public int counter = 0;
    public int index;
    private DictionaryHandler dictHandler;

    public void Start()
    {
        dictHandler = GameObject.Find("GUI").GetComponent<DictionaryHandler>();

        if (transform.GetComponent<DictionaryHandler>() != null)
        {
            dictHandler = transform.GetComponent<DictionaryHandler>();
            myText.text = dictHandler.dictSpan[index];
        }
    }
    public void ChangeText()
    {

        counter++;
        if (counter % 2 == 1)
        {
            myText.text = dictHandler.dictEng[index];
            myText.color = Color.blue;
        }
        else
        {
            myText.text = dictHandler.dictSpan[index];
            myText.color = Color.red;
        }
    }
}
