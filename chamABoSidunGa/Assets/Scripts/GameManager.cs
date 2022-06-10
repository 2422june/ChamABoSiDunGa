using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;

    public int time;

    private WaitForSeconds one;
    private CountdownText CntDnText;

    private void Awake()
    {
        inst = this;
    }

    private void Start()
    {
        time = 60;
        one = new WaitForSeconds(1);

        CntDnText = GetComponent<CountdownText>();
        CntDnText.Init();
        CntDnText.Set(time);

        StartCoroutine(Roop());
    }

    private IEnumerator Roop()
    {
        while(true)
        {
            yield return one;
            time++;
            CntDnText.Set(time);
        }
    }
}
