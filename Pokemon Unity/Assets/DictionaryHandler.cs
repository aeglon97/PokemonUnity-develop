using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryHandler : MonoBehaviour {

    [SerializeField]
    public Dictionary<string, string> dict = new Dictionary<string, string>();
    public string[] english = { "looking for", "so amazing", "the computer", "walking", "door", "parents", "I don't like", "the school",
                                "the doctors", "the city", "bed", "the fridge", "video games", "the TV", "This bookshelf", "the trash"};

    public string[] spanish = { "buscando", "tan increíble", "la computadora", "caminando", "puerta", "padres", "no me gusta", "la escuela",
                                "los doctores", "la ciudad", "cama", "la nevera", "videojuegos", "la televisión", "Esta estantería", "la basura"};


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

    public string[] getEnglish()
    {
        return this.english;
    }

    public string[] getSpanish()
    {
        return this.spanish;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
