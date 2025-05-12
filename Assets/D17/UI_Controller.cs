using System.Collections; 

using System.Collections.Generic; 

using UnityEngine; 

using TMPro; 

 

public class EX_UI : MonoBehaviour 

{ 

    string s; 

 

    public void OnClick_SetUI(TMP_Text Text)  

    { 

        print("Set UI"); 

        Text.text = $"{s}"; 

    } 

 

    public void OnClick_SetText(string _s) 

    { 

        print("Set Text"); 

        s = _s; 

    } 

 

    public void OnClick_Print(string _s) 

    { 

        print(_s); 

    } 

} 