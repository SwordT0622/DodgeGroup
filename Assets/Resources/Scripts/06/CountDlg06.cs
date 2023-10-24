using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CountDlg06 : MonoBehaviour
{
    [SerializeField] GameObject m_Blinder = null;
    [SerializeField] Button m_StartBtn = null;
    [SerializeField] Text m_CountTxt = null;

    float DELAY = 0.01f;
    float t = 1;
    float scale = 1;
    float time = 0;
    int count = 3;
    bool isMinus = false;
    bool isCounting = false;

    private void Start()
    {
        m_StartBtn.onClick.AddListener(OnClicked_Start);
    }

    private void Update()
    {
        if (isCounting)
        {
            t += Time.deltaTime;

            if(t >= 1)
            {
                t = 0;
                if (count == 0)
                {
                    m_CountTxt.text = "Start!";
                }
                else if(count <= -1)
                {
                    m_CountTxt.gameObject.SetActive(false);
                    isCounting = false;
                }
                else
                {
                    m_CountTxt.text = count.ToString();
                }

                count -= 1;
                scale = 1;
                time = 0;
                isMinus = true;
            }
        }

        if (isMinus)
        {
            ReductionScale();
        }
    }

    void OnClicked_Start()
    {
        m_Blinder.SetActive(false);
        m_CountTxt.gameObject.SetActive(true);
        isCounting = true;
    }

    void ReductionScale()
    {
        //scale -= Time.deltaTime;
        //m_CountTxt.transform.localScale = new Vector3(scale, scale, scale);

        //if (scale <= 0.4f)
        //    isMinus = false;

        float curScale = Mathf.Lerp(scale, scale / 2, time);
        time += DELAY * 2;

        m_CountTxt.transform.localScale = new Vector3(curScale, curScale, curScale);

        if(time >= 1)
        {
            isMinus = false;
        }
    }
}
