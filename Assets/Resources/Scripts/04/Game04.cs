using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game04 : MonoBehaviour
{
    [SerializeField] Turret04[] m_Turrets = null;

    public void Initialize()
    {

    }

    public void FireAll()
    {
        for(int i = 0; i < m_Turrets.Length; i++)
        {
            m_Turrets[i].Fire();
        }
    }
}
