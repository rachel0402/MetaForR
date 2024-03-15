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
        Button button = but.GetComponent<Button>(); // UI ��ư ������Ʈ ��������
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
        // ������Ʈ A�� ������Ʈ B�� �̵��ϴ� ���� ��� �ݺ�
        while (Vector3.Distance(key.transform.position, place.transform.position) > 0.01f)
        {
            // ������Ʈ A�� ������Ʈ B�� �ε巴�� �̵�
            key.transform.position = Vector3.MoveTowards(place.transform.position, place.transform.position, moveSpeed * Time.deltaTime);
            yield return null; // �� ������ ���
        }
        isMoving = false;
    }
}
