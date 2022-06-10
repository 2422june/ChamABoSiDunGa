using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountdownText : MonoBehaviour
{

    [SerializeField]
    private GameObject textBox;
    [SerializeField]
    private string str;
    [SerializeField]
    private string time;
    [SerializeField]
    private string person;

    private Text text;
    private int i;
    private int personCnt;

    public void Init()
    {
        text = textBox.GetComponent<Text>();

        personCnt = 6;
        str = "오늘도 야근 하는중...";

        i = str.Length - 1;
    }

    public void Set(int timeNum)
    {
        if (i == (str.Length - 3))
            i = str.Length;
        else
            i--;

        text.text = str.Substring(0, i);
        text.text += "\n\n";


        time = "오전 ";
        if ((timeNum / 60) < 10)
            time += "0";

        time += $"{timeNum / 60} : ";
        if ((timeNum % 60) < 10)
            time += "0";

        time += $"{timeNum % 60}\n\n";
        text.text += time;


        person = $"현재 야근중인 직원 수 : {personCnt}";
        text.text += person;

        Event();
    }

    private void Event()
    {
        switch (time)
        {
            default:
                break;
        }
    }
}
