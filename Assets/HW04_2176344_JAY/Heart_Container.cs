using UnityEngine;

public class Heart_Container : MonoBehaviour
{
    public GameObject Item;

    void Start()
    {
        int cloneCount = 10;
        for (int i = 0; i < cloneCount; i++)
        {
            // 파괴된 아이템 ID 리스트에 없는 경우만 생성
            if (!DataManager.Instance.destroyedItemIDs.Contains(i))
            {
                Clone_Items(i);
            }
        }
    }

    void Clone_Items(int id)
    {
        Vector3 randomSphere = Random.insideUnitSphere * 0.25f;
        randomSphere.y = 0f;
        Vector3 randomPos = randomSphere + transform.position;

        float randomAngle = Random.value * 360f;
        Quaternion randomRot = Quaternion.Euler(0, randomAngle, 0);

        GameObject Clone = Instantiate(Item, randomPos, randomRot);
        Clone.transform.SetParent(transform);

        Clone.name = "Clone-" + string.Format("{0:D4}", id);  // 예: Clone-0000, Clone-0001, ...
    }
}
