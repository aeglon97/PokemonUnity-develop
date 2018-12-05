using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBtn : MonoBehaviour {
    public Text myText = null;
    public int counter = 0;
    private DictionaryHandler dictHandler;

    public void Start()
    {

    }
    public void ChangeText()
    {
        
        counter++;
        if (counter % 2 == 1)
        {
            myText.text = "Pause";
        }
        else
        {
            myText.text = "Start";
        }
    }
}
