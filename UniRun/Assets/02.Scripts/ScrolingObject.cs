using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ������Ʈ�� ��� �������� �����̴� ��ũ��Ʈ
public class ScrolingObject : MonoBehaviour
{
    public float speed = 10f; //�̵� �ӵ�
    void Update()
    {
        // ���� ������ �ƴ϶��
        if (!GameManager.instance.isGameover)
        {
            //�ʴ� speed�� �ӵ��� �������� �����̵�
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            //transform.Translate(new Vector2(-1, 0) * speed *Time.deltaTime, Space.Self);
        }
    }
}
