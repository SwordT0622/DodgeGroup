using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDlg : MonoBehaviour
{
    [SerializeField] Text m_TimeTxt = null;
    [SerializeField] Button m_StartBtn = null;
    [SerializeField] Button m_StopBtn = null;
    [SerializeField] Button m_ClearBtn = null;

    bool isTimer = false;
    float t = 0;

    private void Start()
    {
        m_StartBtn.onClick.AddListener(OnClicked_Start);
        m_StopBtn.onClick.AddListener(OnClicked_Stop);
        m_ClearBtn.onClick.AddListener(OnClicked_Clear);
    }

    private void Update()
    {
        if (isTimer)
        {
            t += Time.deltaTime;
            int min = (int)(t / 60);
            int sec = (int)(t % 60);
            int ms = (int)((t - (min * 60 + sec)) * 100);

            m_TimeTxt.text = string.Format("{0:00}:{1:00}:{2:00}", min, sec, ms);
        }
    }

    void OnClicked_Start()
    {
        isTimer = true;
    }

    void OnClicked_Stop() 
    { 
        isTimer = false;
    }

    void OnClicked_Clear()
    {
        isTimer = false;
        t = 0;
        m_TimeTxt.text = "00:00:00";
    }
}
