using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldPicker : MonoBehaviour
{
    public static int goldValue = 0;

    public static TextMeshProUGUI score;

    public TextMeshProUGUI _score;

    void Start()
    {
        score = _score;
    }
    public static void AddGold()
    {
        goldValue ++;
        score.text = goldValue.ToString();

    }
}

