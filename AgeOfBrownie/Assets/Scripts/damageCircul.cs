using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageCircul : MonoBehaviour
{
    // 적에게 공격 받았을 때 데미지 계산
    public UnitStatus unitStatus;

    public string bulletTag_1;
    public float damage_1;

    public string bulletTag_2;
    public float damage_2;

    public string bulletTag_3;
    public float damage_3;

    public string bulletTag_4;
    public float damage_4;

    public string bulletTag_5;
    public float damage_5;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // 데미지 받는 유형
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(bulletTag_1))
        {
            unitStatus.HP -= damage_1;
        }
        else if (collision.CompareTag(bulletTag_2))
        {
            unitStatus.HP -= damage_2;
        }
        else if (collision.CompareTag(bulletTag_3))
        {
            unitStatus.HP -= damage_3;
        }
        else if (collision.CompareTag(bulletTag_4))
        {
            unitStatus.HP -= damage_4;
        }
        else if (collision.CompareTag(bulletTag_5))
        {
            unitStatus.HP -= damage_5;
        }
    }
}
