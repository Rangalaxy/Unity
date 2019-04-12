using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    float height, width;
   
    float offset = 1;

    // Start is called before the first frame update
    void Start()
    {

        height = Camera.main.orthographicSize * 2.0f;
        width = height * Screen.width / Screen.height;
        transform.localScale = new Vector3(width,height,0.1f);
      
    }

    // Update is called once per frame
    void Update()
    {
        offset = Time.time * 0.1f;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offset, 0);
    }
}
