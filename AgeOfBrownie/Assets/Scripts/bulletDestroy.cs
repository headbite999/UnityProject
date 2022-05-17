using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroy : MonoBehaviour
{
    public string _tag1;
    public string _tag2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(_tag1) || collision.CompareTag(_tag2))
        {
            Destroy(gameObject);
        }
        else
            Destroy(gameObject, 5f);

    }
}
