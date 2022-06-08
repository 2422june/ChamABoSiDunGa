using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    List<string> str = new List<string>();

    [SerializeField]
    GameObject textBox;

    Text text;

    int i, lenght;

    void Start()
    {
        Cursor.visible = false;

        text = textBox.GetComponent<Text>();

        i = 0;
        text.text = "";

        for(int listIndex = 0; listIndex < str.Count; listIndex++)
        {
            text.text += (str[listIndex] + "\n");
        }

        lenght = text.text.Length - 1;
    }

    void Typing()
    {
            i++;
            text.text = text.text.Substring(i, lenght);
            lenght = text.text.Length - 1;
            i = 0;
    }

    void Update()
    {
        if(text.text[0].Equals("\n"))
        {
            Typing();
        }

        if(Input.GetKeyDown(KeyCode.A) && text.text[0].Equals("¤±"))
        {
            Typing();
        }

    }

}
