using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiperforwater : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "GetWater")
        {
            Destroy(other.gameObject);
        }
    }
}
