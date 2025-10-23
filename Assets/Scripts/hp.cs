using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    GameObject hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        hpGauge=GameObject.Find("HP");
    }

    // Update is called once per frame
    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
