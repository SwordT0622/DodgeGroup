using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret04 : MonoBehaviour
{
    [SerializeField] Transform m_Body = null;
    [SerializeField] Transform m_BulletPos = null;
    [SerializeField] GameObject m_Bullet = null;
    [SerializeField] Transform m_BulletParent = null;
    [SerializeField] Transform m_Target = null;

    private void Update()
    {
        m_Body.LookAt(m_Target);
    }

    public void Fire()
    {
        GameObject go = Instantiate(m_Bullet, m_BulletParent);
        go.transform.position = m_BulletPos.position;
        go.transform.localScale = m_Bullet.transform.localScale;

        Bullet04 kBullet = go.GetComponent<Bullet04>();
        kBullet.Initialize(m_Target);
    }
}
