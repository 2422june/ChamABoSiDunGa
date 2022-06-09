using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountdownText : MonoBehaviour
{

    Text text;

    [SerializeField]
    string str, time, person;

    int timeNum = 60, i = 0, personCnt;

    WaitForSeconds one = new WaitForSeconds(1);

    void Start()
    {
        personCnt = 6;
        text = GetComponent<Text>();
        str = "오늘도 야근 하는중...";
        time = $"{timeNum / 60} : {timeNum % 60}";
        i = str.Length;

        StartCoroutine(Roop());
    }

    void Set(int i)
    {
        text.text = str.Substring(0, i);
        text.text += "\n\n";

        timeNum++;
        if ((timeNum / 60) < 10)
            time = $"오전 0{timeNum / 60} : ";
        else
            time = $"오전 {timeNum / 60} : ";

        if ((timeNum % 60) < 10)
            time += $"0{timeNum % 60}\n\n";
        else
            time += $"{timeNum % 60}\n\n";
        text.text += time;

        person = $"현재 야근중인 직원 수 : {personCnt}";
        text.text += person;
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
