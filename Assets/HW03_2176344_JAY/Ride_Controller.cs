using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ride_Controller : MonoBehaviour
{
    public Animator Animator;
    private bool goingToRoom2 = true;
    public AudioSource vehicleAudio;
    public AudioClip startSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Vehicle")
        {
            transform.SetParent(other.transform);
            transform.position = other.transform.position + Vector3.up * 2f;

            if (vehicleAudio != null && startSound != null)
            {
                vehicleAudio.PlayOneShot(startSound);
            }

            if (Animator != null)
            {
                Animator.speed = 1f;

                if (goingToRoom2)
                {
                    Animator.SetInteger("status", 1);
                    goingToRoom2 = false;
                }
                else
                {
                    Animator.SetInteger("status", 2);
                    goingToRoom2 = true;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Vehicle")
        {
            transform.SetParent(null);

            if (Animator != null)
            {
                Animator.SetInteger("status", 0); 
                Animator.speed = 0f;            
            }
        }
    }
}
