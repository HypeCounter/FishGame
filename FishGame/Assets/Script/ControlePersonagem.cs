    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{
    [SerializeField] float turnSpeed = 100;
    [SerializeField] float pullSpeed = 10;
    [SerializeField] float pushSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        { 
            print("Gira para cima");
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space)) { 
            print("Lanca o anzol");
        }
        if (Input.GetKey(KeyCode.LeftControl)) { 
            print("Puxa o anzol");
        }
    }
}
