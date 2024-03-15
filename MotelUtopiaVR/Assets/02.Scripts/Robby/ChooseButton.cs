using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseButton : MonoBehaviour
{
    public GameObject but;
    public GameObject key;
    public GameObject place;

    public float moveSpeed = 1f;

    private bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        Button button = but.GetComponent<Button>(); // UI 버튼 컴포넌트 가져오기
        button.onClick.AddListener(MoveObject);

    }

   public void MoveObject()
    {
        if (!isMoving)
        {
            isMoving = true;
            StartCoroutine(MoveCoroutine());
        }
    }

    IEnumerator MoveCoroutine()
    {
        // 오브젝트 A가 오브젝트 B로 이동하는 동안 계속 반복
        while (Vector3.Distance(key.transform.position, place.transform.position) > 0.01f)
        {
            // 오브젝트 A를 오브젝트 B로 부드럽게 이동
            key.transform.position = Vector3.MoveTowards(place.transform.position, place.transform.position, moveSpeed * Time.deltaTime);
            yield return null; // 한 프레임 대기
        }
        isMoving = false;
    }
}
