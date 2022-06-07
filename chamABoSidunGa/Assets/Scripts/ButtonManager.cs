using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    GameObject OptionPanel;

    public void OnClickStartButton()
    {
        Debug.Log("GameStart");
    }

    public void OnClickOptionButton()
    {
        OptionPanel.SetActive(true);
    }

    public void OnClickOptionQuitButton()
    {
        OptionPanel.SetActive(false);
    }

    public void OnQuitButton()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
                Application.Quit();
    }

}
