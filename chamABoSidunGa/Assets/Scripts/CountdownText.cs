using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountdownText : MonoBehaviour
{

    Text text;

    [SerializeField]
    string str, time;

    int timeNum = 60 * 20, i = 0;

    WaitForSeconds one = new WaitForSeconds(1);

    void Start()
    {
        text = GetComponent<Text>();
        str = "지시를 기다려 주세요...";
        time = $"{timeNum / 60} : {timeNum % 60}";
        i = str.Length;

        StartCoroutine(Roop());
    }

    void Set(int i)
    {
        text.text = str.Substring(0, i);
        text.text += "\n\n          ";
        timeNum--;
        time = $"{timeNum / 60} : {timeNum % 60}";
        text.text += time;
    }

    IEnumerator Roop()
    {
        while (timeNum > 0)
        {
            yield return one;
            Set(i - 1);

            yield return one;
            Set(i - 2);

            yield return one;
            Set(i - 3);

            yield return one;
            Set(i - 2);

            yield return one;
            Set(i - 1);

            yield return one;
            Set(i);
        }
    }
}
