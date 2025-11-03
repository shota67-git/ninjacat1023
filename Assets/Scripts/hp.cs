using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    GameObject hpGauge;
    public TextMeshProUGUI hppercent;
    public TextMeshProUGUI rtime;
    public TextMeshProUGUI caption;
    float remaintime;
    int hpP=100;
    // Start is called before the first frame update
    void Start()
    {
        hpGauge=GameObject.Find("HP");        
    }    
    // Update is called once per frame
    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        hpP = Mathf.RoundToInt(hpGauge.GetComponent<Image>().fillAmount * 100);
        hppercent.text= hpP.ToString()+"%";

        if (hpGauge.GetComponent<Image>().fillAmount == 0)
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene("Menu");
        }
           
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene("Menu");
        }
        remaintime = 5 - Time.time;
        rtime.text = remaintime.ToString("F1");
        Debug.Log(hpP+ " "+ remaintime);
        if (remaintime < 0 && hpP >= 60) { 
            Time.timeScale=0f;
            caption.text = "恭喜通過第一關！";
            if (Input.GetMouseButton(0)) {
                Time.timeScale = 1f;
                SceneManager.LoadScene("ch6");
            }
        }
        if(hpP < 60)
        {
            Time.timeScale = 0f;
            caption.text = "挑戰失敗！";
            if (Input.GetMouseButton(0))
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("ch5");
            }
        }
    }
}
