using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryHandler : MonoBehaviour {

    [SerializeField]
    public Dictionary<string, string> dict = new Dictionary<string, string>();

	public void addToDict(string key, string value)
    {
        dict.Add(key, value);
    }

    public Dictionary<string, string> getDict()
    {
        return dict;
    }

    public void printDict()
    {
        foreach (KeyValuePair<string, string> kvp in dict)
            { print(kvp.Key + ": " + kvp.Value);}
    }
	// Update is called once per frame
	void Update () {
		
	}
}
