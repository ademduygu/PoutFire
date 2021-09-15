using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject waterPrefab;

    public float waterForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject su = Instantiate(waterPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = su.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * waterForce, ForceMode2D.Impulse);
    }
}
