using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDlg : MonoBehaviour
{
    [SerializeField] GameObject m_Blinder = null;
    [SerializeField] Button m_StartBtn = null;
    [SerializeField] Text m_CountTxt = null;

    float DELAY = 0.02f;

    private void Start()
    {
        m_StartBtn.onClick.AddListener(OnClicked_Start);
    }

    void OnClicked_Start()
    {
        m_Blinder.SetActive(false);
        StartCoroutine(IEnum_Count());
    }

    IEnumerator IEnum_Count()
    {
        m_CountTxt.gameObject.SetActive(true);

        for(int i = 3; i >= 0; i--)
        {
            if(i == 0)
            {
                m_CountTxt.text = "Start!";
            }
            else
            {
                m_CountTxt.text = i.ToString();
            }
            StartCoroutine(IEnum_Scale());

            yield return new WaitForSeconds(1);
        }

        m_CountTxt.gameObject.SetActive(false);
    }

    IEnumerator IEnum_Scale()
    {
        float scale = 1;
        bool isMinus = true;
        float curTime = 0;
        //while (isMinus)
        //{
        //    m_CountTxt.transform.localScale = new Vector3(scale, scale, scale);
        //    scale -= DELAY;

        //    if(scale <= 0.4f)
        //    {
        //        isMinus = false;
        //    }

        //    yield return new WaitForSeconds(DELAY);
        //}

        while (isMinus)
        {
            if(curTime >= 1)
            {
                isMinus = false;
            }

            float curScale = Mathf.Lerp(scale, scale / 2, curTime);
            m_CountTxt.transform.localScale = new Vector3(curScale, curScale, curScale);
            curTime += DELAY * 2;

            yield return new WaitForSeconds(DELAY);
        }
    }
}
