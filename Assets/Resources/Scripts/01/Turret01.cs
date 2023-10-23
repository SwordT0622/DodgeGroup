using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret01 : MonoBehaviour
{
    [SerializeField] Transform m_Body = null;
    [SerializeField] Transform m_GunPos = null;
    [SerializeField] Transform m_BulletParent = null;
    [SerializeField] GameObject m_Bullet = null;

    [SerializeField] Transform m_Target = null;

    private void Start()
    {
        Initialize();   
    }

    public void Initialize()
    {

    }

    private void Update()
    {
        m_Body.LookAt(m_Target);

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject go = Instantiate(m_Bullet, m_BulletParent);
        go.transform.position = m_GunPos.position;
        go.transform.localScale = m_Bullet.transform.localScale;

        Bullet01 kBullet = go.GetComponent<Bullet01>();
        kBullet.Initialize(m_Target);
    }
}
