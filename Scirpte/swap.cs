using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swap : MonoBehaviour
{
    public GameObject coin;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += 0.05f;

        if (timer >= 6.0f)
        {
            timer = 0;
            Instantiate(coin, new Vector3(Random.Range(-6, 6), 5.0f, -1.97F), Quaternion.identity);

        }
    }
}