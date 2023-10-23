using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player02 : MonoBehaviour
{
    [SerializeField] float speed = 0;
    [SerializeField] FXParticle m_DestroyParticle = null;
    [SerializeField] AudioSource m_DestroyAudio = null;

    private void Start()
    {
        
    }

    private void Update()
    {
        Move();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Bullet")
        {
            Bullet02 kBullet = collision.transform.GetComponent<Bullet02>();
            Destroy(kBullet.gameObject);

            m_DestroyParticle.Play();
            m_DestroyAudio.Play();
        }
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float xDir = x * Time.deltaTime * speed;
        float zDir = z * Time.deltaTime * speed;

        transform.Translate(new Vector3(xDir, 0, zDir), Space.World);
    }
}
