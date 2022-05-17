using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mortarBulletMove : MonoBehaviour
{
    public Rigidbody2D _rigidbody;

    public float upPower;
    public float horPower;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody.AddForce(Vector2.up * upPower);
        _rigidbody.AddForce(Vector2.right * horPower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
