using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Rigidbody2D Maincamera;


    public void CameraRight()
    {
        Maincamera.velocity = new Vector2(2, 0);
    }

    public void CameraLeft()
    {
        Maincamera.velocity = new Vector2(-2, 0);
    }
}
