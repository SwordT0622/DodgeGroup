using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet01 : MonoBehaviour
{
    [SerializeField] Transform target = null;
    [SerializeField] float speed = 0;
    Vector3 dir = Vector3.forward;

    public void Initialize()
    {
        transform.LookAt(target);
    }

    private void Start()
    {
        Initialize();
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
