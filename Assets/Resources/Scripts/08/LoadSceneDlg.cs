using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneDlg : MonoBehaviour
{
    [SerializeField] Button[] m_SceneBtns = null;

    private void Start()
    {
        for(int i = 0; i < m_SceneBtns.Length; i++)
        {
            int idx = i;
            m_SceneBtns[i].onClick.AddListener(() =>
            {
                OnClicked_Scene(idx);
            });
        }
    }

    void OnClicked_Scene(int i)
    {
        string path = "GameScene0" + (i + 1).ToString();

        SceneManager.LoadScene(path);
    }
}
