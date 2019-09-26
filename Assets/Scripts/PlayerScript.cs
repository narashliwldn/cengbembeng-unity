using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Vector3 playerPos;
    public float posX;
    public float posY;
    public float posZ;

    public float speedX = 0.02f;
    public float speedY = 0.02f;
    public float speedZ = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        // #print("Start");

    }

    // Update is called once per frame
    void Update()
    {
        // #print("Update");
        if(ScoreScript.Instance.nyawa > 0){
        //membaca posisi player dan menyimpannya ke variabel playerPos
            playerPos = transform.position;
            // #print("Posisi player: " + playerPos);
            posX = transform.position.x;
            posY = transform.position.y;
            posZ = transform.position.z;
            /*untuk menandakan ini desimal (float) harus dikasih f setelah mengisi angka
            posX += 0.01f;*/
            posX += speedX;
            //transform.position = new Vector3(posX, posY, posZ);
            if (Input.GetAxis("Horizontal") > 0)
            {
                transform.Translate(speedX, 0, 0);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                transform.Translate(-speedX, 0, 0);
            }

            if (Input.GetAxis("Vertical") > 0)
            {
                transform.Translate(0, speedY, speedZ);
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                transform.Translate(0, -speedY, 0);
            }
            }
    }
}