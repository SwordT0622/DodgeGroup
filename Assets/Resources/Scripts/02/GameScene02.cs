using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene02 : MonoBehaviour
{
    [SerializeField] Game02 m_Game = null;
    [SerializeField] Hud02UI m_HudUI = null;

    private void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        m_Game.Initialize();
        m_HudUI.Initialize();

        m_HudUI.m_MenuDlg.OnDelegate = new MenuDlg02.DelegateFunc(m_Game.FireTurrets);
    }
}
