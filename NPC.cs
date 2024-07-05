using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //�������� NPC
    public int health = 5;
    //������� NPC
    public int level = 1;
    //�������� NPC
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("�����:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        //������� NPC
        Vector3 newPosition = transform.position;
        //�� ��� Z
        newPosition.z += speed * Time.deltaTime;
        //������
        transform.position = newPosition;
    }
}
