using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Menu04Dlg : MonoBehaviour
{
    [SerializeField] Button m_StartBtn = null;
    [SerializeField] Button m_StopBtn = null;

    public delegate void DelegateFunc();
    public DelegateFunc m_OnDelegate = null;

    bool isFire = false;

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
    }

    IEnumerator IEnum_Fire()
    {
        while (isFire)
        {
            if (m_OnDelegate != null)
                m_OnDelegate();

            yield return new WaitForSeconds(1);
        }
    }
}
