﻿using System.Collections;
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
        if(Input.GetKeyDown(KeyCode.Backspace)){
            mbakAnimator.SetTrigger("isDead");
        }
    }
}
