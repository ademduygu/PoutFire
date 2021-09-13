using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pout : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Fire")
        {
            //water++;
            //textWaters.text = water.ToString();

            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
