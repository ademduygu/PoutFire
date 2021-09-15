using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pout : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Fire")
        {
            GoldPicker.AddGold();
            
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
