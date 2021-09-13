using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiper : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Fire" || other.transform.tag == "ThrowWater")
        {
            Destroy(other.gameObject);
        }
    }
}
