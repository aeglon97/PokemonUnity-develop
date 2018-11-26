//Original Scripts by IIColour (IIColour_Spectrum)

using UnityEngine;
using System.Collections;

public class InteractObject : MonoBehaviour
{
    public static string[] english;
    public static string[] spanish;
    public string engDialog;
    public string spanDialog;

    private bool hasSwitched = false;

    private DialogBoxHandler Dialog;
    private NPCHandler thisNPC;
    private DictionaryHandler dictHandler;

    void Awake()
    {
        Dialog = GameObject.Find("GUI").GetComponent<DialogBoxHandler>();

        if (transform.GetComponent<NPCHandler>() != null)
        {
            thisNPC = transform.GetComponent<NPCHandler>();
        }

        dictHandler = GameObject.Find("GUI").GetComponent<DictionaryHandler>();

        if (transform.GetComponent<DictionaryHandler>() != null)
        {
            dictHandler = transform.GetComponent<DictionaryHandler>();
        }
    }
    public IEnumerator interact()
    {
        if (PlayerMovement.player.setCheckBusyWith(this.gameObject))
        {
            /*if (thisNPC != null)
            {
                int direction;
                //calculate player's position relative to this npc's and set direction accordingly.
                float xDistance = thisNPC.transform.position.x - PlayerMovement.player.transform.position.x;
                float zDistance = thisNPC.transform.position.z - PlayerMovement.player.transform.position.z;
                if (xDistance >= Mathf.Abs(zDistance))
                {
                    //Mathf.Abs() converts zDistance to a positive always.
                    direction = 3;
                } //this allows for better accuracy when checking orientation.
                else if (xDistance <= Mathf.Abs(zDistance) * -1)
                {
                    direction = 1;
                }
                else if (zDistance >= Mathf.Abs(xDistance))
                {
                    direction = 2;
                }
                else
                {
                    direction = 0;
                }
                thisNPC.setDirection(direction);
            }*/

            //start of interaction
            string thisEng = "";
            string thisSpan = "";
            foreach (string word in dictHandler.getEnglish())
            {
                print(word);
                if (engDialog.Contains(word))
                {
                    thisEng = word;
                    Debug.Log("thisEng: " + thisEng);
                }
            }

            foreach (string word in dictHandler.getSpanish())
            {
                if (spanDialog.Contains(word))
                {
                    thisSpan = word;
                    Debug.Log("thisSpan: " + thisSpan);
                }
            }

            Dialog.drawDialogBox();

            if (dictHandler.getDict().ContainsKey(thisEng))
            {
                yield return StartCoroutine(Dialog.drawText(spanDialog));
                while (!Input.GetButtonDown("Select") && !Input.GetButtonDown("Back"))
                {
                    yield return null;
                }
                Dialog.undrawDialogBox();
            }
            else
            {
                yield return StartCoroutine(Dialog.drawText(engDialog));
                while (!Input.GetButtonDown("Select") && !Input.GetButtonDown("Back"))
                {
                    yield return null;
                }
                Dialog.undrawDialogBox();
                Dialog.drawDialogBox();
                yield return StartCoroutine(Dialog.drawText(spanDialog));
                while (!Input.GetButtonDown("Select") && !Input.GetButtonDown("Back"))
                {
                    yield return null;
                }
                Dialog.undrawDialogBox();

                for (int i = 0; i < dictHandler.getEnglish().Length; i++)
                {
                    if (!dictHandler.getDict().ContainsKey(thisEng))
                    {
                        dictHandler.addToDict(thisEng, thisSpan);
                    }
                }
            }
            print("Dictionary size: ");
            print(dictHandler.getDict().Count);
            print("Dictionary:");
            dictHandler.printDict();

            PlayerMovement.player.unsetCheckBusyWith(this.gameObject);
            /*if (dictHandler.getDict().ContainsKey(english))
            {
                yield return StartCoroutine(Dialog.drawText(spanDialog));
                while (!Input.GetButtonDown("Select") && !Input.GetButtonDown("Back"))
                {
                    yield return null;
                }
                Dialog.undrawDialogBox();
            }
            else
            {
                yield return StartCoroutine(Dialog.drawText(engDialog));
                while (!Input.GetButtonDown("Select") && !Input.GetButtonDown("Back"))
                {
                    yield return null;
                }
                Dialog.undrawDialogBox();
                Dialog.drawDialogBox();
                yield return StartCoroutine(Dialog.drawText(spanDialog));
                while (!Input.GetButtonDown("Select") && !Input.GetButtonDown("Back"))
                {
                    yield return null;
                }
                Dialog.undrawDialogBox();
                if (!dictHandler.getDict().ContainsKey(english))
                {
                    dictHandler.addToDict(english, spanish);
                }

                print("Dictionary:");
                dictHandler.printDict();
                hasSwitched = true;
            }
        }*/

        }
    }
}