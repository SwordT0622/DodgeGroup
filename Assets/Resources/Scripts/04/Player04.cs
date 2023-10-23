using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player04 : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] FXParticle m_DestroyParticle = null;
    [SerializeField] AudioSource m_DestroyAudio = null;

    private void Update()
    {
        Move();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Bullet")
        {
            Bullet04 kBullet = collision.transform.GetComponent<Bullet04>();
            Destroy(kBullet.gameObject);

            m_DestroyAudio.Play();
            m_DestroyParticle.Play();
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
