using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaitController : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.tag == "Fish")
        {
            Debug.Log("pescou");
        } 
    }


}
