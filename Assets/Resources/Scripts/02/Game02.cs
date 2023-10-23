using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game02 : MonoBehaviour
{
    [SerializeField] Turret02 m_Turret = null;

    public void Initialize()
    {

    }

    public void FireTurrets()
    {
        m_Turret.Fire();
    }
}
