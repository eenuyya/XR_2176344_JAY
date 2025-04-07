using System.Collections; 

using System.Collections.Generic; 

using UnityEngine; 

public class Audio_Controller : MonoBehaviour 

{ 

    public AudioSource Audio; 

    void Start() 

    { 

        Audio.loop = true; 

        Audio.Play();
    } 

    void Update() 

    { 

        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            if (Audio.isPlaying) 
            {
                Audio.Pause(); 
                Debug.Log("audio pause");
            } 
            else 
            {
                Audio.Play();
                Debug.Log("audio play");
            }
        }
    } 

} 