using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Put_Controller : MonoBehaviour
{
    public Transform centerPoint;
    public float radius = 0.01f;
    public GameObject itemPrefab;
    public Transform spawnPoint;
    public Transform targetPoint;
    public float shootForce = 5f;
    public int pickCount;

    void Start() => StartCoroutine(MoveRandomly());

    IEnumerator MoveRandomly()
    {
        while (true)
        {
            float waitTime = Random.Range(0.5f, 1f);
            Vector3 randomOffset = Random.insideUnitSphere * radius;
            randomOffset.y = 0;
            transform.position = centerPoint.position + randomOffset;

            yield return new WaitForSeconds(waitTime);
        }
    }

    public void Fire()
    {
        if (DataManager.Instance.pickCount <= 0) return;

        GameObject item = Instantiate(itemPrefab, spawnPoint.position, Quaternion.identity);
        Rigidbody rb = item.GetComponent<Rigidbody>();
        Vector3 dir = (targetPoint.position - spawnPoint.position).normalized;

        rb.AddForce(dir * shootForce, ForceMode.Impulse);
        DataManager.Instance.pickCount--;
    }
}