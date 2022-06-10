using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField]
    GameObject dialogueBox;
    [SerializeField]
    Text text;

    public void Init()
    {
        text = dialogueBox.GetComponent<Text>();
    }

    public void showDialogue(string text)
    {
        dialogueBox.SetActive(true);
        this.text.text = text;
    }

    public void unshowDialogue()
    {
        dialogueBox.SetActive(false);
        this.text.text = "";
    }
}
