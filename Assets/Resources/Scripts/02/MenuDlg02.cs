using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuDlg02 : MonoBehaviour
{
    [SerializeField] Button m_StartBtn = null;
    [SerializeField] Button m_StopBtn = null;

    public delegate void DelegateFunc();
    public DelegateFunc OnDelegate = null;

    bool isFire = false;
    float t = 0;

    private void Update()
    {
        //if (isFire)
        //{
        //    t += Time.deltaTime;

        //    if(t >= 1)
        //    {
        //        if (OnDelegate != null)
        //            OnDelegate();

        //        t = 0;
        //    }
        //}
    }

    public void Initialize()
    {
        m_StartBtn.onClick.AddListener(OnClicked_Start);
        m_StopBtn.onClick.AddListener(OnClicked_Stop);
    }

    void OnClicked_Start()
    {
        StopAllCoroutines();
        isFire = true;

        StartCoroutine(IEnum_Fire());
    }

    void OnClicked_Stop()
    {
        isFire = false;
        t = 0;

        StopAllCoroutines();
    }

    IEnumerator IEnum_Fire()
    {
        while (isFire)
        {
            if (OnDelegate != null)
                OnDelegate();

            yield return new WaitForSeconds(1);
        }
    }
}
