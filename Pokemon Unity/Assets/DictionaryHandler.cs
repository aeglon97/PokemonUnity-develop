using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryHandler : MonoBehaviour {
    public List<string> dictEng = new List<string>();
    public List<string> dictSpan = new List<string>();

    [SerializeField]
    public Dictionary<string, string> dict = new Dictionary<string, string>();
    public string[] english = { "looking for", "so amazing", "the computer", "walking", "door", "parents", "I don't like", "the school",
                                "The doctors", "the city", "bed", "the fridge", "video games", "the TV", "This bookshelf", "the trash",
                                "dad", "how are you?", "a teacher", "the end", "Thanks", "I'm bored", "Wait!", "you talk",
                                "strong"};

    public string[] spanish = { "buscando", "tan increíble", "la computadora", "caminando", "puerta", "padres", "no me gusta", "la escuela",
                                "Los doctores", "la ciudad", "cama", "la nevera", "videojuegos", "la televisión", "Esta estantería", "la basura",
                                "papá", "¿cómo estás?", "un maestro", "el fin", "Gracias", "estoy aburrido", "¡Espera!", "tú hablas",
                                "fuerte"};

    public void addToEng(string eng)
    {
        dictEng.Add(eng);
    }

    public void addToSpan(string span)
    {
        dictSpan.Add(span);
    }

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

    public List<string> getDictEng()
    {
        return this.dictEng;
    }

    public List<string> getDictSpan()
    {
        return this.dictSpan;
    }

	// Update is called once per frame
	void Update () {
		
	}
}