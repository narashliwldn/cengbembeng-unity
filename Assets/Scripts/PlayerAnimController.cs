using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator mbakAnimator;
    void Start()
    {
        mbakAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // player menembak
        if(Input.GetKeyDown(KeyCode.Space)){
            mbakAnimator.SetTrigger("isShooting");
        }
        // mematikan player dengan menekan BackSpace (tes doang)
        if(Input.GetKeyDown(KeyCode.Backspace)){
            mbakAnimator.SetTrigger("isDead");
        }
        // menjalankan player ke kanan
        if(Input.GetKey(KeyCode.RightArrow)){
            mbakAnimator.SetBool("isRunning", true);
            transform.Translate(0.1f,0,0);
        }
        // menjalankan player ke kiri
        if(Input.GetKey(KeyCode.LeftArrow)){
            mbakAnimator.SetBool("isRunning", true);
            transform.Translate(-0.1f,0,0);
        }
        // tombol ke kanan/kiri dilepas jadi false
        if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow)){
            mbakAnimator.SetBool("isRunning", false);
        }
    }
}
