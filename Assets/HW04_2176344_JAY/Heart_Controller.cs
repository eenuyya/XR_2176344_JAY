using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Controller : MonoBehaviour
{
    public GameObject Pick_Controller;

    private void OnMouseDown()
    {
        Pick_Controller.GetComponent<Pick_Controller>().Increase_PickCount(gameObject);
        print($"Clicked {gameObject.name}");
    }
}
