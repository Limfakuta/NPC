using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWniz : MonoBehaviour
{
    //Здоровье NPC
    public int health = 5;
    //Уровень NPC
    public int level = 1;
    //Скорость NPC
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Жизни:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        //Позиция NPC
        Vector3 newPosition = transform.position;
        //По оси -y
        newPosition.y -= speed * Time.deltaTime;
        //Меняет
        transform.position = newPosition;
    }
}
