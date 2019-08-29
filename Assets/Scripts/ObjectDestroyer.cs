using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public int xDirection;

//    public float xLeft;
    public float destroyPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(transform.position.x <= xLeft){
        //     //bisa transform.gameObject, gameObject, ataua this.gameObject
        //     Destroy(this.gameObject);
        // }

        if(xDirection < 0 && transform.position.x <= destroyPoint){
            Destroy(this.gameObject);
        }
        else if(xDirection > 0 && transform.position.x >= destroyPoint){
            Destroy(this.gameObject);
        }
    }
}
