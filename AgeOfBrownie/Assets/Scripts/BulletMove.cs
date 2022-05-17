using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public Rigidbody2D bulletRigidbody;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletRigidbody.velocity = new Vector2(speed, 0); // ÀüÁø
    }
}
