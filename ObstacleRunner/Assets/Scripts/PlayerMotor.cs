using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Threading;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System;
//using System.Runtime.Intrinsics;
using System.Collections.Specialized;
//using System.Numerics.Vector3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{

    private CharacterController controller;
    private float speed;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Vector3.zero;
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        
        controller.Move(movement * Time.deltaTime);
    }
}
