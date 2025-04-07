using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D06_UI : MonoBehaviour
{
    public void OnClick_Print(GameObject Target) 
    { 
        print(Target.name); 
        Destroy(Target); 
    } 
    public void OnClick_LoadScene(GameObject Target) 

    { 
        SceneManager.LoadScene(0); 

    } 
}
