using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Controller : MonoBehaviour
{
    public TMP_Text PickCounts;
    public TMP_Text PutCounts;
    void Start()
    {
        // 씬 시작 시 DataManager 값으로 UI 갱신
        PickCounts.text = DataManager.Instance.pickCount.ToString();
        PutCounts.text = DataManager.Instance.putCount.ToString();
    }

    public void Display_PickCounts(int count)
    {
        PickCounts.text = count.ToString();
    }

    public void Display_PutCounts()
    {
        DataManager.Instance.putCount++;
        PutCounts.text = DataManager.Instance.putCount.ToString();
        // int lastPutCount = int.Parse(PutCounts.text);
        // int currentPutCount = lastPutCount + 1;
        // PutCounts.text = currentPutCount.ToString();
    }

    public void Decrease_PickCounts()
    {
        DataManager.Instance.pickCount--;
        PickCounts.text = DataManager.Instance.pickCount.ToString();
        // int lastPickCount = int.Parse(PickCounts.text);
        // int currentPickCount = lastPickCount - 1;
        // PickCounts.text = currentPickCount.ToString();
    }

    public int GetPickCounts()
    {
        return DataManager.Instance.pickCount;
        // int pickCounts = int.Parse(PickCounts.text);
        // return pickCounts;
    }
}
