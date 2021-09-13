using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFires : MonoBehaviour
{
    public GameObject firePrefab;
    public float respawnTime = 1f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 1, Camera.main.transform.position.z));
        StartCoroutine(fireWave());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(firePrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, -4);
    }

    IEnumerator fireWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
