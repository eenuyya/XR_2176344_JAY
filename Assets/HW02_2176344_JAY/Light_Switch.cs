using System.Collections; 

using System.Collections.Generic; 

using UnityEngine; 

 

public class Light_Switch : MonoBehaviour 

{ 

    int state; 

    public GameObject LampOn, LampOff; 

 

    private void Start() 

    { 

        state = 0; 

        LampOn.SetActive(false); 

        LampOff.SetActive(true); 

    } 

    private void Update()

    { 
        if (Input.GetMouseButtonDown(1)) // 1은 오른쪽 마우스 버튼
        {

        state = 1 - state; 

        if (state == 0) 

        { 

            LampOn.SetActive(false); 

            LampOff.SetActive(true); 

            print("Lamp On"); 

        }else if(state == 1) 

        { 

            LampOn.SetActive(true); 

            LampOff.SetActive(false); 

            print("Lamp Off"); 

        } 
        }

    } 

} 
