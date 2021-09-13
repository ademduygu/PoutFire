using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaterPicker : MonoBehaviour
{
    private float water = 0;

    public TextMeshProUGUI textWaters;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "GetWater")
        {
            water++;
            textWaters.text = water.ToString();

            Destroy(other.gameObject);
        }
    }
}
