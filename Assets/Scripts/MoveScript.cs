using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    Vector3 playerPos;

    /*versiku
    float speedX = -0.02f;
    float speedY = 0f;
    float speedZ = 0f;*/
    // Start is called before the first frame update

    /*versi mas Ghatot
    public float speedX;
    public float speedY;*/

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      /*versi mas Ghatot: 
       transform.Translate(speedX, speedY, 0);
       */
        
    //versiku
        transform.Translate(-0.02f, 0, 0);

    /*versiku (lagi):
     transform.Translate(speedX,speedY,speedZ);
     */
    }
}
