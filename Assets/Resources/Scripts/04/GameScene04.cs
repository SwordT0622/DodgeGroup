using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene04 : MonoBehaviour
{
    [SerializeField] Hud04UI m_HudUI = null;
    [SerializeField] Game04 m_Game = null;

    private void Start()
    {
        m_HudUI.Initialize();
        m_Game.Initialize();

        m_HudUI.m_Menu04Dlg.m_OnDelegate = new Menu04Dlg.DelegateFunc(m_Game.FireAll);
    }
}
