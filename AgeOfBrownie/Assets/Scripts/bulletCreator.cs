using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCreator : MonoBehaviour
{
    public GameObject bullet;

    public float maxShotDelay;
    public float curShotDelay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attack();
        reload();    
    }

    void attack()
    {
        if (curShotDelay < maxShotDelay)
        {
            return;
        }

        Instantiate(bullet, transform.position, transform.rotation);

        curShotDelay = 0;
    }

    void reload()
    {
        curShotDelay += Time.deltaTime;
    }
}
