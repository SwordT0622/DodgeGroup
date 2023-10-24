using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ESCDlg : MonoBehaviour
{
    [SerializeField] GameObject m_ESCPanel = null;
    [SerializeField] Button m_YesBtn = null;
    [SerializeField] Button m_NoBtn = null;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        var obj = FindObjectsOfType<ESCDlg>();
        if (obj.Length == 1)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);

        m_YesBtn.onClick.AddListener(OnClicked_Yes);
        m_NoBtn.onClick.AddListener(OnClicked_No);

        m_ESCPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            m_ESCPanel.SetActive(true);
        }
    }

    void OnClicked_Yes()
    {
        SceneManager.LoadScene("GameScene08");
    }

    void OnClicked_No()
    {
        m_ESCPanel.SetActive(false);
    }
}
