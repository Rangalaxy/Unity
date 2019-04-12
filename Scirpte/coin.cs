using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame -3.06
    void Update()
    {
        transform.Translate(Vector2.down*0.03f);


        //transform.position.x >= 6.28f 
        
        if (transform.position.y <=-4.00f) {
            //Debug.Log(transform.position.y);
            Destroy(this.gameObject);
        }


    }




}
