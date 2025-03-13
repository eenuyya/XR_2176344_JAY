using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day4_Mesh_Material : MonoBehaviour
{
    MeshFilter ThisMeshFilter;
    public GameObject Sphere, Capsule;

    // Start is called before the first frame update
    void Start()
    {
        ThisMeshFilter = GetComponent<MeshFilter>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            ThisMeshFilter.mesh = Sphere.GetComponent<MeshFilter>().mesh;
        }
        if(Input.GetMouseButtonDown(1)){
            ThisMeshFilter.mesh = Capsule.GetComponent<MeshFilter>().mesh;
        }
    }
}
