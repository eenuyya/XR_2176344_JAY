using UnityEngine;

public class Door_Controller : MonoBehaviour
{
    public Animator Animator;
    public Transform player;

    public Transform doorPivot;
    public GameObject Inside;
    public GameObject Outside;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 거리 계산: 어디서 접근했는지 판별
            float toInside = Vector3.Distance(player.position, Inside.transform.position);
            float toOutside = Vector3.Distance(player.position, Outside.transform.position);

            bool enteredFromInside = toInside < toOutside;

            // 회전 방향 설정
            doorPivot.localRotation = enteredFromInside
                ? Quaternion.Euler(0, 180, 0)  
                : Quaternion.Euler(0, 0, 0);  

            // 문 열기 애니메이션 시작
            Animator.SetInteger("status", 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 문 닫기
            Animator.SetInteger("status", 2);
        }
    }

    private void OnTriggerStay(Collider other)
{
    if (other.CompareTag("Player"))
    {
        float toInside = Vector3.Distance(player.position, Inside.transform.position);
        float toOutside = Vector3.Distance(player.position, Outside.transform.position);

        string location = toInside < toOutside ? "🏠 실내 (Inside)" : "🌳 실외 (Outside)";
        Debug.Log($"[위치 추적] 현재 위치는: {location} (InsideDist: {toInside:F2}, OutsideDist: {toOutside:F2})");
    }
}
}

