using System.Collections; 

using System.Collections.Generic; 

using UnityEngine; 

using UnityEngine.Video; 

 

public class VideoController : MonoBehaviour 

{ 

    public VideoPlayer Video; 

 

    void Start() 

    { 

        Video.Play(); 

        Video.isLooping = true; 

    } 

 

    void Update() 

    { 

        if (Input.GetKeyDown(KeyCode.Space)) 

        { 

            if (Video.isPlaying) 

            { 

                Video.Pause();
                Debug.Log("video pause");

            } 

            else 

            { 

                Video.Play(); 
                Debug.Log("video play");

            } 

        } 

    } 

} 