﻿    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            print("Apertou A");
        if (Input.GetKey(KeyCode.D))
            print("Apertou D");
        if (Input.GetKey(KeyCode.W))
            print("Apertou W");
        if (Input.GetKey(KeyCode.S))
            print("Apertou S")
    }
}