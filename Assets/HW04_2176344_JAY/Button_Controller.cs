using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Controller : MonoBehaviour
{
    public void OnClick_LoadScene01()
    {
        SceneManager.LoadScene(0);
    }

    public void OnClick_LoadScene02()
    {
        SceneManager.LoadScene(1);
    }
}