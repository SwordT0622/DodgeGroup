using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet02 : MonoBehaviour
{
    [SerializeField] float speed = 0;
    Transform m_Target = null;

    public void Initialize(Transform target)
    {
        m_Target = target;
        transform.LookAt(m_Target);

        Destroy(gameObject, 10f);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }
}
