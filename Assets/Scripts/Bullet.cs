using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Transform[] firePoints;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    void Start()
    {
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
    }


    void Update()
    {
        
    }


    void Shoot()
    {
        
        for(int j = 0; j < firePoints.Length; j++)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoints[j].position, firePoints[j].rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoints[j].up * bulletForce, ForceMode2D.Impulse);

        }
    }

}
