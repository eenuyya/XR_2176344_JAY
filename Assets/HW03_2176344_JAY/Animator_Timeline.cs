using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animator_Timeline : MonoBehaviour
{
    public void OnFrameEnter_Stop()
    {
        GetComponent<Animator>().speed = 0;
    }
}
