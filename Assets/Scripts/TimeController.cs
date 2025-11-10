using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timecontrol;
    float time30s, remaintime;
    // Start is called before the first frame update
    void Start()
    {
        time30s = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time30s += Time.deltaTime;
        remaintime = 30 - time30s;
        timecontrol.text = "剩餘時間：" + remaintime.ToString("f1") + "秒";
        if (remaintime < 0) timecontrol.text = "時間到，闖關失敗！";
    }
}
