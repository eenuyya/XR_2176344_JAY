using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day4_Mesh_Renderer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0,0,1);
        }

        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0,0,-1);
        }

        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(0,-1,0);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(0,1,0);
        }
    }
}
