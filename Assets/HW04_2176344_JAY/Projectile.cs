using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject UI_Controller;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bowl")) // 바구니 태그 설정
        {
            // Put Count 증가
            DataManager.Instance.putCount++;
            UI_Controller.GetComponent<UI_Controller>().Display_PutCounts();
        }
    }
}
