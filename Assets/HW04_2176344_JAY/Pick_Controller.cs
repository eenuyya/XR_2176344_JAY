using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Controller : MonoBehaviour
{
    public GameObject UI;

    public void Increase_PickCount(GameObject Clone)
    {
        // 아이템 ID 추출 (예: "Clone-0001" → 1)
        string[] nameParts = Clone.name.Split('-');
        int itemID = int.Parse(nameParts[1]);
        
        DataManager.Instance.destroyedItemIDs.Add(itemID); // 기록 추가
        DataManager.Instance.pickCount++;
        print($"pick count: {DataManager.Instance.pickCount}");
        Destroy(Clone);
        UI.GetComponent<UI_Controller>().Display_PickCounts(DataManager.Instance.pickCount);
    }
}
