using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet01 : MonoBehaviour
{
    [SerializeField] float speed = 0;

    Transform m_Target = null;
    Vector3 dir = Vector3.forward;

    public void Initialize(Transform target)
    {
        m_Target = target;
        transform.LookAt(m_Target);

        Destroy(gameObject, 10f);
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        //transform.position += dir * speed * Time.deltaTime;
        transform.Translate(dir * speed * Time.deltaTime, Space.Self);
    }
}
