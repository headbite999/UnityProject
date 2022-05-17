using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2AI : MonoBehaviour
{
    public GameManager gameManager;
    public UnitStatus baseHP;

    public GameObject assault;
    public GameObject defender;
    public GameObject mortar;
    public GameObject bomber;
    public GameObject hero;

    public GameObject gate;

    public float count = 0;
    public float heroCount = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (baseHP.HP > 0)
        {
            if (count < 10 && gameManager.T2coin == 10)
            {
                assaultSummon();
                count++;
            }
            if (count >= 10 && count < 20 && gameManager.T2coin == 25)
            {
                assaultSummon();
                defenderSummon();
                count++;
            }
            if (count >= 20 && gameManager.T2coin == 45)
            {
                assaultSummon();
                defenderSummon();
                mortarSummon();
                count++;
            }
            if (count >= 30 && gameManager.T2coin == 65)
            {
                defenderSummon();
                mortarSummon();
                bomberSummon();
                count++;
            }
            if (count >= 30 && baseHP.HP < 800 && heroCount == 0)
            {
                heroSummon();
                heroCount++;
            }
        }


    }

    public void assaultSummon()
    {
        if (gameManager.T2coin >= 10)
        {
            Instantiate(assault, gate.transform.position, gate.transform.rotation);
            gameManager.T2coin -= 10;
        }
    }

    public void defenderSummon()
    {
        if (gameManager.T2coin >= 15)
        {
            Instantiate(defender, gate.transform.position, gate.transform.rotation);
            gameManager.T2coin -= 15;
        }
    }

    public void mortarSummon()
    {
        if (gameManager.T2coin >= 20)
        {
            Instantiate(mortar, gate.transform.position, gate.transform.rotation);
            gameManager.T2coin -= 20;
        }
    }

    public void bomberSummon()
    {
        if (gameManager.T2coin >= 30)
        {
            Instantiate(bomber, gate.transform.position, gate.transform.rotation);
            gameManager.T2coin -= 30;
        }
    }

    public void heroSummon()
    {
        if (gameManager.T2coin >= 80)
        {
            Instantiate(hero, gate.transform.position, gate.transform.rotation);
            gameManager.T2coin -= 80;
        }
    }
}
