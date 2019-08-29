using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnPosX = 15;
    public float xLeft, xRight;
    //untuk set waktu muncul frame objek tiap detik
    public float spawnTime;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<=0){
            //Generate object dengan parent script sendiri
            GameObject obj = Instantiate(objectToSpawn, this.transform);
            //set posisi objek agar berada di sebelah kanan kamera
             obj.transform.localPosition = new Vector3(spawnPosX, Random.Range(xLeft, xRight), 0);
             timer = spawnTime;
        }
        
    }
}
