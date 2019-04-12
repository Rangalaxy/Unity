using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmey_scritpe : MonoBehaviour
{


    bool ismove = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x >= 6.28f) {
            ismove = false;

        }
        else if (transform.position.x<= -6.29f) {
            ismove = true;
        }


        if (ismove) {
            transform.Translate(Vector2.right * 0.02f);
        }

        else if (!ismove) {
            transform.Translate(Vector2.left*0.02f);
        }

        
    }
}
