using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01 : MonoBehaviour
{
    const float DEFAULT_SPEED = 5;
    [SerializeField] Transform m_Body = null;
    [SerializeField] float speed = 0;

    private void Start()
    {
        
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float xDir = x * Time.deltaTime * speed * DEFAULT_SPEED;
        float zDir = z * Time.deltaTime * speed * DEFAULT_SPEED;

        transform.Translate(new Vector3(xDir, 0, zDir), Space.World);
    }
}
