using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackRange : MonoBehaviour
{
    public bool attackDecision = false;

    public string enemyTag;

    private void Update()
    {
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag(enemyTag))
        {
            attackDecision = true;
            Debug.Log("적 단독");
        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag(enemyTag))
        {
            attackDecision = true;
            Debug.Log("적 단독");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(enemyTag))
        {
            attackDecision = false;
            Debug.Log("적 없음");
        }
    }
}
