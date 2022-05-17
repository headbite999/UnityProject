using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIbutton : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject assault;
    public GameObject defender;
    public GameObject mortar;
    public GameObject bomber;
    public GameObject hero;

    public GameObject gate;


    void Start()
    {
        
    }

    void Update()
    {

    }

    public void assaultSummon()
    {
        if (gameManager.T1coin >= 10)
        {
            Instantiate(assault, gate.transform.position, gate.transform.rotation);
            gameManager.T1coin -= 10;
        }
    }

    public void defenderSummon()
    {
        if (gameManager.T1coin >= 15)
        {
            Instantiate(defender, gate.transform.position, gate.transform.rotation);
            gameManager.T1coin -= 15;
        }
    }

    public void mortarSummon()
    {
        if (gameManager.T1coin >= 20)
        {
            Instantiate(mortar, gate.transform.position, gate.transform.rotation);
            gameManager.T1coin -= 20;
        }
    }

    public void bomberSummon()
    {
        if (gameManager.T1coin >= 30)
        {
            Instantiate(bomber, gate.transform.position, gate.transform.rotation);
            gameManager.T1coin -= 30;
        }
    }

    public void heroSummon()
    {
        if (gameManager.T1coin >= 80)
        {
            Instantiate(hero, gate.transform.position, gate.transform.rotation);
            gameManager.T1coin -= 80;
        }
    }
}
